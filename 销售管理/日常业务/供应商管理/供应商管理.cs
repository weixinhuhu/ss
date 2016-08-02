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
using Common;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 供应商管理 : 销售管理.UserControlBase
    {
        public 供应商管理()
        {
            InitializeComponent();
        }

        private MYDBEntities2 myEntity = new MYDBEntities2();

        private void llAdd_Clicked(object sender,EventArgs e)
        {
            using(供应商编辑 mForm  = new 供应商编辑())
            {
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    InitDaGoodsSupplier();
                }
            }
        }

        private void 供应商管理_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
           // DaSupplierBindingSource.DataSource = myEntity.DaSuppliers.Include("T_Users").Where(a => a.IntStatus == 0).ToList();
            //DaSupplierBindingSource.DataSource = myEntity.DaSuppliers.AsNoTracking().ToList();
            InitDaGoodsSupplier();
            dgvDaSupplier.DataSource = DaSupplierBindingSource;

            
            //DaSuppContactBindingSource.DataSource = DaSupplierBindingSource;
            //DaSuppContactBindingSource.DataMember = "DaSupplierContacts";
            dgvDaSuppContact.DataSource = DaSuppContactBindingSource;
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

        private void dgvDaSupplier_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDaSupplier.SelectedRows.Count < 1)
            {
                DaSuppContactBindingSource.DataSource = null;
                return;
            }
            InitDaSupplierContact();
            //var rowIndex = dgvDaSupplier.SelectedRows[0].Index;
            //var daSupplier = (DaSupplier)DaSupplierBindingSource[rowIndex];
            ////dgvDaSuppContact.DataSource = daSupplier.DaSupplierContacts.ToList();
            //DaSuppContactBindingSource.DataSource =  daSupplier.DaSupplierContacts.ToList();
        }

        private void llAddContact_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (DaSupplierBindingSource.Current == null)
            {
                MessageBox.Show("请选择供应商");
                return;
            }
            using(供应商联系人编辑 mForm = new  供应商联系人编辑())
            {
                mForm.DaSupplierID = ((DaSupplier)DaSupplierBindingSource.Current).IntID;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    InitDaSupplierContact();
                }
            }
        }

        private void InitDaGoodsSupplier()
        {
            IQueryable<DaSupplier> mDaSuppliers = myEntity.DaSuppliers.AsNoTracking();
            if (!Common.AuthenticateRight.AuthOperation(120101) && !CommonClass.SttUser.blSuperUser)
            {//判断是否有权限查看其它人
                mDaSuppliers = mDaSuppliers.Where(d => d.IntEmpNum == Classes.PubClass.UserId);
            }
            if(txtSupplierNum.Text.Trim()!=string.Empty)
            {
                mDaSuppliers = mDaSuppliers.Where(d => d.VcNum.Contains(txtSupplierNum.Text.Trim()) == true);
            }
            if(txtSupplierName.Text.Trim()!=string.Empty)
            {
                mDaSuppliers = mDaSuppliers.Where(d => d.VcName.Contains(txtSupplierName.Text.Trim()) == true);
            }

            dgvNav1.DataSource = mDaSuppliers;// mDaGoods.DaGoodsSuppliers.Select(d => d.DaSupplier).ToList();
        }

        private void InitDaSupplierContact()
        {
            var rowIndex = dgvDaSupplier.SelectedRows[0].Index;
            DaSupplier mDaSupplier = (DaSupplier)DaSupplierBindingSource[rowIndex];
            DaSuppContactBindingSource.DataSource = myEntity.DaSupplierContacts.Where(d => d.IntSupplierID == mDaSupplier.IntID).AsNoTracking().ToList();// mDaSupplier.DaSupplierContacts.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitDaGoodsSupplier();
        }

        private void dgvDaSupplier_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //if (e.ColumnIndex == dsc删除.Index)
            //{
            //    //删除
            //    DaSupplier mDaSupplier = (DaSupplier)DaSupplierBindingSource[e.RowIndex];
            //    if (mDaSupplier.DaPurchaseContracts.Count > 0)
            //    {
            //        MessageBox.Show("该物品已有采购订单,不能删除");
            //        return;
            //    }
            //    if (MessageBox.Show("是否确认删除" + mDaSupplier.VcName, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            //        return;
            //    myEntity.DaSuppliers.Remove(mDaSupplier);

            //    int ret = myEntity.SaveChanges();

            //    if (ret > 0)
            //    {
            //        MessageBox.Show("删除成功");
            //        InitDaGoodsSupplier();
            //    }
            //    else
            //    {
            //        MessageBox.Show("删除失败");
            //    }
            //}
            if (e.ColumnIndex == ds修改.Index)
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
            //if (e.ColumnIndex == dsc删除.Index)
            //{
            //    //删除
            //    DaSupplierContact mDaSupplierContact = (DaSupplierContact)DaSuppContactBindingSource[e.RowIndex];

            //    if (MessageBox.Show("是否确认删除" + mDaSupplierContact.VcName, "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
            //        return;
            //    myEntity.DaSupplierContacts.Remove(mDaSupplierContact);

            //    int ret = myEntity.SaveChanges();

            //    if (ret > 0)
            //    {
            //        MessageBox.Show("删除成功");
            //        InitDaSupplierContact();
            //    }
            //    else
            //    {
            //        MessageBox.Show("删除失败");
            //    }
            //}
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
 

    }
}
