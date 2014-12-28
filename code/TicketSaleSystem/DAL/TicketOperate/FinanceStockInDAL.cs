using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using ToolsHelper;
using TSS_Model.TicketOperate;

namespace TSS_DAL.TicketOperate
{
    /// <summary>
    /// 财务入库-数据库操作类
    /// </summary>
    public class FinanceStockInDAL
    {
        private DBHelper dbHelper = new DBHelper();

        public DataTable BindTicketSupplyCombox(ref string errorCode)
        {
            DataTable gpry_dt = new DataTable();
            gpry_dt.Columns.Add("ID", Type.GetType("System.String"));
            gpry_dt.Columns.Add("NAME", Type.GetType("System.String"));
            gpry_dt.Rows.Add(new object[] { "9997", "XX印刷厂" });

            return gpry_dt;
        }

        public DataTable BindTicketItemCombox(ref string errorCode)
        {
            DataTable dt = null;
            try
            {
                string sqlStr = @"SELECT
                                            ITEM_ID AS ID, 
                                            ITEM_NAME AS NAME 
                                        FROM TSS_TICKET_ITEM
                                        WHERE IS_DEL = '0'";
                dt = dbHelper.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                // 记录日志
            }
            return dt;
        }

        public bool SaveFinanceStockIn(FinanceStockInEntity financeStockInEntity, string userID, ref string errorCode)
        {
            bool flag = false;
            ArrayList strListSQL = new ArrayList();
            try
            {
                string ticketID = financeStockInEntity.FIN_TICKET_START;
                string prefixStr = ticketID.Substring(0, 2);
                int iStartTicketID = Int32.Parse(ticketID.Substring(2));
                string sqlStr = string.Format(@"INSERT INTO TSS_FINANCIAL_IN(
                                                FIN_SUPPLY_ID, FIN_TICKET_START, FIN_TICKET_COUNT
                                                ,FIN_TICKET_END, FIN_TICKET_ITEM_ID, FIN_OPERATE_ID
                                                ,FIN_OPERATE_DATE, FIN_TYPE) 
                                        VALUES (
                                                 '{0}', '{1}', '{2}'
                                                ,'{3}', '{4}', '{5}'
                                                ,'{6}', '{7}')", 
                                        financeStockInEntity.FIN_SUPPLY_ID,
                                        financeStockInEntity.FIN_TICKET_START,
                                        financeStockInEntity.FIN_TICKET_COUNT,
                                        financeStockInEntity.FIN_TICKET_END,
                                        financeStockInEntity.FIN_TICKET_ITEM_ID,
                                        financeStockInEntity.FIN_OPERATE_ID,
                                        financeStockInEntity.FIN_OPERATE_DATE,
                                        financeStockInEntity.FIN_TYPE);
                // =======================插入主表====================== //
                strListSQL.Add(sqlStr);
                DataSet tDS = dbHelper.Query("select * from TSS_TICKET where 1=2", "TSS_TICKET"); //new DataTable("TSS_TICKET");
                DataTable tDT = tDS.Tables["TSS_TICKET"];
                DateTime time = DateTime.Now;
                for (int i = 1; i <= financeStockInEntity.FIN_TICKET_COUNT; i++)
                {
                    DataRow dataRow = tDT.NewRow();
                    // =====================插入门票信息表==================== //
                    dataRow["TICKET_ID"] = ticketID;
                    dataRow["TICKET_ITEM_ID"] = financeStockInEntity.FIN_TICKET_ITEM_ID;
                    dataRow["TICKET_FIN_USER_ID"] = userID;
                    dataRow["TICKET_FIN_DATE"] = time;
                    dataRow["TICKET_OUT_USER_ID"] = DBNull.Value;
                    dataRow["TICKET_OUT_DATE"] = DBNull.Value;
                    dataRow["IS_FOUT"] = "0";
                    dataRow["IS_READY_SALE"] = "0";
                    dataRow["IS_SALE"] = "0";
                    dataRow["IS_REFUND"] = "0";
                    dataRow["IS_CHECKIN"] = "0";
                    dataRow["VALIDITY_START_DATE"] = time;
                    dataRow["VALIDITY_END_DATE"] = time.AddYears(1);
                    dataRow["IS_PREBOOKING"] = "0";
                    dataRow["IS_DEL"] = "0";
                    tDT.Rows.Add(dataRow);
                    ticketID = prefixStr + (iStartTicketID + i).ToString("00000000");
                }
                flag = dbHelper.BlukImport(tDT);
                // =====================统一在一个事务中执行并提交==================== //
                if (flag) 
                    dbHelper.ExecuteSqlTran(strListSQL);
            }
            catch (Exception ex)
            {
                // 记录日志
            }
            return flag;
        }

        /// <summary>
        /// 查询同类型票据信息
        /// </summary>
        /// <param name="financeStockInEntity">财务入库信息</param>
        /// <param name="errorCode">系统错误编码</param>
        /// <returns>返回同类型票据信息</returns>
        public DataTable GetTicketStockIn(FinanceStockInEntity financeStockInEntity, ref string errorCode)
        {
            if (financeStockInEntity == null) return null;

            // 查询出开头为“**”的全部有效财务入库记录
            string sqlStr = string.Format(@"
                    SELECT
                        SUBSTRING(T.FIN_TICKET_START, 3, LEN(T.FIN_TICKET_START)) as FIN_TICKET_START,
	                    SUBSTRING(T.FIN_TICKET_END, 3, LEN(T.FIN_TICKET_START)) as FIN_TICKET_END
                    FROM 
                        TSS_FINANCIAL_IN T
                    WHERE
	                    T.FIN_TICKET_START LIKE '{0}%'
                    AND
	                    T.FIN_TYPE = '0'"
                    , financeStockInEntity.FIN_TICKET_START.Substring(0, 2));
            DataTable dt = dbHelper.ExecuteQuery(sqlStr);
            return dt;
        }

        /// <summary>
        /// 保存财务入库退票信息，更新IS_DEL为1
        /// </summary>
        /// <param name="financeStockInEntity"></param>
        /// <param name="userID"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public bool SaveFinanceStockInBack(FinanceStockInEntity financeStockInEntity, string userID, ref string errorCode)
        {
            bool flag = false;
            try
            {

            }
            catch (Exception ex)
            {
                // 记录日志
            }
            return flag;
        }

        public DataTable GetTicketStockInBack(FinanceStockInEntity financeStockInEntity, string userID, ref string errorCode)
        {
            if (financeStockInEntity == null) return null;

            // 查询出开头为“**”的全部有效财务入库记录
            string sqlStr = string.Format(@"
                    SELECT
                        SUBSTRING(T.FIN_TICKET_START, 3, LEN(T.FIN_TICKET_START)) as FIN_TICKET_START,
	                    SUBSTRING(T.FIN_TICKET_END, 3, LEN(T.FIN_TICKET_START)) as FIN_TICKET_END
                    FROM 
                        TSS_FINANCIAL_IN T
                    WHERE
	                    T.FIN_TICKET_START LIKE '{0}%'
                    AND
	                    T.FIN_TYPE = '0'
                    AND
                        T.FIN_OPERATE_ID = '{1}'"
                    , financeStockInEntity.FIN_TICKET_START.Substring(0, 2)
                    , userID);
            DataTable dt = dbHelper.ExecuteQuery(sqlStr);
            return dt;
        }
    }
}
