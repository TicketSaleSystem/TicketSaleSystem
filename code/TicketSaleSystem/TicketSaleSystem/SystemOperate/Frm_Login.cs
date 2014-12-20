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

        // 登录
        private void Login()
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
                {
                    MessageBox.Show("您好！" + ds.Tables[0].Rows[0]["USER_NAME"].ToString());
                    SetSystemInfo(ds.Tables[0]);
                    Frm_MainForm mainForm = new Frm_MainForm(this);
                    mainForm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("账号或密码错误！");
                }
            }
            catch (Exception ex)
            {
                // 错误处理，写入日志
            }
        }

        private void panelControl1_MouseClick(object sender, MouseEventArgs e)
        {
            Login();
        }

        /// <summary>
        /// 登陆成功后设置界面显示的用户信息
        /// </summary>
        /// <param name="dataTable"></param>
        private void SetSystemInfo(DataTable dataTable)
        {
            if (dataTable == null || dataTable.Rows.Count <= 0)
                return;
            SystemInfo.UserID = dataTable.Rows[0]["USER_ID"].ToString();
            SystemInfo.UserName = dataTable.Rows[0]["USER_NAME"].ToString();
        }

        // 添加键盘响应事件
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                Login();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        } 
    }
}