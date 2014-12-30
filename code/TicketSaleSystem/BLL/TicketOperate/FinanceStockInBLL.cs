using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TSS_DAL.TicketOperate;
using TSS_Model.TicketOperate;

namespace TSS_BLL.TicketOperate
{
    /// <summary>
    /// 财务入库-逻辑业务处理类
    /// </summary>
    public class FinanceStockInBLL
    {
        private FinanceStockInDAL financeStockInDAL = new FinanceStockInDAL();

        public DataTable BindTicketSupplyCombox(ref string errorCode)
        {
            return financeStockInDAL.BindTicketSupplyCombox(ref errorCode);
        }

        public DataTable BindTicketItemCombox(ref string errorCode)
        {
            return financeStockInDAL.BindTicketItemCombox(ref errorCode);
        }

        /// <summary>
        /// 保存财务入库信息
        /// </summary>
        /// <param name="financeStockInEntity"></param>
        /// <param name="userID"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public bool SaveFinanceStockIn(FinanceStockInEntity financeStockInEntity, string userID, ref string errorCode)
        {
            bool flag = false;
            if (financeStockInEntity == null) 
            {
                errorCode = "ERROR_BLL_001";
                return flag;
            }
            // 查询数据段是否存在交叉
            string filterExpression = string.Format("(FIN_TICKET_START <= '{0}' and FIN_TICKET_END >= '{0}') or (FIN_TICKET_START <= '{1}' and FIN_TICKET_END >= '{1}')",
                financeStockInEntity.FIN_TICKET_START.Substring(2), financeStockInEntity.FIN_TICKET_END.Substring(2));
            try
            {
                // 无数据的具体原因分两种， 1： SQL查询出现系统级别错误， 2：存在票号数据交叉，不能保存
                DataTable dt = financeStockInDAL.GetTicketStockIn(financeStockInEntity, ref errorCode);
                if (dt != null && dt.Rows.Count > 0)
                {
                    errorCode = "MSG_001"; // 已存在相关票据不能再次入库
                }
                else if (dt != null && dt.Rows.Count == 0)
                {
                    flag = financeStockInDAL.SaveFinanceStockIn(financeStockInEntity, userID, ref errorCode);
                }
                else
                {
                    // errorCode 在 DAL 的 GetTicketStockIn 方法内被赋值
                }
            }
            catch (Exception ex)
            {
                // 记录日志
                flag = false;
            }
            return flag;
        }

        /// <summary>
        /// 保存财务入库退票信息
        /// </summary>
        /// <param name="financeStockInEntity"></param>
        /// <param name="userID"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public bool SaveFinanceStockInBack(FinanceStockInEntity financeStockInEntity, string userID, ref string errorCode)
        {
            bool flag = false;
            if (financeStockInEntity == null)
            {
                errorCode = "ERROR_BLL_001";
                return flag;
            }
            try
            {
                flag = financeStockInDAL.SaveFinanceStockInBack(financeStockInEntity, userID, ref errorCode);
            }
            catch (Exception ex)
            {
                // 记录日志
                flag = false;
            }
            return flag;
        }
    }
}
