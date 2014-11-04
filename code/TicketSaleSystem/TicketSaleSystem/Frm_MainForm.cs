using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using DevExpress.UserSkins;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using DevExpress.XtraBars.Helpers;
using TicketSaleSystem.XTCZ;
using DevExpress.XtraTab;
using DevExpress.XtraEditors;


namespace TicketSaleSystem
{
    public partial class Frm_MainForm : RibbonForm
    {
        public Frm_MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
        }
        void InitSkinGallery()
        {
            SkinHelper.InitSkinGallery(rgbiSkins, true);
        }

        private void barButtonItem1_ItemClick(object sender, ItemClickEventArgs e)
        {
            Frm_Login frm_login = new Frm_Login();
            frm_login.ShowDialog();
        }

        private void barButtonItem2_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 注销
        }

        private void barButtonItem3_ItemClick(object sender, ItemClickEventArgs e)
        {
            // 退出
        }

        private void barButtonItem4_ItemClick(object sender, ItemClickEventArgs e)
        {
            TicketSaleSystem.TicketOperate.Frm_TicketOperate frm = new TicketSaleSystem.TicketOperate.Frm_TicketOperate();
            ToolsHelper.AddUserControl(xtraTabControl1, frm, "M0001", "财务出库");
        }

    }
}