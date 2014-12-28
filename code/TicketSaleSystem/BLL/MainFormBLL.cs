using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using TSS_DAL;

namespace TSS_BLL
{
    public class MainFormBLL
    {
        private MainFormDAL mainFormDAL = new MainFormDAL();

        public DataTable BindMainFormTreeList(string userID, ref string errorCode)
        {
            return mainFormDAL.BindMainFormTreeList(userID, ref errorCode);
        }
    }
}
