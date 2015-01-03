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
    public class FinanceStockOutDAL
    {
        private DBHelper dbHelper = new DBHelper();

        /// <summary>
        /// 查询出所有售票室管理员
        /// </summary>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public DataTable BindTicketLeadBackCombox(ref string errorCode)
        {
            DataTable dt = null;
            try
            {
                string sqlStr = @"SELECT
                                            USER_ID AS ID, 
                                            USER_NAME AS NAME 
                                        FROM TSS_USER
                                        WHERE IS_DEL = '0'
                                        AND ROLE_ID = 'R00003'";
                dt = dbHelper.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                // 记录日志
                errorCode = "ERROR_001";
            }
            return dt;
        }

        public bool SaveFinanceStockOut(FinanceStockOutEntity financeStockOutEntity, ref string errorCode) 
        {
            bool flag = true;
            ArrayList strListSQL = new ArrayList();
            try
            {
                string ticketID = financeStockOutEntity.FOUT_TICKET_START;
                string prefixStr = ticketID.Substring(0, 2);
                int iStartTicketID = Int32.Parse(ticketID.Substring(2));
                // =======================插入财务出库表====================== //
                string sqlStr = string.Format(@"INSERT INTO TSS_FINANCIAL_OUT(
                                                FOUT_LEADBACK_ID, FOUT_TICKET_START, FOUT_TICKET_COUNT
                                                ,FOUT_TICKET_END, FOUT_OPERATE_ID
                                                ,FOUT_OPERATE_DATE, FOUT_TYPE) 
                                        VALUES (
                                                 '{0}', '{1}', '{2}'
                                                ,'{3}', '{4}'
                                                ,'{5}', '{6}')",
                                        financeStockOutEntity.FOUT_LEADBACK_ID,
                                        financeStockOutEntity.FOUT_TICKET_START,
                                        financeStockOutEntity.FOUT_TICKET_COUNT,
                                        financeStockOutEntity.FOUT_TICKET_END,
                                        financeStockOutEntity.FOUT_OPERATE_ID,
                                        financeStockOutEntity.FOUT_OPERATE_DATE,
                                        financeStockOutEntity.FOUT_TYPE);
                strListSQL.Add(sqlStr);
                // =======================更新门票信息表====================== //
                sqlStr = string.Format(@"UPDATE TSS_TICKET
                                                        SET IS_FOUT = '1', TICKET_FOUT_USER_ID = '{0}', TICKET_FOUT_DATE = GETDATE()
                                                        WHERE TICKET_ID BETWEEN '{1}' AND '{2}'
                                                        AND IS_DEL = '0'",
                                        financeStockOutEntity.FOUT_LEADBACK_ID,
                                        financeStockOutEntity.FOUT_TICKET_START,
                                        financeStockOutEntity.FOUT_TICKET_END);
                strListSQL.Add(sqlStr);
                // =======================插入财务出库明细表====================== //
                //DataSet tDS = dbHelper.Query("select * from TSS_TICKET where 1=2", "TSS_TICKET"); //new DataTable("TSS_TICKET");
                //DataTable tDT = tDS.Tables["TSS_TICKET"];
                //DateTime time = DateTime.Now;
                //for (int i = 1; i <= financeStockOutEntity.FOUT_TICKET_COUNT; i++)
                //{
                //    DataRow dataRow = tDT.NewRow();
                //    dataRow["TICKET_ID"] = ticketID;
                //    dataRow["TICKET_FOUT_USER_ID"] = userID;
                //    dataRow["TICKET_FOUT_DATE"] = time;
                //    dataRow["TICKET_OUT_USER_ID"] = DBNull.Value;
                //    dataRow["TICKET_OUT_DATE"] = DBNull.Value;
                //    dataRow["IS_FOUT"] = "0";
                //    dataRow["IS_READY_SALE"] = "0";
                //    dataRow["IS_SALE"] = "0";
                //    dataRow["IS_REFUND"] = "0";
                //    dataRow["IS_CHECKIN"] = "0";
                //    dataRow["VALIDITY_START_DATE"] = time;
                //    dataRow["VALIDITY_END_DATE"] = time.AddYears(1);
                //    dataRow["IS_PREBOOKING"] = "0";
                //    dataRow["IS_DEL"] = "0";
                //    tDT.Rows.Add(dataRow);
                //    ticketID = prefixStr + (iStartTicketID + i).ToString("00000000");
                //}
                //flag = dbHelper.BlukImport(tDT);
                // =====================统一在一个事务中执行并提交==================== //
                //if (flag)
                dbHelper.ExecuteSqlTran(strListSQL);
            }
            catch (Exception ex)
            {
                // 记录日志
                errorCode = "ERROR_002";
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// 查询同类型票据信息
        /// </summary>
        /// <param name="financeStockOutEntity">将要保存的财务出库信息</param>
        /// <param name="errorCode">系统错误编码</param>
        /// <returns>返回数据库中符合条件的票据集合</returns>
        public DataTable GetTicketStockOut(FinanceStockOutEntity financeStockOutEntity, ref string errorCode)
        {
            DataTable dt = null;
            if (financeStockOutEntity == null)
            {
                errorCode = "ERROR_001";
                return dt;
            }
            try
            {
                // 查询出开头为“**”的全部有效票据记录
                string sqlStr = string.Format(@"
                        SELECT
	                        T.TICKET_ID
                        FROM
	                        TSS_TICKET T
                        WHERE
	                        T.IS_DEL = '0'
                        AND
	                        T.TICKET_ID LIKE '{0}%'
                        AND
                            T.IS_FOUT <> '1'
                        AND
	                        T.TICKET_ID BETWEEN '{1}' AND '{2}'"
                        , financeStockOutEntity.FOUT_TICKET_START.Substring(0, 2)
                        , financeStockOutEntity.FOUT_TICKET_START
                        , financeStockOutEntity.FOUT_TICKET_END);
                dt = dbHelper.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                errorCode = "ERROR_002";
            }
            return dt;
        }

        public bool SaveFinanceStockOutBack(FinanceStockOutEntity financeStockOutEntity, ref string errorCode)
        {
            bool flag = true;
            ArrayList strListSQL = new ArrayList();
            try
            {
                string ticketID = financeStockOutEntity.FOUT_TICKET_START;
                string prefixStr = ticketID.Substring(0, 2);
                int iStartTicketID = Int32.Parse(ticketID.Substring(2));
                // =======================插入财务出库表====================== //
                string sqlStr = string.Format(@"INSERT INTO TSS_FINANCIAL_OUT(
                                                FOUT_LEADBACK_ID, FOUT_TICKET_START, FOUT_TICKET_COUNT
                                                ,FOUT_TICKET_END, FOUT_OPERATE_ID
                                                ,FOUT_OPERATE_DATE, FOUT_TYPE) 
                                        VALUES (
                                                 '{0}', '{1}', '{2}'
                                                ,'{3}', '{4}'
                                                ,'{5}', '{6}')",
                                        financeStockOutEntity.FOUT_LEADBACK_ID,
                                        financeStockOutEntity.FOUT_TICKET_START,
                                        financeStockOutEntity.FOUT_TICKET_COUNT,
                                        financeStockOutEntity.FOUT_TICKET_END,
                                        financeStockOutEntity.FOUT_OPERATE_ID,
                                        financeStockOutEntity.FOUT_OPERATE_DATE,
                                        financeStockOutEntity.FOUT_TYPE);
                strListSQL.Add(sqlStr);
                // =======================更新门票信息表====================== //
                sqlStr = string.Format(@"UPDATE TSS_TICKET
                                                        SET IS_FOUT = '2', TICKET_FOUT_USER_ID = '{0}', TICKET_FOUT_DATE = GETDATE()
                                                        WHERE TICKET_ID BETWEEN '{1}' AND '{2}'
                                                        AND IS_DEL = '0'",
                                        financeStockOutEntity.FOUT_LEADBACK_ID,
                                        financeStockOutEntity.FOUT_TICKET_START,
                                        financeStockOutEntity.FOUT_TICKET_END);
                strListSQL.Add(sqlStr);
                // =======================插入财务出库回库明细表====================== //
                //DataSet tDS = dbHelper.Query("select * from TSS_TICKET where 1=2", "TSS_TICKET"); //new DataTable("TSS_TICKET");
                //DataTable tDT = tDS.Tables["TSS_TICKET"];
                //DateTime time = DateTime.Now;
                //for (int i = 1; i <= financeStockOutEntity.FOUT_TICKET_COUNT; i++)
                //{
                //    DataRow dataRow = tDT.NewRow();
                //    dataRow["TICKET_ID"] = ticketID;
                //    dataRow["TICKET_FOUT_USER_ID"] = userID;
                //    dataRow["TICKET_FOUT_DATE"] = time;
                //    dataRow["TICKET_OUT_USER_ID"] = DBNull.Value;
                //    dataRow["TICKET_OUT_DATE"] = DBNull.Value;
                //    dataRow["IS_FOUT"] = "0";
                //    dataRow["IS_READY_SALE"] = "0";
                //    dataRow["IS_SALE"] = "0";
                //    dataRow["IS_REFUND"] = "0";
                //    dataRow["IS_CHECKIN"] = "0";
                //    dataRow["VALIDITY_START_DATE"] = time;
                //    dataRow["VALIDITY_END_DATE"] = time.AddYears(1);
                //    dataRow["IS_PREBOOKING"] = "0";
                //    dataRow["IS_DEL"] = "0";
                //    tDT.Rows.Add(dataRow);
                //    ticketID = prefixStr + (iStartTicketID + i).ToString("00000000");
                //}
                //flag = dbHelper.BlukImport(tDT);
                // =====================统一在一个事务中执行并提交==================== //
                //if (flag)
                dbHelper.ExecuteSqlTran(strListSQL);
            }
            catch (Exception ex)
            {
                // 记录日志
                errorCode = "ERROR_002";
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// 查询同类型票据信息
        /// </summary>
        /// <param name="financeStockOutEntity">将要保存的财务出库回库信息</param>
        /// <param name="errorCode">系统错误编码</param>
        /// <returns>返回数据库中符合条件的票据集合</returns>
        public DataTable GetTicketStockOutBack(FinanceStockOutEntity financeStockOutEntity, ref string errorCode)
        {
            DataTable dt = null;
            if (financeStockOutEntity == null)
            {
                errorCode = "ERROR_001";
                return dt;
            }
            try
            {
                // 查询出开头为“**”的可财务出库回库的票据记录
                string sqlStr = string.Format(@"
                        SELECT
	                        T.TICKET_ID
                        FROM
	                        TSS_TICKET T
                        WHERE
	                        T.IS_DEL = '0'
                        AND
	                        T.TICKET_ID LIKE '{0}%'
                        AND
                            T.IS_READY_SALE <> '1'
                        AND
                            T.IS_FOUT = '1'
                        AND
                            T.TICKET_FOUT_USER_ID = '{1}'
                        AND
	                        T.TICKET_ID BETWEEN '{2}' AND '{3}'"
                        , financeStockOutEntity.FOUT_TICKET_START.Substring(0, 2)
                        , financeStockOutEntity.FOUT_LEADBACK_ID
                        , financeStockOutEntity.FOUT_TICKET_START
                        , financeStockOutEntity.FOUT_TICKET_END);
                dt = dbHelper.ExecuteQuery(sqlStr);
            }
            catch (Exception ex)
            {
                errorCode = "ERROR_002";
            }
            return dt;
        }
    }
}
