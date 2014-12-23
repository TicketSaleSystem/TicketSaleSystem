using System;
using System.Text;

namespace TSS_Model.TicketOperate
{
    /// <summary>
    /// 财务入库实体类
    /// </summary>
    public class FinanceStockInEntity
    {
        private string fin_supply_id;

        public string FIN_SUPPLY_ID
        {
            get { return fin_supply_id; }
            set { fin_supply_id = value; }
        }
        private string fin_ticket_start;

        public string FIN_TICKET_START
        {
            get { return fin_ticket_start; }
            set { fin_ticket_start = value; }
        }
        private int fin_ticket_count;

        public int FIN_TICKET_COUNT
        {
            get { return fin_ticket_count; }
            set { fin_ticket_count = value; }
        }
        private string fin_ticket_end;

        public string FIN_TICKET_END
        {
            get { return fin_ticket_end; }
            set { fin_ticket_end = value; }
        }
        private string fin_ticket_item_id;

        public string FIN_TICKET_ITEM_ID
        {
            get { return fin_ticket_item_id; }
            set { fin_ticket_item_id = value; }
        }
        private string fin_operate_id;

        public string FIN_OPERATE_ID
        {
            get { return fin_operate_id; }
            set { fin_operate_id = value; }
        }
        private DateTime fin_operate_date;

        public DateTime FIN_OPERATE_DATE
        {
            get { return fin_operate_date; }
            set { fin_operate_date = value; }
        }
        private string fin_type;

        public string FIN_TYPE
        {
            get { return fin_type; }
            set { fin_type = value; }
        }
    }
}
