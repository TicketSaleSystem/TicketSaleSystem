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


namespace TicketSaleSystem
{
    public partial class Frm_MainForm : RibbonForm
    {
        public Frm_MainForm()
        {
            InitializeComponent();
            InitSkinGallery();
            schedulerControl.Start = System.DateTime.Now;
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

    }
}