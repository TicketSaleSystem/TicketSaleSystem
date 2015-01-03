using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSS_Model.TicketOperate
{
    /// <summary>
    /// 门票出库实体类
    /// </summary>
    public class TicketOutEntity
    {
        private string tout_leadback_id;

        public string TOUT_LEADBACK_ID
        {
            get { return tout_leadback_id; }
            set { tout_leadback_id = value; }
        }
        private string tout_ticket_start;

        public string TOUT_TICKET_START
        {
            get { return tout_ticket_start; }
            set { tout_ticket_start = value; }
        }
        private int tout_ticket_count;

        public int TOUT_TICKET_COUNT
        {
            get { return tout_ticket_count; }
            set { tout_ticket_count = value; }
        }
        private string tout_ticket_end;

        public string TOUT_TICKET_END
        {
            get { return tout_ticket_end; }
            set { tout_ticket_end = value; }
        }
        private string tout_operate_id;

        public string TOUT_OPERATE_ID
        {
            get { return tout_operate_id; }
            set { tout_operate_id = value; }
        }
        private DateTime tout_operate_date;

        public DateTime TOUT_OPERATE_DATE
        {
            get { return tout_operate_date; }
            set { tout_operate_date = value; }
        }
        private string tout_type;

        public string TOUT_TYPE
        {
            get { return tout_type; }
            set { tout_type = value; }
        }
    }
}
