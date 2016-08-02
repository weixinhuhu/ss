using System;
using System.Data.Entity.Validation;
using System.Linq;
using System.Windows.Forms;
using 销售管理.Classes;
using 销售管理.DAL;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 发票信息编辑 : Form
    {
        public 发票信息编辑()
        {
            InitializeComponent();
        }

        public int MContractGoodsId { set; get; }
        public int MInvoiceId { set; get; }

        public int MGoodsId { set; get; }

        public MYDBEntities2 myEntity;
        private DaInvoice _mInvoice;

        private void 发票信息编辑_Load(object sender, EventArgs e)
        {
            if (myEntity == null)
            {
                myEntity = new MYDBEntities2();
            }
            //获取已到票信息
            var mDaInvoice = myEntity.DaInvoices.Where(d => d.IntContractGoodsID == MContractGoodsId).ToList();
            if (mDaInvoice.Count > 0)
                MInvoiceId = mDaInvoice[0].IntID;

            InitData();
        }

        private void InitData()
        {
            var daContractGood = myEntity.DaContractGoods.SingleOrDefault(d => d.IntID == MContractGoodsId);
            if (daContractGood == null)
                return;

            _mInvoice = MInvoiceId > 0 ? myEntity.DaInvoices.SingleOrDefault(d => d.IntID == MInvoiceId) : new DaInvoice() { IntContractGoodsID = MContractGoodsId, IntEmpNum = PubClass.UserId, IntStatus = 1, IntGoodsID = daContractGood.IntGoodsID,VcUnit = daContractGood.DaGood.ZdGoodsUnit.VcDesc};

            //获取已到库数量
            txtHasInvoice.Text = (daContractGood.DaInvoices.Where(d => d.IntStatus != 3)
                    .Sum(d => d.NumCount) ).ToString("0");
            
            //获取合同编号
           
            txtContractNum.Text = daContractGood.DaPurchaseContract.VcNum;
            //获取合同单价
            txtPriceTax.Text = daContractGood.MonPrice.ToString("0.00");
            //获取采购物品名称
            txtContractGoodsName.Text = daContractGood.DaGood.VcName;
            //txtUnit.Text = daContractGood.DaGood.ZdGoodsUnit.VcDesc;
            if (_mInvoice == null) return;
            //绑定
            txtInvoiceNum.DataBindings.Add("Text", _mInvoice, "VcNum");
            txtInvoiceCount.DataBindings.Add("Text", _mInvoice, "NumCount", true);
            txtNoTaxPrice.DataBindings.Add("Text", _mInvoice, "MonPrice");
            txtNoTaxSum.DataBindings.Add("Text", _mInvoice, "MonSumNoTax");
            txtSum.DataBindings.Add("Text", _mInvoice, "MonSum");
            txtUnit.DataBindings.Add("Text", _mInvoice, "VcUnit");
            txtRemark.DataBindings.Add("Text", _mInvoice, "VcRemark");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //判断入库数量是否超过合同数量
                decimal mContractNum = myEntity.DaContractGoods.Where(d => d.IntID == MContractGoodsId && d.IntGoodsID == _mInvoice.IntGoodsID).Sum(d => d.NumCount);
                //decimal mHasStockInNum = myEntity.DaInvoices.Where(d => d.IntContractID == mContractID).Sum(d => d.NumCount) ?? 0;

                if (_mInvoice.NumCount < 1)
                {
                    MessageBox.Show("入库数量必须大于0");
                    return;
                }

                if (_mInvoice.NumCount > mContractNum)
                {
                    MessageBox.Show(@"发票数量大于合同数量,不能提交");
                    return;
                }
                if (Convert.ToDecimal(txtNoTaxPrice.Text) > Convert.ToDecimal(txtPriceTax.Text))
                {
                    MessageBox.Show(@"不含税单价不能大于含税单价！");
                    return;
                }

                if (MInvoiceId > 0)
                {
                    //修改
                }
                else
                {
                    //新增

                    myEntity.DaInvoices.Add(_mInvoice);
                }

                int mRet = myEntity.SaveChanges();
                if (mRet > 0)
                {
                    MessageBox.Show(@"保存成功");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(@"保存失败");
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

        private void txtInvoiceCount_TextChanged(object sender, EventArgs e)
        {
            //自动算合计
            decimal mCount;
            decimal mPrice;
            decimal mPriceTax;

            if (!decimal.TryParse(txtNoTaxPrice.Text, out mPrice))
                return;
            if (!decimal.TryParse(txtInvoiceCount.Text, out mCount))
                return;
            if (!decimal.TryParse(txtPriceTax.Text, out mPriceTax))
                return;

            var mSum = mPrice * mCount;
            txtNoTaxSum.Text = mSum.ToString("0.00");
            txtSum.Text = (mPriceTax * mCount).ToString("0.00");

            _mInvoice.MonSum = mPriceTax*mCount;
            _mInvoice.MonSumNoTax = mSum;
        }
    }
}
