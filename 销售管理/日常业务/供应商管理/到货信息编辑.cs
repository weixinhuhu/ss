using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;
using System.Data.Entity;
using NPOI.SS.Formula.Functions;
// ReSharper disable All

namespace 销售管理.日常业务.供应商管理
{
    public partial class 到货信息编辑 : Form
    {
        public 到货信息编辑()
        {
            InitializeComponent();
        }

        private MYDBEntities2 myEntity;

        public int MContractGoodsId { get; set; }
        public string GoodsName { get; set; }

        public decimal DaPrice { set; get; }
        public int MDaStockInId { set; get; }

        private DaStockIn _mDaStockIn;

        private void 到货信息编辑_Load(object sender, EventArgs e)
        {
            myEntity = new MYDBEntities2();
            /*
            //判断是否有货物已入库
            var mStockIn = myEntity.DaStockIns.Where(d => d.IntContractID == mContractID).ToList();

            if (mStockIn.Count > 0)
                mDaStockInID = mStockIn[0].IntID;
             */
            InitData();

        }

        private void InitData()
        {
            if (MDaStockInId > 0)
            {
                //修改
                _mDaStockIn = myEntity.DaStockIns.SingleOrDefault(d => d.IntID == MDaStockInId);

            }
            else
            {
                //新增

                _mDaStockIn = new DaStockIn()
                {
                    IntContractGoodsID = MContractGoodsId,
                    IntEmpNum = Classes.PubClass.UserId,
                    IntStatus = 1 // 等待产品部检验
                };
            }
            
            //获取已入库数量
            txtHasStockInCount.Text =
                myEntity.DaStockIns.Where(d => d.IntContractGoodsID == MContractGoodsId && d.IntStatus != 3)
                    .Sum(d => d.NumCount).ToString();

            DaContractGood daContractGood = myEntity.DaContractGoods.SingleOrDefault(d => d.IntID == MContractGoodsId);
            if (daContractGood != null)
            {
                //获取合同编号
                txtContractNum.Text = daContractGood.DaPurchaseContract.VcNum;
                //获取合同单价
                _mDaStockIn.MonPrice = daContractGood.MonPrice;
                //获取采购物品名称
                txtStockInName.Text = daContractGood.DaGood.VcName;
                //获取合同采购数量
                txtContractCount.Text = daContractGood.NumCount.ToString();
                //获取物品ID
                _mDaStockIn.IntGoodsID = daContractGood.IntGoodsID;
                //获取物品单位
                _mDaStockIn.VcUnit = daContractGood.DaGood.ZdGoodsUnit.VcDesc;
            }


            txtStockInCount.DataBindings.Add("Text", _mDaStockIn, "NumCount", true);
            txtPrice.DataBindings.Add("Text", _mDaStockIn, "MonPrice");
            txtUnit.DataBindings.Add("Text", _mDaStockIn, "VcUnit");
            txtSum.DataBindings.Add("Text", _mDaStockIn, "MonSum");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                //判断入库数量是否超过合同数量
                decimal mContractNum = Convert.ToDecimal(txtContractCount.Text);
                decimal mHasStockInNum = Convert.ToDecimal(txtHasStockInCount.Text);

                if (_mDaStockIn.NumCount + mHasStockInNum > mContractNum)
                {
                    MessageBox.Show("入库数量大于合同数量,不能提交");
                    return;
                }
                if (_mDaStockIn.NumCount < 1)
                {
                    MessageBox.Show("到货数量必须大于0");
                    return;
                }


                if (MDaStockInId > 0)
                {

                }
                else
                {
                    myEntity.DaStockIns.Add(_mDaStockIn);
                }

                int mRet = myEntity.SaveChanges();
                if (mRet > 0)
                {
                    MessageBox.Show("保存成功");
                    DialogResult = System.Windows.Forms.DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("保存失败");
                    return;
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

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            decimal mCount;
            decimal mPrice;
            if (decimal.TryParse(txtPrice.Text, out mPrice) == false)
                return;
            if (decimal.TryParse(txtStockInCount.Text, out mCount) == false)
                return;

            decimal mSum = mCount * mPrice;
            txtSum.Text = mSum.ToString("0.00");
            _mDaStockIn.MonSum = mSum;
        }


        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (Classes.PubFunc.IsIntPositive(txtStockInCount.Text.Trim() + e.KeyChar) == false)
                e.Handled = true;
        }
    }
}
