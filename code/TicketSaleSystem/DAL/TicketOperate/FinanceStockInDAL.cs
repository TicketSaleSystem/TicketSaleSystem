using System;
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
        public bool SaveFinanceStockIn(FinanceStockInEntity financeStockInEntity)
        {
            bool flag = false;
            try
            {
                string sqlStr = @"INSERT INTO TSS_FINANCIAL_IN(
                                                    FIN_SUPPLY_ID, FIN_TICKET_START, FIN_TICKET_COUNT
                                                   ,FIN_TICKET_END, FIN_TICKET_ITEM_ID, FIN_OPERATE_ID
                                                   ,FIN_OPERATE_DATE, FIN_TYPE) 
                                           VALUES (
                                                    @FIN_SUPPLY_ID, @FIN_TICKET_START, @FIN_TICKET_COUNT
                                                   ,@FIN_TICKET_END, @FIN_TICKET_ITEM_ID, @FIN_OPERATE_ID
                                                   ,@FIN_OPERATE_DATE, @FIN_TYPE)";
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@FIN_SUPPLY_ID", SqlDbType.NVarChar),
                    new SqlParameter("@FIN_TICKET_START", SqlDbType.NVarChar),
                    new SqlParameter("@FIN_TICKET_COUNT", SqlDbType.Int),
                    new SqlParameter("@FIN_TICKET_END", SqlDbType.NVarChar),
                    new SqlParameter("@FIN_TICKET_ITEM_ID", SqlDbType.NVarChar),
                    new SqlParameter("@FIN_OPERATE_ID", SqlDbType.NVarChar),
                    new SqlParameter("@FIN_OPERATE_DATE", SqlDbType.DateTime),
                    new SqlParameter("@FIN_TYPE", SqlDbType.NVarChar)
                };
                sqlParams[0].Value = financeStockInEntity.FIN_SUPPLY_ID;
                sqlParams[1].Value = financeStockInEntity.FIN_TICKET_START;
                sqlParams[2].Value = financeStockInEntity.FIN_TICKET_COUNT;
                sqlParams[3].Value = financeStockInEntity.FIN_TICKET_END;
                sqlParams[4].Value = financeStockInEntity.FIN_TICKET_ITEM_ID;
                sqlParams[5].Value = financeStockInEntity.FIN_OPERATE_ID;
                sqlParams[6].Value = financeStockInEntity.FIN_OPERATE_DATE;
                sqlParams[7].Value = financeStockInEntity.FIN_TYPE;
                int returnValue = SqlHelper.ExecuteNonQuery(SqlHelper.ConStr, CommandType.Text, sqlStr, sqlParams);
                flag = returnValue == 1;
            }
            catch (Exception ex)
            {
                // 记录日志
            }
            return flag;
        }
    }
}
