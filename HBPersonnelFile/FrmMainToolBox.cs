using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace HBPersonnelFile
{
    public partial class FrmMainToolBox : DockContent
    {
        FrmMain Mfrm;

        public FrmMainToolBox()
        {
            InitializeComponent();
            BuildTreeMenu();//生成树形菜单
        }

        public FrmMainToolBox(FrmMain ParentForm)
            : this()
        {
            Mfrm = ParentForm;
        }

        private void BuildTreeMenu()
        {
            var sql="select * from Tcd菜单 order by TypeOrder,SOrder";
            var dt = RemoteServer.GetTable(sql);
           
                var lst =ToEntity(dt);
                TreeNode parent = null;
                foreach (var i in lst)
                {
                    if (i.FuncName == "")
                    {
                        TreeNode tmp = new TreeNode(i.NType);
                        tmp.Tag = i;

                        parent = tmp;
                        treeView.Nodes.Add(tmp);
                    }
                    else
                    {
                        TreeNode tmp = new TreeNode(i.FuncName);
                        tmp.Tag = i;

                        parent.Nodes.Add(tmp);
                    }
                }

                treeView.ExpandAll();
            
        }

        private List<Model.Tcd菜单> ToEntity(DataTable dt)
        {
            Model.Tcd菜单 e = new Model.Tcd菜单();
            return  e.ConvertToList(dt);

        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            Model.Tcd菜单 t = (Model.Tcd菜单)treeView.SelectedNode.Tag;
            if (t.FuncName != "")
            {
                Mfrm.OpenMdiChildrenForm2(t);
            }
        }
    }



}
