using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using System.Data.SqlClient;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTab;
using ToolsHelper;

namespace TicketSaleSystem
{
    public partial class Frm_IndexForm : DevExpress.XtraEditors.XtraForm
    {
        public Frm_IndexForm()
        {
            InitializeComponent();
            BindData();
            //ToolsHelper.creatMainLayerNode(treeList1, "电子门票管理系统");

            //ToolsHelper.CreatChildNode(treeList1, "系统操作", 0);
            //ToolsHelper.CreatChildNode(treeList1, "门票操作", 0);
            //ToolsHelper.CreatChildNode(treeList1, "高级查询", 0);
            //ToolsHelper.CreatChildNode(treeList1, "管理", 0);
            //ToolsHelper.CreatChildNode(treeList1, "关于", 0);

            //// --------------------系统操作1--------------------------//
            //ToolsHelper.CreatChildNode(treeList1, "登录1", 1);
            //ToolsHelper.CreatChildNode(treeList1, "注销1", 1);
            //ToolsHelper.CreatChildNode(treeList1, "退出1", 1);
            //// --------------------门票操作2--------------------------//
            //ToolsHelper.CreatChildNode(treeList1, "登录2", 2);
            //ToolsHelper.CreatChildNode(treeList1, "注销2", 2);
            //ToolsHelper.CreatChildNode(treeList1, "退出2", 2);
            //// --------------------高级查询3--------------------------//
            //ToolsHelper.CreatChildNode(treeList1, "登录3", 3);
            //ToolsHelper.CreatChildNode(treeList1, "注销3", 3);
            //ToolsHelper.CreatChildNode(treeList1, "退出3", 3);
            //// --------------------管理4--------------------------//
            //ToolsHelper.CreatChildNode(treeList1, "登录4", 4);
            //ToolsHelper.CreatChildNode(treeList1, "注销4", 4);
            //ToolsHelper.CreatChildNode(treeList1, "退出4", 4);
            //// --------------------关于5--------------------------//
            //ToolsHelper.CreatChildNode(treeList1, "登录5", 5);
            //ToolsHelper.CreatChildNode(treeList1, "注销5", 5);
            //ToolsHelper.CreatChildNode(treeList1, "退出5", 5);
        }

        private void BindData()
        {
            this.Cursor = Cursors.WaitCursor; 
            try
            {
                // 获取树结构数据
                string sqlStr = string.Format(@"
                                                    SELECT
                	                                     CONVERT(INT,SUBSTRING(t.DICT_ID,2,4)) AS ID
                                                        ,t.DICT_NAME AS COLNAME
                                                        ,CONVERT(INT,SUBSTRING(t.DICT_PID,2,4)) AS PID
                                                    FROM
                	                                    TSS_DICTIONARY T
                                                    WHERE
                	                                    T.DICT_TYPE = 'Modules'
                                                    ORDER BY ID");
                DataSet ds = SqlHelper.ExecuteDataset(SqlHelper.ConStr, CommandType.Text, sqlStr);
                if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                {
                    DataTable dtMenu = ds.Tables[0];
                    treeList1.Nodes.Clear();
                    treeList1.DataSource = dtMenu;
                    treeList1.ParentFieldName = "PID";
                    treeList1.KeyFieldName = "ID";
                }
                treeList1.ExpandAll();
            }
            catch (Exception ex) 
            {
                // Error
            }
            this.Cursor = Cursors.Default;  
        }

        private void treeList1_Click(object sender, EventArgs e)
        {
            TreeListNode clickedNode = this.treeList1.FocusedNode;
            if (!clickedNode.HasChildren)
            {
                string disPlayText = clickedNode.GetDisplayText("COLNAME"); // 显示的汉字，目前无法取到绑定时的数字
                TicketSaleSystem.TicketOperate.Frm_TicketOperate frm = new TicketSaleSystem.TicketOperate.Frm_TicketOperate();
                UIHelper.AddUserControl(xtraTabControl1, frm, disPlayText, disPlayText);
            }
        }

        private void xtraTabControl1_CloseButtonClick(object sender, EventArgs e)
        {
            DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs EArg = (DevExpress.XtraTab.ViewInfo.ClosePageButtonEventArgs)e;
            string name = EArg.Page.Text; // 得到关闭的选项卡的text
            foreach (XtraTabPage page in xtraTabControl1.TabPages) // 遍历得到和关闭的选项卡一样的Text
            {
                if (page.Text == name)
                {
                    xtraTabControl1.TabPages.Remove(page);
                    page.Dispose();
                    return;
                }
            }
        }
    }
}