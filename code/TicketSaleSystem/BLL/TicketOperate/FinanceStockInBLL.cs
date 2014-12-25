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

        public bool SaveFinanceStockIn(FinanceStockInEntity financeStockInEntity)
        {
            bool flag = false;
            try
            {
                flag = financeStockInDAL.SaveFinanceStockIn(financeStockInEntity);
            }
            catch (Exception ex)
            {
                // 记录日志
            }
            return flag;
        }
    }
}
