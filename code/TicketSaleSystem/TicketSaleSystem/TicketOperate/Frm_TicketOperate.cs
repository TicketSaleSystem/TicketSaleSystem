using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using TSS_Model;
using TSS_Model.TicketOperate;
using TSS_BLL.TicketOperate;

namespace TicketSaleSystem.TicketOperate
{
    public partial class Frm_TicketOperate : DevExpress.XtraEditors.XtraUserControl
    {
        private FinanceStockInBLL financeStockInBLL = new FinanceStockInBLL();

        public Frm_TicketOperate()
        {
            InitializeComponent();
            BindCombox();
        }

        private void BindCombox()
        {
            try
            {
                // 绑定门票项目
                string sqlStr = @"SELECT
                                            ITEM_ID AS ID, 
                                            ITEM_NAME AS NAME 
                                        FROM TSS_TICKET_ITEM
                                        WHERE IS_DEL = '0'";
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConStr, CommandType.Text, sqlStr);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    this.lookUpEdit1.EditValue = "ID";
                    this.lookUpEdit1.Properties.ValueMember = "ID";
                    this.lookUpEdit1.Properties.DisplayMember = "NAME";
                    this.lookUpEdit1.Properties.DataSource = ds.Tables[0];
                    this.lookUpEdit1.Properties.ShowHeader = false;
                    this.lookUpEdit1.EditValue = 2;
                }
                // 绑定供票人员
                DataTable gpry_dt = new DataTable();
                gpry_dt.Columns.Add("ID", Type.GetType("System.String"));
                gpry_dt.Columns.Add("NAME", Type.GetType("System.String"));
                gpry_dt.Rows.Add(new object[] { "9997", "XX印刷厂" });

                if (gpry_dt.Rows.Count > 0)
                {
                    this.lookUpEdit2.EditValue = "ID";
                    this.lookUpEdit2.Properties.ValueMember = "ID";
                    this.lookUpEdit2.Properties.DisplayMember = "NAME";
                    this.lookUpEdit2.Properties.DataSource = gpry_dt;
                    this.lookUpEdit2.Properties.ShowHeader = false;
                    this.lookUpEdit2.EditValue = "9997";
                }
            }
            catch (Exception ex)
            {
                // 记录日志
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.lookUpEdit1.EditValue == null || this.lookUpEdit1.EditValue.ToString() == "nulltext")
            {
                //提示信息,说明未选择下拉框
                MessageBox.Show("带 * 为必填项！");
            }
            FinanceStockInEntity financeStockInEntity = new FinanceStockInEntity();
            financeStockInEntity.FIN_SUPPLY_ID = this.lookUpEdit2.EditValue.ToString();
            financeStockInEntity.FIN_TICKET_START = txtQSHM.Text;
            financeStockInEntity.FIN_TICKET_COUNT = Int32.Parse(txtZS.Text);
            financeStockInEntity.FIN_TICKET_END = txtZZHM.Text;
            financeStockInEntity.FIN_TICKET_ITEM_ID = this.lookUpEdit1.EditValue.ToString();
            financeStockInEntity.FIN_OPERATE_ID = SystemInfo.UserID;
            financeStockInEntity.FIN_OPERATE_DATE = DateTime.Now;
            financeStockInEntity.FIN_TYPE = "0";
            financeStockInBLL.Save(financeStockInEntity);
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            // 重置界面参数
            this.lookUpEdit2.EditValue = "9997";
            txtQSHM.Text = "JA00000001";
            txtZS.Text = "1000";
            txtZZHM.Text = "JA00001000";
            lookUpEdit1.EditValue = "2";
        }

        private void btnTP_Click(object sender, EventArgs e)
        {
            // 退票（更新IS_DEL为1）
        }

        private void txtQSHM_EditValueChanged(object sender, EventArgs e)
        {
            int qshm = 0;
            Int32.TryParse(txtQSHM.Text.Substring(2), out qshm);
            int zs = Int32.Parse(txtZS.Text);
            txtZZHM.Text = txtQSHM.Text.Substring(0, 2) + (qshm + zs - 1).ToString("00000000");
        }

    }
}
