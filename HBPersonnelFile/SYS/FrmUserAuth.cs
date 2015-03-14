using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Model;

namespace HBPersonnelFile.SYS
{
    public partial class FrmUserAuth : WeifenLuo.WinFormsUI.Docking.DockContent
    {
        public FrmUserAuth()
        {
            InitializeComponent();
        }
        Tyg员工 selectedUser;//当前选中的用户,分配权限就分配到该用户了.
        TUserAuth userAuth;//选中用户的菜单权限 
        private void FrmUserAuth_Load(object sender, EventArgs e)
        {
            string sql = "select * from Tcd菜单 order by TypeOrder,SOrder";
            var dt = RemoteServer.GetTable(sql);

            var lst = ToEntity(dt);
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
            return e.ConvertToList(dt);

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (cbUserName.Text.Length < 1) return;

            Tyg员工 i = new Tyg员工();
            var lst=i.FindEmployeeByName(cbUserName.Text);
            if(lst.Count!=1)
            {
                selectedUser = null;
                lblInfo.Text = "用户权限";
                MessageBox.Show("找不到员工:"+cbUserName.Text);
                return;
            }
            selectedUser = lst[0];
            TUserAuth ua = new TUserAuth();
            var uax = ua.GetEntityByUserID(selectedUser.ID);
            if (uax==null)
            {
                userAuth = ua;
                userAuth.ID = 0;
                userAuth.UserID = selectedUser.ID;
                userAuth.MenuIDs = "";
            }else
            {
                userAuth = uax;
            }

            lblInfo.Text = selectedUser.X姓名+"权限";
            FillUserTree(userAuth);
        }

        private void FillUserTree(TUserAuth userAuth)
        {
            treeViewUser.Nodes.Clear();
            if (userAuth.MenuIDs.Length < 1) return;

            var sql = string.Format("select * from Tcd菜单 WHERE ID in ({0}) order by TypeOrder,SOrder", userAuth.MenuIDs);
            var dt = RemoteServer.GetTable(sql);

            var lst = ToEntity(dt);
            TreeNode parent = null;
            foreach (var i in lst)
            {
                if (i.FuncName == "")
                {
                    TreeNode tmp = new TreeNode(i.NType);
                    tmp.Tag = i;

                    parent = tmp;
                    treeViewUser.Nodes.Add(tmp);
                }
                else
                {
                    TreeNode tmp = new TreeNode(i.FuncName);
                    tmp.Tag = i;

                    parent.Nodes.Add(tmp);
                }
            }

            treeViewUser.ExpandAll();
        }

        #region 右键选中树形控件
        private void treeView_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode tn = treeView.GetNodeAt(e.X, e.Y);
                if (tn != null) treeView.SelectedNode = tn;
            }
        }

        private void treeViewUser_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                TreeNode tn = treeViewUser.GetNodeAt(e.X, e.Y);
                if (tn != null) treeViewUser.SelectedNode = tn;
            }
        }

        #endregion

    
        private void menutjqx添加权限_Click(object sender, EventArgs e)
        {
            if(selectedUser==null)
            {
                MessageBox.Show("请选择用户");
                return;
            }
            var node = treeView.SelectedNode;
            List<int> ids = GetSubTree(node);

            var affect =userAuth.MergeAndSave(ids);
            if(affect>0)
            {
                FillUserTree(userAuth);
            }
            else
            {
                MessageBox.Show("添加权限失败.");
            }
        }

        private   List<int> GetSubTree(TreeNode node )
        {
          List<int> ids=new List<int>();
            //父节点
            var parent=node.Parent;
            while (parent != null)
            {
                Tcd菜单 cd=(Tcd菜单)parent.Tag;
                ids.Add(cd.ID);
                parent = parent.Parent;
            }
            //获取所有子节点
            GetSubNode(node,ids);

            return ids;
        }

        private void GetSubNode(TreeNode node, List<int> ids)//递归获取子节点
        {
            Tcd菜单 cd = (Tcd菜单)node.Tag;
            ids.Add(cd.ID);
            foreach (TreeNode node0 in node.Nodes)
            {
                GetSubNode(node0, ids);
            }
        }

        private void menuScqx删除权限_Click(object sender, EventArgs e)
        {
            if (selectedUser == null)
            {
                MessageBox.Show("请选择用户");
                return;
            }
            
            if (treeViewUser.SelectedNode==null) return;
            var node = treeViewUser.SelectedNode;
            List<int> ids = new List<int>();
            GetSubNode(node, ids);

            var affect = userAuth.DeleteAndSave(ids);
            if (affect > 0)
            {
                FillUserTree(userAuth);
            }
            else
            {
                MessageBox.Show("删除权限失败.");
            }
        }

    }
}
