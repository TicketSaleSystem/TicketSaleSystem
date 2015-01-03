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
    /// 门票出库-逻辑业务处理类
    /// </summary>
    public class TicketOutBLL
    {
        private TicketOutDAL ticketOutDAL = new TicketOutDAL();

        public DataTable BindTicketLeadBackCombox(ref string errorCode)
        {
            return ticketOutDAL.BindTicketLeadBackCombox(ref errorCode);
        }

        /// <summary>
        /// 保存门票出库信息
        /// </summary>
        /// <param name="ticketOutEntity"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public bool SaveTicketOut(TicketOutEntity ticketOutEntity, ref string errorCode)
        {
            bool flag = false;
            if (ticketOutEntity == null)
            {
                errorCode = "ERROR_BLL_001";
                return flag;
            }
            try
            {
                // 无数据的具体原因分两种， 1： SQL查询出现系统级别错误， 2：按条件查询到的门票出库的票据个数与填写的个数不符
                DataTable dt = ticketOutDAL.GetTicketOut(ticketOutEntity, ref errorCode);
                if (dt == null)
                    return flag;

                if(dt.Rows.Count != ticketOutEntity.TOUT_TICKET_COUNT)
                {
                    errorCode = "MSG_001"; // 按条件查询到的门票出库的票据个数与填写的个数不符
                }
                else
                {
                    flag = ticketOutDAL.SaveTicketOut(ticketOutEntity, ref errorCode);
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
        /// 保存门票出库回库信息
        /// </summary>
        /// <param name="ticketOutEntity"></param>
        /// <param name="errorCode"></param>
        /// <returns></returns>
        public bool SaveTicketOutBack(TicketOutEntity ticketOutEntity, ref string errorCode)
        {
            bool flag = false;
            if (ticketOutEntity == null)
            {
                errorCode = "ERROR_BLL_001";
                return flag;
            }
            try
            {
                // 无数据的具体原因分两种， 1： SQL查询出现系统级别错误， 2：按条件查询到的门票出库回库的票据个数与填写的个数不符
                DataTable dt = ticketOutDAL.GetTicketOutBack(ticketOutEntity, ref errorCode);
                if (dt == null)
                    return flag;

                if (dt.Rows.Count != ticketOutEntity.TOUT_TICKET_COUNT)
                {
                    errorCode = "MSG_001"; // 按条件查询到的门票出库回库的票据个数与填写的个数不符
                }
                else
                {
                    flag = ticketOutDAL.SaveTicketOutBack(ticketOutEntity, ref errorCode);
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
