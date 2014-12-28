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
            if (financeStockInEntity == null) return flag;
            // 查询数据段是否存在交叉
            string filterExpression = string.Format("(FIN_TICKET_START <= '{0}' and FIN_TICKET_END >= '{0}') or (FIN_TICKET_START <= '{1}' and FIN_TICKET_END >= '{1}')",
                financeStockInEntity.FIN_TICKET_START.Substring(2), financeStockInEntity.FIN_TICKET_END.Substring(2));
            try
            {
                // 无数据的具体原因分两种， 1： SQL查询出现系统级别错误， 2：存在票号数据交叉，不能保存
                DataTable dt = financeStockInDAL.GetTicketStockIn(financeStockInEntity, ref errorCode);
                if (dt != null && dt.Rows.Count > 0)
                {
                    // 对比本次需保存的数据是否在这些数据段【外】，不交叉则返回true
                    DataRow[] arrayDR = dt.Select(filterExpression);
                    flag = (arrayDR.Length == 0);
                    if (flag)
                        financeStockInDAL.SaveFinanceStockIn(financeStockInEntity, userID, ref errorCode);
                    else
                        errorCode = "MSG_001";
                }
                else if (dt != null && dt.Rows.Count == 0)
                {
                    flag = financeStockInDAL.SaveFinanceStockIn(financeStockInEntity, userID, ref errorCode);
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
            if (financeStockInEntity == null) return flag;
            try
            {
                // 获取可退的同类型票
                DataTable dt = financeStockInDAL.GetTicketStockInBack(financeStockInEntity, userID, ref errorCode);
                // 查询本次退票信息是否包含在内其中一条之内
                string filterExpression = string.Format("FIN_TICKET_START >= '{0}' and FIN_TICKET_END <= '{1}'",
                    financeStockInEntity.FIN_TICKET_START.Substring(2), financeStockInEntity.FIN_TICKET_END.Substring(2));
                if (dt != null && dt.Rows.Count > 0)
                {
                    DataTable newDT = SpliceFinanceStockInBackData(dt); // 需先合并首尾相接的数据
                    // 对比本次需保存的数据是否在这些数据段【内】，不交叉则返回true
                    DataRow[] arrayDR = newDT.Select(filterExpression);
                    flag = (arrayDR.Length != 0);
                }
                flag = financeStockInDAL.SaveFinanceStockIn(financeStockInEntity, userID, ref errorCode);
            }
            catch (Exception ex)
            {
                // 记录日志
            }
            return flag;
        }
        
        /// <summary>
        /// 拼接首尾相接的数据
        /// </summary>
        /// <param name="dt"></param>
        /// <returns></returns>
        private DataTable SpliceFinanceStockInBackData(DataTable dt)
        {
            int rowCount = dt.Rows.Count;
            if(rowCount <= 1)
                return dt;

            DataTable newDT = dt.Clone();
            string FIN_TICKET_START = "0";
            string FIN_TICKET_END = "0";
            for (int i = 1; i <= rowCount; i++)
            {
                FIN_TICKET_START = dt.Rows[i - 1][0].ToString();
                FIN_TICKET_END = dt.Rows[i - 1][1].ToString();
                while ((Int32.Parse(dt.Rows[i - 1][1].ToString()) + 1) == Int32.Parse(dt.Rows[i][0].ToString())) 
                {
                    i++;
                    FIN_TICKET_END = dt.Rows[i - 1][1].ToString();
                }
                // 添加行
                DataRow newDR = newDT.NewRow();
                newDR[0] = FIN_TICKET_START;
                newDR[1] = FIN_TICKET_END;
                newDT.Rows.Add(newDR);
			}
            return newDT;
        }
    }
}
