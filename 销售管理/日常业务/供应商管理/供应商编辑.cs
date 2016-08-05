using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using 销售管理.DAL;


namespace 销售管理.日常业务.供应商管理
{
    public partial class 供应商编辑 : Form
    {
        public 供应商编辑()
        {
            InitializeComponent();
        }

        public int DaSupplierID { set; get; }
        public int DaGoodsID { set; get; }

        public MYDBEntities2 myEntity;// = new MYDBEntities2();
        DaSupplier mDaSupplier;
        DaGoodsSupplier mDaGoodsSupplier;

        private void 增加供应商_Load(object sender, EventArgs e)
        {
            if (myEntity == null)
            {
                myEntity = new MYDBEntities2();
            }
            if (DaSupplierID == 0)
            {
                //新增
                string maxNum = myEntity.DaSuppliers.Select(a => a.VcNum).Max();

                maxNum = !string.IsNullOrEmpty(maxNum) ? (Convert.ToInt64(maxNum) + 1).ToString() : "1000001";

                txtDaSupplierNum.Text = maxNum;
            }
            else
            {
                //修改
                //根据DaSupplierID获取供应商
                mDaSupplier = myEntity.DaSuppliers.Where(d => d.IntID == DaSupplierID).SingleOrDefault();
                txtName.Text = mDaSupplier.VcName;
                txtRegCapital.Text = mDaSupplier.VcRegCapital;
                txtLegalRep.Text = mDaSupplier.VcLegalRep;
                txtTaxID.Text = mDaSupplier.VcTaxID;
                txtOpeningBank.Text = mDaSupplier.VcOpeningBank;
                txtBankAccount.Text = mDaSupplier.VcBankAccount;
                txtAddress.Text = mDaSupplier.VcAddress;
                txtWebsite.Text = mDaSupplier.VcWebsite;
                txtTel.Text = mDaSupplier.VcTel;
                txtFax.Text = mDaSupplier.VcFax;
                txtPostCode.Text = mDaSupplier.VcPostCode;
                txtRemark.Text = mDaSupplier.VcRemark;

                //DaSupplierbindingSource.DataSource = mDaSupplier;
                //txtName.DataBindings.Add("Text", DaSupplierbindingSource, "VcName");
                //txtRegCapital.DataBindings.Add("Text", DaSupplierbindingSource, "VcRegCapital");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (DaSupplierID == 0)
                {
                    mDaSupplier = new DaSupplier()
                    {
                        VcName = txtName.Text.Trim(),
                        VcRegCapital = txtRegCapital.Text.Trim(),
                        VcLegalRep = txtLegalRep.Text.Trim(),
                        VcTaxID = txtTaxID.Text.Trim(),
                        VcOpeningBank = txtOpeningBank.Text.Trim(),
                        VcBankAccount = txtBankAccount.Text.Trim(),
                        VcAddress = txtAddress.Text.Trim(),
                        VcWebsite = txtWebsite.Text.Trim(),
                        VcTel = txtTel.Text.Trim(),
                        VcFax = txtFax.Text.Trim(),
                        VcPostCode = txtPostCode.Text.Trim(),
                        VcRemark = txtRemark.Text.Trim(),
                        IntEmpNum = Classes.PubClass.UserId,
                        VcNum = txtDaSupplierNum.Text.Trim(),
                        IntStatus = 1
                    };

                    string maxNum = myEntity.DaSuppliers.Select(a => a.VcNum).Max();
                    //获取最新供应商编号
                    maxNum = !string.IsNullOrEmpty(maxNum) ? (Convert.ToInt64(maxNum) + 1).ToString() : "1000001";
                    mDaSupplier.VcNum = maxNum;
                    //mDaSupplier.VcName = txtName.Text.Trim();
                    //mDaSupplier.VcRegCapital = txtRegCapital.Text.Trim();
                    //mDaSupplier.VcLegalRep = txtLegalRep.Text.Trim();
                    //mDaSupplier.VcTaxID = txtTaxID.Text.Trim();
                    //mDaSupplier.VcOpeningBank = txtOpeningBank.Text.Trim();
                    //mDaSupplier.VcBankAccount = txtBankAccount.Text.Trim();
                    //mDaSupplier.VcAddress = txtAddress.Text.Trim();
                    //mDaSupplier.VcWebsite = txtWebsite.Text.Trim();
                    //mDaSupplier.VcTel = txtTel.Text.Trim();
                    //mDaSupplier.VcFax = txtFax.Text.Trim();
                    //mDaSupplier.VcPostCode = txtPostCode.Text.Trim();
                    //mDaSupplier.VcRemark = txtRemark.Text.Trim();
                    //mDaSupplier.IntEmpNum = Classes.PubClass.UserId;
                    //mDaSupplier.VcNum = "1000001";
                    //DbEntityEntry<DaSupplier> entry = myEntity.Entry<DaSupplier>(mDaSupplier);
                    //entry.State = EntityState.Added;
                    myEntity.DaSuppliers.Add(mDaSupplier);
                    //myEntity.SaveChanges();
                }
                else
                {
                    mDaSupplier.VcName = txtName.Text.Trim();
                    mDaSupplier.VcRegCapital = txtRegCapital.Text.Trim();
                    mDaSupplier.VcLegalRep = txtLegalRep.Text.Trim();
                    mDaSupplier.VcTaxID = txtTaxID.Text.Trim();
                    mDaSupplier.VcOpeningBank = txtOpeningBank.Text.Trim();
                    mDaSupplier.VcBankAccount = txtBankAccount.Text.Trim();
                    mDaSupplier.VcAddress = txtAddress.Text.Trim();
                    mDaSupplier.VcWebsite = txtWebsite.Text.Trim();
                    mDaSupplier.VcTel = txtTel.Text.Trim();
                    mDaSupplier.VcFax = txtFax.Text.Trim();
                    mDaSupplier.VcPostCode = txtPostCode.Text.Trim();
                    mDaSupplier.VcRemark = txtRemark.Text.Trim();

                    DbEntityEntry<DaSupplier> entry = myEntity.Entry<DaSupplier>(mDaSupplier);
                    entry.State = EntityState.Unchanged;
                    entry.Property(a => a.VcName).IsModified = true;
                    entry.Property(a => a.VcRegCapital).IsModified = true;
                    entry.Property(a => a.VcLegalRep).IsModified = true;
                    entry.Property(a => a.VcTaxID).IsModified = true;
                    entry.Property(a => a.VcOpeningBank).IsModified = true;
                    entry.Property(a => a.VcBankAccount).IsModified = true;
                    entry.Property(a => a.VcAddress).IsModified = true;
                    entry.Property(a => a.VcWebsite).IsModified = true;
                    entry.Property(a => a.VcTel).IsModified = true;
                    entry.Property(a => a.VcFax).IsModified = true;
                    entry.Property(a => a.VcPostCode).IsModified = true;
                    entry.Property(a => a.VcRemark).IsModified = true;


                    //myEntity.SaveChanges();
                }
                //if (myEntity.Database.Connection.State == ConnectionState.Closed)
                //   myEntity.Database.Connection.Open();
                //using (var mTrans = myEntity.Database.Connection.BeginTransaction())
                using (TransactionScope mTrans = new TransactionScope())
                {
                    
                    int ret = myEntity.SaveChanges();
                    if (ret > 0)
                    {
                        //MessageBox.Show("保存成功");
                        //return;

                    }
                    else
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }
                    if (DaGoodsID > 0)
                    {
                        mDaGoodsSupplier = new DaGoodsSupplier()
                        {
                            IntGoodsID = DaGoodsID,
                            IntSuppilerID = mDaSupplier.IntID
                        };
                        myEntity.DaGoodsSuppliers.Add(mDaGoodsSupplier);

                        ret = myEntity.SaveChanges();
                    }
                    if (ret > 0)
                    {
                        mTrans.Complete();
                        MessageBox.Show("保存成功");
                        DialogResult = System.Windows.Forms.DialogResult.OK;
                        btnSave.Enabled = false;
                        return;

                    }
                    else
                    {
                        MessageBox.Show("保存失败");
                        return;
                    }
                }



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
                    item.ValidationErrors.Clear();
                }
            }
        }


    }
}
