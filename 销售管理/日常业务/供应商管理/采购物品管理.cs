using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;
using System.Linq;
using System.Data.Entity;
using 销售管理.系统设置;
using Common;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 采购物品管理 : 销售管理.UserControlBase
    {
        public 采购物品管理()
        {
            InitializeComponent();
        }

        private MYDBEntities2 myEntity = new MYDBEntities2();
        //DaGoodsType mDaGoodsType;

        private void 采购物品管理_Load(object sender, EventArgs e)
        {
            AddTree();
            BindingData();

            if (!Common.AuthenticateRight.AuthOperation(120202) && !CommonClass.SttUser.blSuperUser)
            {
                llAddGoods.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120203) && !CommonClass.SttUser.blSuperUser)
            {
                dg删除.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120204) && !CommonClass.SttUser.blSuperUser)
            {
                llAdd.Visible = false;
                llSelectSupplier.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120205) && !CommonClass.SttUser.blSuperUser)
            {
                修改.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120206) && !CommonClass.SttUser.blSuperUser)
            {
                llAddContact.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120207) && !CommonClass.SttUser.blSuperUser)
            {
                dsc删除.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120208) && !CommonClass.SttUser.blSuperUser)
            {
                dsc修改.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120209) && !CommonClass.SttUser.blSuperUser)
            {
                dg修改.Visible = false;
            }
        }

        private void AddTree()
        {
            tvDaGoodsType.Nodes.Clear();
            List<DaGoodsType> mDaGoodsTypes = myEntity.DaGoodsTypes.OrderBy(d => d.IntID).ToList();
            foreach (var mDGT in mDaGoodsTypes)
            {
                if (mDGT.VcType != "采购物品分类")
                {
                    var mParentNode = tvDaGoodsType.Nodes.Find("tvGoodsType" + mDGT.IntParentID.ToString(), true);
                    if (mParentNode.Length > 0)
                    {
                        mParentNode[0].Nodes.Add("tvGoodsType" + mDGT.IntID.ToString(), mDGT.VcType);
                    }
                }
                else
                {
                    tvDaGoodsType.Nodes.Add("tvGoodsType" + mDGT.IntID.ToString(), mDGT.VcType);
                }
            }
            tvDaGoodsType.ExpandAll();
        }

        private void BindingData()
        {
            dgvDaGoods.DataSource = DaGoodsBindingSource;
        }

        private void tvDaGoodsType_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show( e.Node.Name);
            InitDaGoods();
        }

        private void InitDaGoods()
        {
            //获取分类Id
            int DaGoodTypeID = Convert.ToInt32(tvDaGoodsType.SelectedNode.Name.Replace("tvGoodsType", ""));

            //获取该分类下的物品
            //判断是否有查看所有人物品权限



            DaGoodsType mDaGoodsType = myEntity.DaGoodsTypes.Where(d => d.IntID == DaGoodTypeID).AsNoTracking().SingleOrDefault();
            if (!Common.AuthenticateRight.AuthOperation(120210) && !CommonClass.SttUser.blSuperUser)
            {
                //不能查看所有人物品
                DaGoodsBindingSource.DataSource = mDaGoodsType.DaGoods.Where(a => a.IntEmpNum == Classes.PubClass.UserId).ToList();
            }
            else
            {
                DaGoodsBindingSource.DataSource = mDaGoodsType.DaGoods.ToList();
            }


        }

        private void InitDaSupplierContact()
        {
            if (dgvDaSupplier.SelectedRows.Count < 1)
                return;
            var rowIndex = dgvDaSupplier.SelectedRows[0].Index;
            DaSupplier mDaSupplier = (DaSupplier)DaSupplierBindingSource[rowIndex];
            DaSuppContactBindingSource.DataSource = myEntity.DaSupplierContacts.Where(d => d.IntSupplierID == mDaSupplier.IntID).AsNoTracking().ToList();// mDaSupplier.DaSupplierContacts.ToList();
        }

        private void InitDaGoodsSupplier()
        {
            if (dgvDaGoods.SelectedRows.Count < 1)
                return;
            var rowIndex = dgvDaGoods.SelectedRows[0].Index;
            DaGoods mDaGoods = (DaGoods)DaGoodsBindingSource[rowIndex];

            DaSupplierBindingSource.DataSource = myEntity.DaGoodsSuppliers.Where(d => d.IntGoodsID == mDaGoods.IntID).Select(d => d.DaSupplier).AsNoTracking().ToList();// mDaGoods.DaGoodsSuppliers.Select(d => d.DaSupplier).ToList();
        }



        private void dgvDaGoods_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDaGoods.SelectedRows.Count < 1)
            {
                DaSupplierBindingSource.DataSource = null;
                return;
            }
            InitDaGoodsSupplier();
        }

        private void dgvDaSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDaSupplier.SelectedRows.Count < 1)
            {
                DaSuppContactBindingSource.DataSource = null;
                return;
            }
            InitDaSupplierContact();
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvDaGoods.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择采购物品");
                return;
            }
            using (供应商编辑 mForm = new 供应商编辑())
            {
                mForm.DaGoodsID = ((DaGoods)DaGoodsBindingSource[dgvDaGoods.SelectedRows[0].Index]).IntID;
                //mForm.myEntity = myEntity;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    //增加成功,刷新列表
                    //((System.Data.Entity.Infrastructure.IObjectContextAdapter)myEntity).ObjectContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, myEntity.DaSuppliers);
                    //((System.Data.Entity.Infrastructure.IObjectContextAdapter)myEntity).ObjectContext.AcceptAllChanges();
                    InitDaGoodsSupplier();
                    //dgvDaGoods_SelectionChanged(sender, e);
                }

            }
        }

        private void llAddContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DaSupplierBindingSource.Current == null)
            {
                MessageBox.Show("请选择供应商");
                return;
            }
            using (供应商联系人编辑 mForm = new 供应商联系人编辑())
            {
                mForm.DaSupplierID = ((DaSupplier)DaSupplierBindingSource.Current).IntID;
                //mForm.myEntity = myEntity;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    //((System.Data.Entity.Infrastructure.IObjectContextAdapter)myEntity).ObjectContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, myEntity.DaSupplierContacts);
                    //((System.Data.Entity.Infrastructure.IObjectContextAdapter)myEntity).ObjectContext.AcceptAllChanges();
                    InitDaSupplierContact();
                }

            }
        }

        private void llAddGoods_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (tvDaGoodsType.SelectedNode == null)
                return;
            if (tvDaGoodsType.SelectedNode.Name.Replace("tvGoodsType", "") == "1")
                return;
            using (采购物品编辑 mForm = new 采购物品编辑())
            {
                //mForm.myEntity = myEntity;
                mForm.mDaGoodsTypeID = Convert.ToInt32(tvDaGoodsType.SelectedNode.Name.Replace("tvGoodsType", ""));
                //mForm.mDaGoodsTypeName = tvDaGoodsType.SelectedNode.Text;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    //((System.Data.Entity.Infrastructure.IObjectContextAdapter)myEntity).ObjectContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, myEntity.DaGoods1);
                    //((System.Data.Entity.Infrastructure.IObjectContextAdapter)myEntity).ObjectContext.AcceptAllChanges();

                    InitDaGoods();
                }

            }
        }

        private void llSelectSupplier_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (dgvDaGoods.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择采购物品");
                return;
            }
            using (选择供应商 mForm = new 选择供应商())
            {
                mForm.MultiSelect = true;
                mForm.mDaGoodsID = ((DaGoods)DaGoodsBindingSource[dgvDaGoods.SelectedRows[0].Index]).IntID;
                //mForm.myEntity = myEntity;// = ((DaSupplier)DaSupplierBindingSource.Current).IntID;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    //((System.Data.Entity.Infrastructure.IObjectContextAdapter)myEntity).ObjectContext.Refresh(System.Data.Objects.RefreshMode.StoreWins, myEntity.DaSupplierContacts);
                    //((System.Data.Entity.Infrastructure.IObjectContextAdapter)myEntity).ObjectContext.AcceptAllChanges();
                    try
                    {
                        foreach (int suppilerId in mForm.mDaSupplierID)
                        {
                            DaGoodsSupplier mDaGoodsSupplier = new DaGoodsSupplier { IntGoodsID = mForm.mDaGoodsID, IntSuppilerID = suppilerId };
                            myEntity.DaGoodsSuppliers.Add(mDaGoodsSupplier);
                        }


                        int ret = myEntity.SaveChanges();

                        if (ret > 0)
                        {
                            MessageBox.Show("添加成功");

                        }
                        else
                        {
                            MessageBox.Show("添加失败");
                            return;
                        }

                        InitDaGoodsSupplier();
                    }
                    catch (System.Data.Entity.Validation.DbEntityValidationException ex)
                    {
                        foreach (var item in ex.EntityValidationErrors)
                        {
                            foreach (var item2 in item.ValidationErrors)
                            {
                                //MessageBox.Show(string.Format("{0}:{1}\r\n", item2.PropertyName, item2.ErrorMessage));
                                MessageBox.Show(string.Format("{0}\r\n", item2.ErrorMessage));
                            }
                        }
                    }

                }

            }
        }

        private void dgvDaGoods_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.RowIndex < DaGoodsBindingSource.Count)
            {
                var daGoods = (DaGoods)DaGoodsBindingSource[e.RowIndex];
                var grid = dgvDaGoods;
                if (daGoods != null)
                {
                    grid.Rows[e.RowIndex].Cells[dg单位.Index].Value = daGoods.ZdGoodsUnit.VcDesc;
                    grid.Rows[e.RowIndex].Cells[dg录入人.Index].Value = daGoods.T_Users.UserName;
                    grid.Rows[e.RowIndex].Cells[dg所属类目.Index].Value = daGoods.DaGoodsType.VcType;
                }
            }
        }

        private void dgvDaSupplier_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < DaSupplierBindingSource.Count)
            {
                var daSupplier = (DaSupplier)DaSupplierBindingSource[e.RowIndex];

                var grid = dgvDaSupplier;
                if (daSupplier != null)
                {
                    grid.Rows[e.RowIndex].Cells[录入人.Index].Value = daSupplier.T_Users.UserName;
                }


            }
        }

        private void dgvDaSuppContact_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.RowIndex < DaSuppContactBindingSource.Count)
            {
                var daSuppContact = (DaSupplierContact)DaSuppContactBindingSource[e.RowIndex];
                var grid = dgvDaSuppContact;
                if (daSuppContact != null)
                {
                    grid.Rows[e.RowIndex].Cells[录入人dsc.Index].Value = daSuppContact.T_Users.UserName;
                }


            }
        }

        private void 添加toolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (添加下级产品 mForm = new 添加下级产品())
            {
                mForm.Text = "采购物品分类名称";
                mForm.txtProductName.Text = tvDaGoodsType.SelectedNode.Text;
                if (DialogResult.Yes == mForm.ShowDialog())
                {
                    string newName = mForm.txtProductName.Text.Trim();

                    DaGoodsType mDaGoodsType = new DaGoodsType() { IntParentID = Convert.ToInt32(tvDaGoodsType.SelectedNode.Name.Replace("tvGoodsType", "")), VcType = newName, IntEmpNum = Classes.PubClass.UserId };


                    myEntity.DaGoodsTypes.Add(mDaGoodsType);

                    int ret = myEntity.SaveChanges();
                    if (ret > 0)
                    {
                        MessageBox.Show("增加成功");
                        AddTree();
                    }
                    else
                    {
                        MessageBox.Show("增加失败");
                    }
                }
            }
        }

        private void 修改名称ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (添加下级产品 mForm = new 添加下级产品())
            {
                mForm.Text = "修改采购物品分类名称";
                mForm.txtProductName.Text = tvDaGoodsType.SelectedNode.Text;
                if (DialogResult.Yes == mForm.ShowDialog())
                {
                    string newName = mForm.txtProductName.Text.Trim();

                    myEntity.DaGoodsTypes.Where(d => d.IntID == Convert.ToInt32(tvDaGoodsType.SelectedNode.Name.Replace("tvGoodsType", ""))).SingleOrDefault().VcType = newName;

                    int ret = myEntity.SaveChanges();
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

        private void 删除toolStripMenuItem_Click(object sender, EventArgs e)
        {
            //查看是否有下级
            int mDaGoodsTypeID = Convert.ToInt32(tvDaGoodsType.SelectedNode.Name.Replace("tvGoodsType", ""));
            DaGoodsType mDaGoodType = myEntity.DaGoodsTypes.Where(d => d.IntID == mDaGoodsTypeID).SingleOrDefault();
            if (mDaGoodType.DaGoodsType1.Count > 0)
            {
                MessageBox.Show("请先删除子采购物品分类");
                return;
            }
            if (mDaGoodType.DaGoods.Count > 0)
            {
                MessageBox.Show("该采购物品分类下有采购物品,请先删除采购物品");
                return;
            }
            if (MessageBox.Show("是否确认删除" + tvDaGoodsType.SelectedNode.Text, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                return;
            myEntity.DaGoodsTypes.Remove(mDaGoodType);

            int ret = myEntity.SaveChanges();

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

        private void dgvDaGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dg删除.Index)
            {
                //删除
                int daGoodsId = ((DaGoods)DaGoodsBindingSource[e.RowIndex]).IntID;
                DaGoods mDaGoods = myEntity.DaGoods1.SingleOrDefault(a=>a.IntID==daGoodsId);
                if (mDaGoods.DaContractGoods.Count > 0)
                {
                    MessageBox.Show("该物品已有采购订单,不能删除");
                    return;
                }
                if (MessageBox.Show("是否确认删除" + mDaGoods.VcName, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                    return;
                //myEntity.DaGoods1.Attach(mDaGoods);
                mDaGoods.DaGoodsSuppliers.Clear();

                myEntity.DaGoods1.Remove(mDaGoods);

                int ret = myEntity.SaveChanges();

                if (ret > 0)
                {
                    InitDaGoods();
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            if (e.ColumnIndex == dg修改.Index)
            {
                //修改
                using (采购物品编辑 mForm = new 采购物品编辑())
                {
                    mForm.mDaGoodsID = ((DaGoods)DaGoodsBindingSource[e.RowIndex]).IntID;

                    if (mForm.ShowDialog() == DialogResult.OK)
                    {
                        InitDaGoods();
                    }
                }
            }
        }

        private void dgvDaSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dsc删除.Index)
            {
                //删除
                int daSupplierId = ((DaSupplier)DaSupplierBindingSource[e.RowIndex]).IntID;
                DaSupplier mDaSupplier = myEntity.DaSuppliers.SingleOrDefault(a=>a.IntID==daSupplierId);
                if (mDaSupplier.DaPurchaseContracts.Count > 0)
                {
                    MessageBox.Show("该物品已有采购订单,不能删除");
                    return;
                }
                if (MessageBox.Show("是否确认删除" + mDaSupplier.VcName, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                    return;
                //myEntity.DaSuppliers.Attach(mDaSupplier);
                mDaSupplier.DaGoodsSuppliers.Clear();
                myEntity.DaSuppliers.Remove(mDaSupplier);

                int ret = myEntity.SaveChanges();

                if (ret > 0)
                {
                    InitDaGoodsSupplier();
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            if (e.ColumnIndex == dsc修改.Index)
            {
                //修改
                using (供应商编辑 mForm = new 供应商编辑())
                {
                    mForm.DaSupplierID = ((DaSupplier)DaSupplierBindingSource[e.RowIndex]).IntID;

                    if (mForm.ShowDialog() == DialogResult.OK)
                    {
                        InitDaGoodsSupplier();
                    }
                }
            }
        }

        private void dgvDaSuppContact_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == dsc删除.Index)
            {
                //删除
                DaSupplierContact mDaSupplierContact = (DaSupplierContact)DaSuppContactBindingSource[e.RowIndex];

                if (MessageBox.Show("是否确认删除" + mDaSupplierContact.VcName, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                    return;
                myEntity.DaSupplierContacts.Remove(mDaSupplierContact);

                int ret = myEntity.SaveChanges();

                if (ret > 0)
                {
                    InitDaSupplierContact();
                    MessageBox.Show("删除成功");
                }
                else
                {
                    MessageBox.Show("删除失败");
                }
            }
            if (e.ColumnIndex == dsc修改.Index)
            {
                //修改
                using (供应商联系人编辑 mForm = new 供应商联系人编辑())
                {
                    mForm.DaContactID = ((DaSupplierContact)DaSuppContactBindingSource[e.RowIndex]).IntID;

                    if (mForm.ShowDialog() == DialogResult.OK)
                    {
                        InitDaSupplierContact();
                    }
                }
            }
        }

        private void tvDaGoodsType_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                if (!Common.AuthenticateRight.AuthOperation(120201) && !CommonClass.SttUser.blSuperUser)
                {
                    return;
                }
                TreeNode CurrentNode = tvDaGoodsType.GetNodeAt(e.Location);
                tvDaGoodsType.SelectedNode = CurrentNode;
                if (CurrentNode.Name == "tvGoodsType1")
                {
                    删除toolStripMenuItem.Enabled = false;
                    修改名称ToolStripMenuItem.Enabled = false;
                }
                else
                {
                    删除toolStripMenuItem.Enabled = true;
                    修改名称ToolStripMenuItem.Enabled = true;
                }
                nodes.Show(tvDaGoodsType, e.Location);

            }
        }

    }
}
