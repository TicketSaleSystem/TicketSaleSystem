using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ToolsHelper;

namespace TSS_DAL.TicketOperate
{
    public class SaleDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// 根据填写的门票条码吃查询出最新一条该类型已出售的条码号
        /// </summary>
        /// <param name="strMPTM">门票条码</param>
        /// <param name="errorCode">系统错误编码</param>
        /// <returns>查询到的已出售的最新一条门票条码</returns>
        public string GetLastMPTM(string strMPTM, ref string errorCode)
        {
            string strLastMPTM = "";
            try
            {
                string sqlStr = string.Format(@"
                        SELECT TOP 1 T.SALE_TICKET_END
                        FROM TSS_SALE T
                        WHERE T.SALE_TICKET_ID LIKE '{0}%'
                        AND T.IS_DEL = '0' AND T.SALE_OPERATE_ID = '{1}'
                        ORDER BY T.SALE_OPERATE_DATE DESC"
                    , "JA", "0005");
                object obj = dbHelper.GetSingle(sqlStr);
                if (obj != null)
                    strLastMPTM = obj.ToString();
            }
            catch (Exception ex) 
            {
                errorCode = "ERROR_002";
            }
            return strLastMPTM;
        }
    }
}
