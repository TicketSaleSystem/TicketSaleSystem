using DevExpress.XtraEditors;
using DevExpress.XtraTab;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Columns;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ToolsHelper
{
    public static class UIHelper
    {
        private static string TreeData = "{'rid':0,'name':'系统操作','childs':[{'rid':'M0100','name':'模块1','childs':[{'rid':'M0101','name':'模块1-1'},{'rid':'M0102','name':'模块1-2'}]},{'rid':'M0200','name':'模块2','childs':[{'rid':'M0201','name':'模块2-1'}]}]}";
        //        private string TreeData = string.Format(@"
        //                            { 
        //                                'rid' : 0, 'name' : '系统操作', 'childs' : [{
        //                                    'rid' : 'M0100', 'name' : '模块1', 'childs' : [{
        //                                        'rid' : 'M0101', 'name' : '模块1-1'
        //                                    },{
        //                                        'rid' : 'M0102', 'name' : '模块1-2'
        //                                    }]
        //                                },{
        //                                    'rid' : 'M0200', 'name' : '模块2', 'childs' : [{
        //                                        'rid' : 'M0201', 'name' : '模块2-1'
        //                                    }]
        //                                }]
        //                            }
        //        ");

        #region XtraTabPage控件
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
                //MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region XtraTreeList控件
        /// <summary>
        /// 动态创建TreeList Layer Node节点
        /// </summary>
        /// <param name="layerName"></param>
        /// <param name="check"></param>
        public static void creatMainLayerNode(TreeList treeListLayerControl, string layerName)
        {
            treeListLayerControl.BeginUnboundLoad();
            treeListLayerControl.AppendNode(new object[] { layerName }, -1);
            treeListLayerControl.EndUnboundLoad();
        }

        /// <summary>
        /// 动态创建TreeList 字段属性值 Node节点
        /// </summary>
        /// <param name="ValueName"></param>
        /// <param name="ID"></param>
        public static void CreatChildNode(TreeList treeListLayerControl, string ValueName, int ID)
        {
            treeListLayerControl.BeginUnboundLoad();
            treeListLayerControl.AppendNode(new object[] { ValueName }, ID);
            treeListLayerControl.EndUnboundLoad();
        }

        /// <summary>
        /// 获得图层名节点的Index值
        /// </summary>
        /// <param name="ParentNodeName"></param>
        /// <returns></returns>
        public static int getParentID(TreeList treeListLayerControl, string ParentNodeName)
        {
            int i = -1;
            for (i = 0; i < treeListLayerControl.Nodes.Count; i++)
            {
                if (treeListLayerControl.Nodes[i][0].ToString() == ParentNodeName)
                {
                    break;
                }
            }
            return i;
        }
        #endregion

    }
}
