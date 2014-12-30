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
using ToolsHelper;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid;

namespace TicketSaleSystem.TicketOperate
{
    public partial class Frm_TicketOperate : DevExpress.XtraEditors.XtraUserControl
    {
        private FinanceStockInBLL financeStockInBLL = new FinanceStockInBLL();

        public Frm_TicketOperate()
        {
            InitializeComponent();
            BindTicketSupplyCombox();
            BindTicketItemCombox();
        }

        /// <summary>
        /// 绑定供票人下拉框
        /// </summary>
        private void BindTicketSupplyCombox()
        {
            string errorCode = "";
            try
            {
                DataTable gpry_dt = financeStockInBLL.BindTicketSupplyCombox(ref errorCode);
                if (!string.IsNullOrEmpty(errorCode))
                {
                    MessageBox.Show("错误代码：" + errorCode);
                }
                else
                {
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
            }
            catch (Exception ex)
            {
                // 记录日志
            }
        }

        /// <summary>
        /// 绑定门票项目下拉框
        /// </summary>
        private void BindTicketItemCombox()
        {
            string errorCode = "";
            try
            {
                DataTable dt = financeStockInBLL.BindTicketItemCombox(ref errorCode);
                if (!string.IsNullOrEmpty(errorCode))
                {
                    MessageBox.Show("错误代码：" + errorCode);
                }
                else
                {
                    if (dt != null && dt.Rows.Count > 0)
                    {
                        this.lookUpEdit1.EditValue = "ID";
                        this.lookUpEdit1.Properties.ValueMember = "ID";
                        this.lookUpEdit1.Properties.DisplayMember = "NAME";
                        this.lookUpEdit1.Properties.DataSource = dt;
                        this.lookUpEdit1.Properties.ShowHeader = false;
                        this.lookUpEdit1.EditValue = 2;
                    }
                }
            }
            catch (Exception ex)
            {
                // 记录日志
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            bool flag = false;
            string errorCode = "";
            if (this.lookUpEdit1.EditValue == null || this.lookUpEdit1.EditValue.ToString() == "nulltext")
            {
                //提示信息,说明未选择下拉框
                MessageBox.Show("带 * 为必填项！");
                return;
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
            flag = financeStockInBLL.SaveFinanceStockIn(financeStockInEntity, SystemInfo.UserID, ref errorCode);
            if (!flag)
                MessageBox.Show(errorCode);
            else
                MessageBox.Show("操作成功！");
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
            bool flag = false;
            string errorCode = "";
            // 退票（更新IS_DEL为1）
            if (this.lookUpEdit1.EditValue == null || this.lookUpEdit1.EditValue.ToString() == "nulltext")
            {
                //提示信息,说明未选择下拉框
                MessageBox.Show("带 * 为必填项！");
                return;
            }
            FinanceStockInEntity financeStockInEntity = new FinanceStockInEntity();
            financeStockInEntity.FIN_SUPPLY_ID = this.lookUpEdit2.EditValue.ToString();
            financeStockInEntity.FIN_TICKET_START = txtQSHM.Text;
            financeStockInEntity.FIN_TICKET_COUNT = Int32.Parse(txtZS.Text);
            financeStockInEntity.FIN_TICKET_END = txtZZHM.Text;
            financeStockInEntity.FIN_TICKET_ITEM_ID = this.lookUpEdit1.EditValue.ToString();
            financeStockInEntity.FIN_OPERATE_ID = SystemInfo.UserID;
            financeStockInEntity.FIN_OPERATE_DATE = DateTime.Now;
            financeStockInEntity.FIN_TYPE = "1";
            flag = financeStockInBLL.SaveFinanceStockInBack(financeStockInEntity, SystemInfo.UserID, ref errorCode);
            if (!flag)
                MessageBox.Show(errorCode);
            else
                MessageBox.Show("操作成功！");
        }

        private void txtQSHM_EditValueChanged(object sender, EventArgs e)
        {
            string strQSHM = txtQSHM.Text;
            string strZS = txtZS.Text;
            strQSHM = string.IsNullOrEmpty(strQSHM) ? "XX00000000" : strQSHM;
            strZS = string.IsNullOrEmpty(strZS) ? "0" : strZS;
            int qshm = 0;
            Int32.TryParse(strQSHM.Substring(2), out qshm);
            int zs = Int32.Parse(strZS);
            txtZZHM.Text = strQSHM.Substring(0, 2) + (qshm + zs - 1).ToString("00000000");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from TSS_FINANCIAL_IN";
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConStr, CommandType.Text, sqlStr);
                gridControl1.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void gridView1_CustomDrawEmptyForeground(object sender, CustomDrawEventArgs e)
        {
            ColumnView columnView = sender as ColumnView;
            BindingSource bindingSource = this.gridView1.DataSource as BindingSource;
            if (bindingSource.Count == 0)
            {
                string str = "没有查询到数据!";
                Font f = new Font("宋体", 10, FontStyle.Bold);
                Rectangle r = new Rectangle(e.Bounds.Top + 5, e.Bounds.Left + 5, e.Bounds.Right - 5, e.Bounds.Height - 5);
                e.Graphics.DrawString(str, f, Brushes.Black, r);
            }
        }
        
        //显示行的序号 
        private void gridView1_CustomDrawRowIndicator(object sender, RowIndicatorCustomDrawEventArgs e)
        {
             if (e.Info.IsRowIndicator && e.RowHandle>=0)
             {
                  e.Info.DisplayText = (e.RowHandle + 1).ToString();
             }
        }
    }
}
