using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 供应商联系人编辑 : Form
    {
        public 供应商联系人编辑()
        {
            InitializeComponent();
        }

        public int DaContactID { set; get; }
        public int DaSupplierID { set; get; }

        public MYDBEntities2 myEntity;//= new MYDBEntities2();
        private DaSupplierContact mDaSuppContact;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (DaContactID > 0)
            {
                //修改

            }
            else
            {
                
                //增加
                myEntity.DaSupplierContacts.Add(mDaSuppContact);
            }
            try
            {
                int ret = myEntity.SaveChanges();
                {
                    if (ret > 0)
                    {
                        MessageBox.Show("保存成功");
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        btnSave.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("保存失败");
                    }
                }
            }
            catch (DbEntityValidationException ex)
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

        private void 供应商联系人编辑_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            if (myEntity == null)
                myEntity = new MYDBEntities2();
            
            if (DaContactID > 0)
            {
                //修改
                mDaSuppContact = myEntity.DaSupplierContacts.Where(d => d.IntID == DaContactID).SingleOrDefault();
                DaSupplierID = mDaSuppContact.IntSupplierID;
            }
            else
            {
                //增加
                mDaSuppContact = new DaSupplierContact() { IntSupplierID = DaSupplierID ,IntEmpNum = Classes.PubClass.UserId};
                DaSupplier daSupplier = myEntity.DaSuppliers.SingleOrDefault(d => d.IntID == DaSupplierID);
                if (daSupplier != null)
                {
                    mDaSuppContact.VcTel = daSupplier.VcTel;
                    mDaSuppContact.VcFax = daSupplier.VcFax;
                }
            }
            bindingSourceDaSuppContact.DataSource = mDaSuppContact;
            txtName.Text = myEntity.DaSuppliers.Where(d => d.IntID == DaSupplierID).SingleOrDefault().VcName;
            txtContactName.DataBindings.Add("Text", bindingSourceDaSuppContact, "VcName");
            txtPost.DataBindings.Add("Text", bindingSourceDaSuppContact, "VcPost");
            txtTel.DataBindings.Add("Text", bindingSourceDaSuppContact, "VcTel");
            txtFax.DataBindings.Add("Text", bindingSourceDaSuppContact, "VcFax");
            txtMobile.DataBindings.Add("Text", bindingSourceDaSuppContact, "VcMobile");
            txtQQ.DataBindings.Add("Text", bindingSourceDaSuppContact, "VcQQ");
            txtEmail.DataBindings.Add("Text", bindingSourceDaSuppContact, "VcEmail");
            txtRemark.DataBindings.Add("Text", bindingSourceDaSuppContact, "VcRemark");

        }
    }
}
