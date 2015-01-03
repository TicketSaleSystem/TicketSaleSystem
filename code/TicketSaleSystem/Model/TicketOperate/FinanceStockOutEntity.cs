using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TSS_Model.TicketOperate
{
    public class FinanceStockOutEntity
    {
        private string fout_leadback_id;

        public string FOUT_LEADBACK_ID
        {
            get { return fout_leadback_id; }
            set { fout_leadback_id = value; }
        }
        private string fout_ticket_start;

        public string FOUT_TICKET_START
        {
            get { return fout_ticket_start; }
            set { fout_ticket_start = value; }
        }
        private int fout_ticket_count;

        public int FOUT_TICKET_COUNT
        {
            get { return fout_ticket_count; }
            set { fout_ticket_count = value; }
        }
        private string fout_ticket_end;

        public string FOUT_TICKET_END
        {
            get { return fout_ticket_end; }
            set { fout_ticket_end = value; }
        }
        private string fout_operate_id;

        public string FOUT_OPERATE_ID
        {
            get { return fout_operate_id; }
            set { fout_operate_id = value; }
        }
        private DateTime fout_operate_date;

        public DateTime FOUT_OPERATE_DATE
        {
            get { return fout_operate_date; }
            set { fout_operate_date = value; }
        }
        private string fout_type;

        public string FOUT_TYPE
        {
            get { return fout_type; }
            set { fout_type = value; }
        }
    }
}
