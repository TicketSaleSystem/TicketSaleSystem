using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TSS_DAL.TicketOperate;

namespace TSS_BLL.TicketOperate
{
    public class SaleBLL
    {
        private SaleDAL saleDAL = new SaleDAL();

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
                strLastMPTM = saleDAL.GetLastMPTM(strMPTM, ref errorCode);
            }
            catch (Exception ex)
            {
                errorCode = "ERROR_001";
            }
            return strLastMPTM;
        }
    }
}
