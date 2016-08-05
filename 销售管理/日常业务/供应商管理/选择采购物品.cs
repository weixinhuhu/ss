using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 选择采购物品 : Form
    {
        public 选择采购物品()
        {
            InitializeComponent();
        }


        public MYDBEntities2 myEntity;

        public int DaGoodsID { set; get; }

        public decimal DaPrice { set; get; }
        public int DaCount { set; get; }
        public decimal DaSum { set; get; }
        public string DaGoodsName { set; get; }

        public int DaSupplierId { get; set; }

        private void 选择采购物品_Load(object sender, EventArgs e)
        {
            if (myEntity == null)
                myEntity = new MYDBEntities2();
            //if(DaGoods != null)
            //{
            //    //已选择,显示选择的物品;
            //    txtGoodsNum.Text = DaGoods.VcNum;
            //    txtGoodsName.Text = DaGoods.VcName;
            //}
            InitGoodsNameData();
            InitDataBinding();

        }

        private void InitGoodsNameData()
        {
            AutoCompleteStringCollection mAutoComplete = new AutoCompleteStringCollection();
            mAutoComplete.AddRange(myEntity.DaGoods1.Select(d => d.VcName).ToArray());
            txtGoodsName.AutoCompleteCustomSource = mAutoComplete;
            txtGoodsName.AutoCompleteMode = AutoCompleteMode.Suggest;
            txtGoodsName.AutoCompleteSource = AutoCompleteSource.CustomSource;
        }

        private void InitDataBinding()
        {
            IQueryable<DaGoods> mDaGoodss;
            mDaGoodss = DaSupplierId != 0 ? myEntity.DaGoodsSuppliers.Where(d => d.IntSuppilerID == DaSupplierId).Select(d => d.DaGood) : myEntity.DaGoods1;

            if (txtGoodsName.Text.Trim() != string.Empty)
            {
                mDaGoodss = mDaGoodss.Where(d => d.VcName.Contains(txtGoodsName.Text.Trim()));
            }
            if (txtGoodsNum.Text.Trim() != string.Empty)
            {
                mDaGoodss = mDaGoodss.Where(d => d.VcNum.Contains(txtGoodsNum.Text.Trim()));
            }

            DaGoodsBindingSource.DataSource = mDaGoodss.ToList();
        }



        private void btnOK_Click(object sender, EventArgs e)
        {
            if(dgvDaGoods.SelectedRows.Count<1)
            {
                MessageBox.Show("请选择采购物品");
                return;
            }
            //判断数据是否完整
            if (Classes.Valid.ValidIntPositive(txtCount.Text.Trim(),"采购个数") == false)
                return;
            if(Classes.Valid.ValidMoneyPositive(txtPrice.Text.Trim(),"价格")==false)
                return;
            if (Classes.Valid.ValidMoneyPositive(txtSum.Text.Trim(), "金额") == false)
                return;


            int rowIndex = dgvDaGoods.SelectedRows[0].Index;

            DaGoodsID = ((DaGoods)DaGoodsBindingSource[rowIndex]).IntID;
            DaGoodsName = ((DaGoods) DaGoodsBindingSource[rowIndex]).VcName;
            DaPrice = Convert.ToDecimal(txtPrice.Text);
            DaCount = Convert.ToInt32(txtCount.Text);
            DaSum = Convert.ToDecimal(txtSum.Text);
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void txtGoodsNum_TextChanged(object sender, EventArgs e)
        {
            InitDataBinding();
        }

        private void dgvDaGoods_DoubleClick(object sender, EventArgs e)
        {
            if (dgvDaGoods.SelectedRows.Count < 1)
                return;
            if (dgvDaGoods.SelectedRows[0].Index < 0)
                return;

            btnOK.PerformClick();
        }

        private void dgvDaGoods_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDaGoods.SelectedRows.Count < 1)
                return;
            int rowIndex = dgvDaGoods.SelectedRows[0].Index;
            if (rowIndex < 0)
                return;
            DaSupplierBindingSource.DataSource =
                ((DaGoods)DaGoodsBindingSource[rowIndex]).DaGoodsSuppliers.Select(d => d.DaSupplier).ToList();
        }

        private void txtCount_TextChanged(object sender, EventArgs e)
        {
            if(Classes.PubFunc.IsIntPositive(txtCount.Text.Trim())==false)
                return;
            if (Classes.PubFunc.IsMoneyPositive(txtPrice.Text.Trim()) == false)
                return;

            txtSum.Text = (Convert.ToDecimal(txtPrice.Text)*Convert.ToDecimal(txtCount.Text)).ToString("0.00");

        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (Classes.PubFunc.IsMoneyPositive(txtPrice.Text.Trim() + e.KeyChar) == false)
                e.Handled=true;
        }

        private void txtCount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Back)
                return;
            if (Classes.PubFunc.IsIntPositive(txtCount.Text.Trim() + e.KeyChar) == false)
                e.Handled = true;
        }


    }
}
