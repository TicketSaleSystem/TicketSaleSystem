using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using TicketSaleSystem.SystemOperate;

namespace TicketSaleSystem
{
    static class ToolsHelper
    {
        /// <summary>
        /// 添加到Tab控件里
        /// </summary>
        /// <param name="Xuser">要添加到的TabControl</param>
        /// <param name="Xuser">要添加的用户控件实例</param>
        /// <param name="name"> 控件唯一的 name 属性</param>
        /// <param name="caption">显示标题 caption</param>
        public static void AddUserControl(XtraTabControl Xtab, Object obj, string name, string caption)
        {
            try
            {
                foreach (XtraTabPage Xpage in Xtab.TabPages)
                {
                    if (Xpage.Name == name)
                    {
                        Xtab.SelectedTabPage = Xpage;  // 存在则显示该页
                        return;
                    }
                }
                XtraTabPage page = new XtraTabPage();
                page.Name = name;   //控件标示
                page.Text = caption;  //显示标题
                XtraUserControl Xuser = new XtraUserControl();
                Xuser.Dock = DockStyle.Fill;  //dock属性 全屏撑大
                XtraUserControl frm = (XtraUserControl)obj;
                //TicketSaleSystem.TicketOperate.TicketOperate frm = new TicketSaleSystem.TicketOperate.TicketOperate();
                frm.Show();
                page.Controls.Add(frm);
                Xtab.TabPages.Add(page);
                Xtab.SelectedTabPage = page;  // 切换显示到新增页
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
