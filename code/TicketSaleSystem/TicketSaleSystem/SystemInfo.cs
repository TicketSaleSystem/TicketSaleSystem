using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TicketSaleSystem
{
    public static class SystemInfo
    {
        private static string userID = "未登录";
        public static string UserID
        {
            get { return SystemInfo.userID; }
            set { SystemInfo.userID = value; }
        }
        private static string userName = "未登录";

        public static string UserName
        {
            get { return SystemInfo.userName; }
            set { SystemInfo.userName = value; }
        }

        private static readonly string sysID = "Version 1.0";
        public static string SysID
        {
            get { return SystemInfo.sysID; }
        }
    }
}
