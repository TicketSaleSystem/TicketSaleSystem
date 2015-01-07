using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ToolsHelper;

namespace TSS_DAL
{
    /// <summary>
    /// 主界面-数据库操作类
    /// </summary>
    public class MainFormDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// 根据用户ID获取树结构数据
        /// </summary>
        /// <param name="userID"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public DataTable BindMainFormTreeList(string userID, ref string errorCode)
        {
            DataTable dt = null;
            try
            {
                string sqlStr = string.Format(@"
                        SELECT P.MODULES
                        FROM TSS_USER T
                        INNER JOIN TSS_USER_ROLE P ON T.ROLE_ID = P.ROLE_ID
                        WHERE T.USER_ID = '{0}' AND P.IS_DEL = '0' AND T.IS_DEL = '0'", userID);
                string modules = dbHelper.GetSingle(sqlStr).ToString().Trim();
                if (!string.IsNullOrEmpty(modules))
                {
                    string[] module = modules.Split(';');
                    string keys = "";
                    string startWith = module[0].Substring(0, 1);
                    keys = module[0].Replace(startWith + "0", "").Replace(startWith, "");
                    for (int i = 1; i < module.Length - 1; i++)
                    {
                        keys += ("," + module[i].Replace(startWith + "0", "").Replace(startWith, ""));
                    }
                    sqlStr = string.Format(@"
                            SELECT
                                 CONVERT(INT,SUBSTRING(t.DICT_ID,2,4)) AS ID
                                ,t.DICT_NAME AS COLNAME
                                ,CONVERT(INT,SUBSTRING(t.DICT_PID,2,4)) AS PID
                            FROM
                                TSS_DICTIONARY T
                            WHERE
                                T.DICT_TYPE = 'Modules'
                            AND
	                            (CONVERT(INT,SUBSTRING(t.DICT_ID,2,4)) BETWEEN 200 AND 499)
                            AND
	                            CONVERT(INT,SUBSTRING(t.DICT_ID,2,4)) IN ({0})
                            ORDER BY T.ID", keys);
                    dt = dbHelper.ExecuteQuery(sqlStr);
                }
            }
            catch (Exception ex)
            {
                // 记录日志
                errorCode = "ERROR_001";
            }
            return dt;
        }
    }
}
