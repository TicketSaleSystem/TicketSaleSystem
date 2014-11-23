using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;

namespace TicketSaleSystem.SystemOperate
{
    public partial class Frm_Login : DevExpress.XtraEditors.XtraForm
    {
        public Frm_Login()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            // 关闭
            this.Close();
        }

        private void panelControl1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                // 登录
                string sqlStr = "select * from TSS_USER where IS_DEL = '0' and USER_ID=@USER_ID and PASSWORD=@PASSWORD";
                SqlParameter[] sqlParams = new SqlParameter[]
                {
                    new SqlParameter("@USER_ID", SqlDbType.NVarChar),
                    new SqlParameter("@PASSWORD", SqlDbType.NVarChar)
                };
                sqlParams[0].Value = txtUserID.Text;
                sqlParams[1].Value = txtPWD.Text;
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConStr, CommandType.Text, sqlStr, sqlParams);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                    MessageBox.Show("您好！" + ds.Tables[0].Rows[0]["USER_NAME"].ToString());
                else
                    MessageBox.Show("账号或密码错误！");
            }
            catch (Exception ex)
            {
                // 错误处理，写入日志
            }
        }
    }
}