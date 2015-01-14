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
    /// <summary>
    /// 财务入库、退票操作
    /// </summary>
    public partial class Frm_Sale : DevExpress.XtraEditors.XtraUserControl
    {
        private FinanceStockInBLL financeStockInBLL = new FinanceStockInBLL();
        private SaleBLL saleBLL = new SaleBLL();

        public Frm_Sale()
        {
            InitializeComponent();
            BindTicketItemCombox();
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
                        this.lue_mplx.EditValue = "ID";
                        this.lue_mplx.Properties.ValueMember = "ID";
                        this.lue_mplx.Properties.DisplayMember = "NAME";
                        this.lue_mplx.Properties.DataSource = dt;
                        this.lue_mplx.Properties.ShowHeader = false;
                        this.lue_mplx.EditValue = 1;
                    }
                }
            }
            catch (Exception ex)
            {
                // 记录日志
            }
        }
        
        private void txtQSHM_EditValueChanged(object sender, EventArgs e)
        {
            //string strQSHM = txtQSHM.Text;
            //string strZS = txtZS.Text;
            //strQSHM = string.IsNullOrEmpty(strQSHM) ? "XX00000000" : strQSHM;
            //strZS = string.IsNullOrEmpty(strZS) ? "0" : strZS;
            //int qshm = 0;
            //Int32.TryParse(strQSHM.Substring(2), out qshm);
            //int zs = Int32.Parse(strZS);
            //txtZZHM.Text = strQSHM.Substring(0, 2) + (qshm + zs - 1).ToString("00000000");
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

        #region 将已填写的票信息添加到列表中
        private void btn_Add_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 重置当前填写的票据信息
        private void btn_ReWrite_Click(object sender, EventArgs e)
        {
            // 重置界面参数
            //this.lue_kyd.EditValue = "9997";
            //txtQSHM.Text = "JA00000001";
            //txtZS.Text = "1000";
            //txtZZHM.Text = "JA00001000";
            //lue_mplx.EditValue = "2";
        }
        #endregion

        #region 保存列表中的售票信息
        private void btn_Sale_Click(object sender, EventArgs e)
        {
            //bool flag = false;
            //string errorCode = "";
            //if (this.lue_mplx.EditValue == null || this.lue_mplx.EditValue.ToString() == "nulltext")
            //{
            //    //提示信息,说明未选择下拉框
            //    MessageBox.Show("带 * 为必填项！");
            //    return;
            //}
            //FinanceStockInEntity financeStockInEntity = new FinanceStockInEntity();
            //financeStockInEntity.FIN_SUPPLY_ID = this.lue_kyd.EditValue.ToString();
            //financeStockInEntity.FIN_TICKET_START = txtQSHM.Text;
            //financeStockInEntity.FIN_TICKET_COUNT = Int32.Parse(txtZS.Text);
            //financeStockInEntity.FIN_TICKET_END = txtZZHM.Text;
            //financeStockInEntity.FIN_TICKET_ITEM_ID = this.lue_mplx.EditValue.ToString();
            //financeStockInEntity.FIN_OPERATE_ID = SystemInfo.UserID;
            //financeStockInEntity.FIN_OPERATE_DATE = DateTime.Now;
            //financeStockInEntity.FIN_TYPE = "0";
            //flag = financeStockInBLL.SaveFinanceStockIn(financeStockInEntity, SystemInfo.UserID, ref errorCode);
            //if (!flag)
            //    MessageBox.Show(errorCode);
            //else
            //    MessageBox.Show("操作成功！");
        }
        #endregion

        #region 清空全部信息
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            // 重置界面参数
            //this.lue_kyd.EditValue = "9997";
            //txtQSHM.Text = "JA00000001";
            //txtZS.Text = "1000";
            //txtZZHM.Text = "JA00001000";
            //lue_mplx.EditValue = "2";
        }
        #endregion

        #region 状态查询
        private void btn_SearchStatus_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 预售按钮事件
        private void btn_PreSale_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region 查询交易历史
        private void btn_SearchHistory_Click(object sender, EventArgs e)
        {
            try
            {
                string sqlStr = "select * from TSS_FINANCIAL_IN";
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConStr, CommandType.Text, sqlStr);
                gc_TradeList.DataSource = ds.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        private void txt_zs_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                string strMPTM = txt_mptm.Text;
                if(strMPTM.Length != 10)
                    return;
                GetLastMPTM(strMPTM);
                int start = -1;
                int end = -1;
                Int32.TryParse(strMPTM.Substring(2), out start);
                if(start == -1)
                    return;

                end = Int32.Parse(strMPTM.Substring(2)) + start;
                l_qstm.Text = strMPTM.Substring(0, 2) + end.ToString("00000000");
            }
            catch (Exception ex)
            {
                // 
            }
        }

        #region 根据填写的门票条码查询出最新一条该类型已出售的条码号
        /// <summary>
        /// 根据填写的门票条码吃查询出最新一条该类型已出售的条码号
        /// </summary>
        /// <param name="strMPTM">门票条码号</param>
        private void GetLastMPTM(string strMPTM)
        {
            bool flag = false;
            string errorCode = "";
            string strLastMPTM = saleBLL.GetLastMPTM(strMPTM, ref errorCode);
            if (string.IsNullOrEmpty(strLastMPTM))
            {
                MessageBox.Show("没有门票条码信息！");
            }
            else
            {
                //--------------------------------比对查询出的条码与填写的条码，更换背景色
            }
        }
        #endregion
    }
}
