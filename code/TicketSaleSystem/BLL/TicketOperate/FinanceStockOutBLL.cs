using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using TSS_DAL.TicketOperate;
using TSS_Model.TicketOperate;

namespace TSS_BLL.TicketOperate
{
    /// <summary>
    /// 财务出库-逻辑业务处理类
    /// </summary>
    public class FinanceStockOutBLL
    {
        private FinanceStockOutDAL financeStockOutDAL = new FinanceStockOutDAL();

        public DataTable BindTicketLeadBackCombox(ref string errorCode)
        {
            return financeStockOutDAL.BindTicketLeadBackCombox(ref errorCode);
        }

        /// <summary>
        /// 保存财务出库信息
        /// </summary>
        /// <param name="financeStockOutEntity"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public bool SaveFinanceStockOut(FinanceStockOutEntity financeStockOutEntity, ref string errorCode)
        {
            bool flag = false;
            if (financeStockOutEntity == null)
            {
                errorCode = "ERROR_BLL_001";
                return flag;
            }
            try
            {
                // 无数据的具体原因分两种， 1： SQL查询出现系统级别错误， 2：按条件查询到的财务出库的票据个数与填写的个数不符
                DataTable dt = financeStockOutDAL.GetTicketStockOut(financeStockOutEntity, ref errorCode);
                if (dt == null)
                    return flag;

                if(dt.Rows.Count != financeStockOutEntity.FOUT_TICKET_COUNT)
                {
                    errorCode = "MSG_001"; // 按条件查询到的财务出库的票据个数与填写的个数不符
                }
                else
                {
                    flag = financeStockOutDAL.SaveFinanceStockOut(financeStockOutEntity, ref errorCode);
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
        /// 保存财务出库回库信息
        /// </summary>
        /// <param name="financeStockOutEntity"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public bool SaveFinanceStockOutBack(FinanceStockOutEntity financeStockOutEntity, ref string errorCode)
        {
            bool flag = false;
            if (financeStockOutEntity == null)
            {
                errorCode = "ERROR_BLL_001";
                return flag;
            }
            try
            {
                // 无数据的具体原因分两种， 1： SQL查询出现系统级别错误， 2：按条件查询到的财务出库回库的票据个数与填写的个数不符
                DataTable dt = financeStockOutDAL.GetTicketStockOutBack(financeStockOutEntity, ref errorCode);
                if (dt == null)
                    return flag;

                if (dt.Rows.Count != financeStockOutEntity.FOUT_TICKET_COUNT)
                {
                    errorCode = "MSG_001"; // 按条件查询到的财务出库回库的票据个数与填写的个数不符
                }
                else
                {
                    flag = financeStockOutDAL.SaveFinanceStockOutBack(financeStockOutEntity, ref errorCode);
                }
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
