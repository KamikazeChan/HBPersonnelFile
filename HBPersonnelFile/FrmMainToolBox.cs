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
        Form Mfrm;

        public FrmMainToolBox()
        {
            InitializeComponent();
          //  BuildTreeMenu();//生成树形菜单
        }

        public FrmMainToolBox(Form ParentForm): this()
        {
            Mfrm = ParentForm;
        }

        private void BuildTreeMenu()
        {
            var sql="select * from Tcd菜单 order by TypeOrder,SOrder";
            var dt = HBServer.GetTable(sql);
           
                var lst =ToEntity(dt);
                TreeNode parent = null;
                //foreach (var i in lst)
                //{
                //    if (i.FuncName == "")
                //    {
                //        TreeNode tmp = new TreeNode(i.NType);
                //        tmp.Tag = i;

                //        parent = tmp;
                //        treeView.Nodes.Add(tmp);
                //    }
                //    else
                //    {
                //        TreeNode tmp = new TreeNode(i.FuncName);
                //        tmp.Tag = i;

                //        parent.Nodes.Add(tmp);
                //    }
                //}

                treeView.ExpandAll();
            
        }

        private object ToEntity(DataTable dt)
        {
            throw new NotImplementedException();
        }

        private void treeView_DoubleClick(object sender, EventArgs e)
        {
            //DAL.Tcd菜单 t = (DAL.Tcd菜单)treeView.SelectedNode.Tag;
            //if (t.FuncName != "")
            //{
            //    _ParentForm.OpenMdiChildrenForm2(t);
            //}
        }
    }
}
