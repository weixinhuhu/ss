using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetProductsTableAdapters;

namespace 销售管理.系统设置
{
    public partial class 产品管理 : 销售管理.UserControlBase
    {
        public 产品管理()
        {
            InitializeComponent();
        }

        private void 产品管理_Load(object sender, EventArgs e)
        {
            AddTree();
        }
        private void AddTree()
        {
            treeView1.Nodes[0].Nodes.Clear();
            var mTable = new T_ProductsTableAdapter().GetData();
            if (mTable.Rows.Count > 0)
            {
                foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
                {
                    if (mRow.Level == 1)
                    {
                        treeView1.Nodes[0].Nodes.Add(mRow.Id.ToString(), mRow.Name).ForeColor = Color.Red;
                    }
                    else
                    {
                        TreeNode[] mNode = treeView1.Nodes.Find(mRow.ParentId.ToString(), true);
                        if (mNode.Length > 0)
                        {
                            if (mRow.Level == 2)
                            {
                                mNode[0].Nodes.Add(mRow.Id.ToString(), mRow.Name).ForeColor = Color.Blue;
                            }
                            else
                            {
                                mNode[0].Nodes.Add(mRow.Id.ToString(), mRow.Name);
                            }
                        }
                    }

                }
            }
            //treeView1.ExpandAll();
            treeView1.Nodes[0].Expand();
            foreach (TreeNode mNode in treeView1.Nodes[0].Nodes)
            {
                mNode.Expand();
            }

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("添加下级");
            using (添加下级产品 mForm = new 添加下级产品())
            {
                if (DialogResult.Yes == mForm.ShowDialog())
                {
                    int ret = new T_ProductsTableAdapter().Insert(mForm.txtProductName.Text.Trim(), treeView1.SelectedNode.Level + 1, Convert.ToInt64(treeView1.SelectedNode.Name));
                    if (ret > 0)
                    {
                        MessageBox.Show("加入成功");
                        AddTree();
                    }
                    else
                    {
                        MessageBox.Show("加入失败");
                    }
                }
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("删除本级"+ treeView1.SelectedNode.Name);
            if (DialogResult.Yes == MessageBox.Show("确认是否删除", "警告", MessageBoxButtons.YesNo))
            {
                int ret = new T_ProductsTableAdapter().DeleteById(Convert.ToInt64(treeView1.SelectedNode.Name));
                if (ret > 0)
                {
                    MessageBox.Show("删除成功");
                    AddTree();
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
        }

        private void 修改名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (添加下级产品 mForm = new 添加下级产品())
            {
                mForm.Text = "修改产品名称";
                mForm.txtProductName.Text = treeView1.SelectedNode.Text;
                if (DialogResult.Yes == mForm.ShowDialog())
                {
                    int ret = new T_ProductsTableAdapter().UpdateNameById(mForm.txtProductName.Text.Trim(), Convert.ToInt64(treeView1.SelectedNode.Name));
                    if (ret > 0)
                    {
                        MessageBox.Show("修改成功");
                        AddTree();
                    }
                    else
                    {
                        MessageBox.Show("修改失败");
                    }
                }
            }
        }

        private void treeView1_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {

            if (e.Button == MouseButtons.Right)
            {
                TreeNode CurrentNode = treeView1.GetNodeAt(e.Location);
                treeView1.SelectedNode = CurrentNode;
                nodes.Items[1].Enabled = true;  //删除
                nodes.Items[2].Enabled = true;  //修改
                if (CurrentNode.Level == 3) nodes.Items[0].Enabled = false; //第3级不能加下级
                else nodes.Items[0].Enabled = true;
                if (CurrentNode.Level < 3)
                {
                    if (!Common.AuthenticateRight.AuthOperation(100201))
                    {
                        if (CurrentNode.Level == 2)
                        {
                            nodes.Items[1].Enabled = false;
                            nodes.Items[2].Enabled = false;
                        }
                        else
                        {
                            return;
                        }
                    }
                }



                nodes.Show(treeView1, e.Location);
            }

        }
    }
}
