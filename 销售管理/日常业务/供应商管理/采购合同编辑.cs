using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using 销售管理.DAL;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 采购合同编辑 : Form
    {
        public 采购合同编辑()
        {
            InitializeComponent();
        }

        public MYDBEntities2 myEntity;

        public int mDaPurchaseContractID { set; get; }

        private DaPurchaseContract mDaPurchaseContract;

        public DaGoods mDaGoods;
        bool isLoading = false;

        public bool allowModify = false;
        private int mDaSupplierId;

        private DataTable goodsTable;

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (mDaPurchaseContractID != 0)
                {
                    //修改
                    if (mDaPurchaseContract.IntStatus == 2 || mDaPurchaseContract.IntStatus == 4)
                    {
                        mDaPurchaseContract.IntStatus = 1;
                    }
                }
                else
                {
                    //新增
                    //mDaPurchaseContract.IntGoodsID = mDaGoods.IntID;
                    //获取最新合同号
                    string strDateMonth = DateTime.Now.ToString("yyyyMMdd");
                    string mMaxNum = myEntity.DaPurchaseContracts.Where(d => d.VcNum.Contains(strDateMonth)).Max(d => d.VcNum);
                    mMaxNum = string.IsNullOrEmpty(mMaxNum) ? strDateMonth + "001" : (Convert.ToInt64(mMaxNum) + 1).ToString();
                    txtContractNum.Text = mMaxNum;
                    mDaPurchaseContract.VcNum = mMaxNum;
                    mDaPurchaseContract.IntSupplierID = mDaSupplierId;
                    myEntity.DaPurchaseContracts.Add(mDaPurchaseContract);

                }
                //mDaPurchaseContract.IntGoodsID = mDaGoods.IntID;

                using (var mTrans = new TransactionScope())
                {
                    int ret = myEntity.SaveChanges();
                    if (ret > 0)
                    {
                        //添加 合同物品明细
                        foreach (DataRow mRow in goodsTable.Rows)
                        {
                            var mdcg = new DaContractGood()
                            {
                                IntContractID = mDaPurchaseContract.IntID,
                                IntGoodsID = Convert.ToInt32(mRow["IntID"]),
                                IntEmpNum = Classes.PubClass.UserId,
                                MonPrice = Convert.ToDecimal(mRow["MonPrice"]),
                                NumCount = Convert.ToInt32(mRow["NumCount"]),
                                MonSum = Convert.ToDecimal(mRow["MonSum"])
                            };
                            myEntity.DaContractGoods.Add(mdcg);
                        }
                        ret = myEntity.SaveChanges();
                        if (ret > 0)
                        {
                            mTrans.Complete();
                            MessageBox.Show(@"保存成功");
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            MessageBox.Show(@"保存失败");
                        }
                    }
                    else
                    {
                        MessageBox.Show(@"保存失败");
                        
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
                }
            }
        }

        private void 采购合同编辑_Load(object sender, EventArgs e)
        {
            if (myEntity == null)
                myEntity = new MYDBEntities2();
            InitGoodsTable();
            DaSupplierBindingSource.DataSource = goodsTable;
            dgvPurchaseGoods.DataSource = DaSupplierBindingSource;
            isLoading = true;
            InitCmbDaType();
            InitData();

            isLoading = false;
        }

        private void InitCmbDaType()
        {
            cmbDaType.ValueMember = "IntID";
            cmbDaType.DisplayMember = "VcDesc";
            var bs = new BindingSource();
            bs.DataSource =myEntity.ZdPurchaseContractTypes.ToList();
            cmbDaType.DataSource = bs;
        }

        private void InitGoodsTable()
        {
            if (goodsTable == null)
                goodsTable = new DataTable();
            goodsTable.Columns.Add("IntID").DataType = typeof(int);
            goodsTable.Columns.Add("VcName");
            goodsTable.Columns.Add("MonPrice").DataType = typeof(decimal);
            goodsTable.Columns.Add("NumCount").DataType = typeof(decimal);
            goodsTable.Columns.Add("MonSum").DataType = typeof(decimal);
        }


        private void InitData()
        {
            

            //显示申请公司
            cmbApplicantCom.DisplayMember = "VcName";
            cmbApplicantCom.ValueMember = "IntID";

            cmbApplicantCom.DataSource = myEntity.DaCompanies.ToList();

            if (mDaPurchaseContractID != 0)
            {
                //修改
                mDaPurchaseContract = myEntity.DaPurchaseContracts.SingleOrDefault(d => d.IntID == mDaPurchaseContractID);
                //mDaGoodsID = mDaPurchaseContract.IntGoodsID;
               // mDaGoods = mDaPurchaseContract.DaGood;
                lbStatus.Visible = true;
                txtStatus.Visible = true;
                if (mDaPurchaseContract.IntStatus == 2 || mDaPurchaseContract.IntStatus == 4 || allowModify == true)
                {
                    btnSave.Enabled = true;
                }
                else
                {
                    btnSave.Enabled = false;
                }
                // 显示已添加的物品
                List<DaContractGood> mDaContractGoods=  myEntity.DaPurchaseContracts.SingleOrDefault(d => d.IntID == mDaPurchaseContractID).DaContractGoods.ToList();

                foreach (var dcg in mDaContractGoods)
                {
                    GoodsTableInsert(dcg.IntID, dcg.DaGood.VcName, dcg.MonPrice, dcg.NumCount, dcg.MonSum);
                }
            }
            else
            {
                //新增
                string strDateMonth = DateTime.Now.ToString("yyyyMMdd");
                string mMaxNum = myEntity.DaPurchaseContracts.Where(d => d.VcNum.Contains(strDateMonth)).Max(d => d.VcNum);
                mMaxNum = string.IsNullOrEmpty(mMaxNum) ? strDateMonth + "001" : (Convert.ToInt64(mMaxNum) + 1).ToString();
                txtContractNum.Text = mMaxNum;
                mDaPurchaseContract = new DaPurchaseContract() { IntEmpNum = Classes.PubClass.UserId, IntStatus = 1, VcNum = mMaxNum };



            }

            //绑定控件

            txtContractNum.DataBindings.Add("Text", mDaPurchaseContract, "VcNum");
            //if (mDaGoods != null)
            //    txtGoodsName.Text = mDaGoods.VcName;
            //InitCmbSupplier();
            //cmbSupplier.DataBindings.Add("SelectedValue", mDaPurchaseContract, "IntSupplierID");
            cmbApplicantCom.DataBindings.Add("SelectedValue", mDaPurchaseContract, "IntCompanyID");
            mDaSupplierId = mDaPurchaseContract.IntSupplierID;
            if (mDaPurchaseContract.DaSupplier != null)
                txtSupplier.Text = mDaPurchaseContract.DaSupplier.VcName;// myEntity.DaSuppliers.SingleOrDefault(d => d.IntID == mDaSupplierId).VcName;
            txtLinkMan.DataBindings.Add("Text", mDaPurchaseContract, "VcLinkMan");
            txtTel.DataBindings.Add("Text", mDaPurchaseContract, "VcTel");
            txtMobile.DataBindings.Add("Text", mDaPurchaseContract, "VcMobile");
            //txtCount.DataBindings.Add("Text", mDaPurchaseContract, "NumCount", true);
            cmbDaType.DataBindings.Add("SelectedValue", mDaPurchaseContract, "IntType");
            txtCabinet.DataBindings.Add("Text", mDaPurchaseContract, "VcCabinet");
            txtFolder.DataBindings.Add("Text", mDaPurchaseContract, "VcFolder");
            txtRemark.DataBindings.Add("Text", mDaPurchaseContract, "VcRemark");
            txtFax.DataBindings.Add("Text", mDaPurchaseContract, "VcFax");
            txtApplicantDep.DataBindings.Add("Text", mDaPurchaseContract, "VcApplicantDep");
            txtApplicant.DataBindings.Add("Text", mDaPurchaseContract, "VcApplicant");
            if (mDaPurchaseContract.ZdContractStatu != null)
                txtStatus.DataBindings.Add("Text", mDaPurchaseContract.ZdContractStatu, "VcDesc");
            //txtPrice.DataBindings.Add("Text", mDaPurchaseContract, "MonPrice");
            txtSum.DataBindings.Add("Text", mDaPurchaseContract, "MonSum");


        }

        //private void InitCmbSupplier()
        //{
        //    cmbSupplier.DisplayMember = "VcName";
        //    cmbSupplier.ValueMember = "IntID";
        //    if (mDaGoods != null)
        //    {
        //        DaSupplierBindingSource.DataSource = mDaGoods.DaGoodsSuppliers.Select(d => d.DaSupplier).ToList();
        //        cmbSupplier.DataSource = DaSupplierBindingSource;
        //        if (cmbSupplier.Items.Count > 0)
        //        {
        //            cmbSupplier.SelectedIndex = 0;
        //            mDaPurchaseContract.IntSupplierID = (int)cmbSupplier.SelectedValue;
        //        }
        //    }
        //}

        private void btnSelectGoods_Click(object sender, EventArgs e)
        {
            if (mDaSupplierId < 1)
            {
                MessageBox.Show(@"请先选择供应商！");
                return;
            }
            using (var mForm = new 选择采购物品())
            {
                mForm.DaSupplierId = mDaSupplierId;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    //mDaGoods = mForm.DaGoods;
                    //txtGoodsName.Text = mDaGoods.VcName;
                    //InitCmbSupplier();
                    GoodsTableInsert(mForm.DaGoodsID, mForm.DaGoodsName, mForm.DaPrice, mForm.DaCount, mForm.DaSum);
                    ShowSum();

                }
            }
        }

        private void ShowSum()
        {
            txtSum.Text = goodsTable.Compute("sum(MonSum)", "true").ToString();
            mDaPurchaseContract.MonSum = Convert.ToDecimal(txtSum.Text==string.Empty? "0":txtSum.Text);
        }


        private void GoodsTableInsert(int daGoodsId, string daGoodsName, decimal daPrice, int daCount, decimal daSum)
        {
            var mRow = goodsTable.NewRow();

            mRow["IntID"] = daGoodsId;
            mRow["VcName"] = daGoodsName;
            mRow["MonPrice"] = daPrice;
            mRow["NumCount"] = daCount;
            mRow["MonSum"] = daSum;
            goodsTable.Rows.Add(mRow);

            
        }
        //private void cmbSupplier_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (isLoading == true)
        //        return;
        //    if (cmbSupplier.SelectedIndex < 0)
        //        return;
        //    //显示供应商的第一个联系人
        //    DaSupplierContact mDaSupplierContact;
        //    ICollection<DaSupplierContact> mDaSupplierContacts = ((DaSupplier)DaSupplierBindingSource[cmbSupplier.SelectedIndex]).DaSupplierContacts;
        //    if (mDaSupplierContacts.Count() < 1)
        //    {
        //        return;
        //    }
        //    mDaSupplierContact = mDaSupplierContacts.Take(1).SingleOrDefault();
        //    txtLinkMan.Text = mDaSupplierContact.VcName;
        //    txtTel.Text = mDaSupplierContact.VcTel;
        //    txtFax.Text = mDaSupplierContact.VcFax;
        //    txtMobile.Text = mDaSupplierContact.VcMobile;

        //    mDaPurchaseContract.VcLinkMan = mDaSupplierContact.VcName;
        //    mDaPurchaseContract.VcTel = mDaSupplierContact.VcTel;
        //    mDaPurchaseContract.VcFax = mDaSupplierContact.VcFax;
        //    mDaPurchaseContract.VcMobile = mDaSupplierContact.VcMobile;
        //}

        

        private void btnSupplier_Click(object sender, EventArgs e)
        {
            if (goodsTable.Rows.Count > 0)
            {
                MessageBox.Show(@"更换供应商需先清除采购物品！");
                return;
            }
            using (var mForm=new 选择供应商())
            {
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    //选择供应商
                    mDaSupplierId = mForm.mDaSupplierID[0];
                    var singleOrDefault = myEntity.DaSuppliers.SingleOrDefault(d => d.IntID == mDaSupplierId);
                    if (singleOrDefault != null)
                    {
                        txtSupplier.Text = singleOrDefault.VcName;
                        DaSupplierContact dsc = singleOrDefault.DaSupplierContacts.SingleOrDefault();
                        if (dsc != null)
                        {
                            txtLinkMan.Text = dsc.VcName;
                            mDaPurchaseContract.VcLinkMan = dsc.VcName;
                            txtMobile.Text = dsc.VcMobile;
                            mDaPurchaseContract.VcMobile = dsc.VcMobile;
                            txtTel.Text = dsc.VcTel;
                            mDaPurchaseContract.VcTel = dsc.VcTel;
                            txtFax.Text = dsc.VcFax;
                            mDaPurchaseContract.VcFax = dsc.VcFax;
                        }
                    }
                }
            }
        }

        private void dgvPurchaseGoods_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == ds删除.Index)
            {
                goodsTable.Rows.Remove(((DataRowView)DaSupplierBindingSource[e.RowIndex]).Row);
                ShowSum();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            goodsTable.Rows.Clear();
        }
    }
}
