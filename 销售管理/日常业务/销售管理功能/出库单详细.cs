using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetProductsTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetStockOutTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 出库单详细 : Form
    {
        public 出库单详细()
        {
            InitializeComponent();
        }

        public long mId = -1;
        private long ProductId;

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ProductId < 1)
            {
                MessageBox.Show("请选择产品类型");
                return;
            }
            try
            {
                if (mId == -1)
                {
                    int ret = new T_StockOutTableAdapter().Insert((long)cmbUserName.SelectedValue, (long)cmbCustomerName.SelectedValue,dtpDate1.Value.Date, ProductId, Convert.ToDecimal(txtAmount.Text), Convert.ToDecimal(txtPrice.Text), Convert.ToDecimal(txtSum.Text), cmbSettlementModes.Text,(cmbCustomerName.SelectedValue.ToString() == "" ? -1 : (long)cmbCustomerName.SelectedValue),null,null,null,null,null,null,null,"已提交,等待商务审核" );
                    if (ret > 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("保存失败");
                    }

                }
                else
                {
                    int ret = new T_StockOutTableAdapter().UpdateById((long)cmbUserName.SelectedValue, (long)cmbCustomerName.SelectedValue, dtpDate1.Value.Date, ProductId, Convert.ToDecimal(txtAmount.Text), Convert.ToDecimal(txtPrice.Text), Convert.ToDecimal(txtSum.Text), cmbSettlementModes.Text, (cmbCustomerName.SelectedValue.ToString() == "" ? -1 : (long)cmbCustomerName.SelectedValue), mId);
                    if (ret > 0)
                    {
                        MessageBox.Show("保存成功");
                    }
                    else
                    {
                        MessageBox.Show("保存失败");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void SetProduct(销售管理.DAL.DataSetProducts.T_ProductsRow mRow)
        {
            if (mRow.Level == 1)
            {
                cmbProduct1.SelectedValue = mRow.Id;
            }
            else
            {
                var mParentTable = new T_ProductsTableAdapter().GetDataByID(mRow.ParentId);
                if (mParentTable.Rows.Count > 0)
                {
                    SetProduct(mParentTable[0]);
                }
                if (mRow.Level == 2)
                {
                    cmbProduct2.SelectedValue = mRow.Id;
                }
                if (mRow.Level == 3)
                {
                    cmbProduct3.SelectedValue = mRow.Id;
                }
            }
        }

        private void 出库单详细_Load(object sender, EventArgs e)
        {
            //获取销售名单
            cmbUserName.DisplayMember = "username";
            cmbUserName.ValueMember = "id";
            cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
            //获取一级产品名单
            var mTable = new T_ProductsTableAdapter().GetDataByLevel(1); //获取level1的产品
            cmbProduct1.DataSource = mTable;
            cmbProduct1.SelectedIndex = -1;
            //foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
            //{
            //    MyCmbList mCmblist = new MyCmbList();
            //    mCmblist.Id = mRow.Id;
            //    mCmblist.Name = mRow.Name;
            //    cmbProduct1.Items.Add(mCmblist);
            //}
            if (mId == -1)
            {


            }
            else
            {
                DataTable dt = new DataTable();
                dt = new T_StockOutTableAdapter().GetDataById(mId);

                if (dt.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetStockOut.T_StockOutRow)dt.Rows[0];

                    cmbUserName.SelectedValue = mRow.UserName;
                    //cmbCustomerName.DisplayMember = "customername";
                    //cmbCustomerName.DataSource = new T_CustomersTableAdapter().GetDataByUserId(mRow.UserName);
                    if (mRow.IsCustomerNameNull() == false)
                        cmbCustomerName.SelectedIndex = cmbCustomerName.FindStringExact(mRow.CustomerName.ToString());

                    //获取产品信息
                    //long pLevel, pId;
                    var mTableProduct = new T_ProductsTableAdapter().GetDataByID(mRow.ProductName);
                    if (mTableProduct.Rows.Count > 0)
                    {
                        销售管理.DAL.DataSetProducts.T_ProductsRow mProductRow = mTableProduct[0];
                        //    for (int i = mProductRow.Level; i > 1; i--)
                        //    {
                        //        var mParentTable = new T_ProductsTableAdapter().GetDataByID(mProductRow.ParentId);
                        //    }
                        //设置产品
                        SetProduct(mProductRow);
                    }

                    //cmbMonth.SelectedItem = mRow.SaleMonth;
                    dtpDate1.Value = mRow.SaleDate;
                    //txtProductName.Text = mRow.ProductName;
                    txtAmount.Text = mRow.Amount.ToString();
                    txtPrice.Text = mRow.Price.ToString();
                    txtSum.Text = mRow.SumMoney.ToString();
                    if (mRow.IsSettlementModesNull() == false) cmbSettlementModes.SelectedText = mRow.SettlementModes;
                   
                }
            }


        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbCustomerName.DisplayMember = "CompanyName";
            cmbCustomerName.ValueMember = "CityID";
            cmbCustomerName.DataSource = new T_CustomersTableAdapter().GetDataByUserId((long)cmbUserName.SelectedValue);
            cmbCustomerName.SelectedIndex = -1;
        }

        private void cmbProduct1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbProduct2.Items.Clear();
            //cmbProduct3.Items.Clear();
            //var mTable = new T_ProductsTableAdapter().GetDataByParentId(((MyCmbList)cmbProduct1.SelectedItem).Id); //获取level2的产品
            cmbProduct2.DataSource = null;
            cmbProduct3.DataSource = null;
            if (cmbProduct1.SelectedIndex == -1) return;
            var mTable = new T_ProductsTableAdapter().GetDataByParentId((long)cmbProduct1.SelectedValue); //获取level2的产品
            if (mTable.Rows.Count > 0)
            {
                cmbProduct2.Visible = true;
                cmbProduct3.Visible = false;
                ProductId = -1;
                //foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
                //{
                //    MyCmbList mCmblist = new MyCmbList();
                //    mCmblist.Id = mRow.Id;
                //    mCmblist.Name = mRow.Name;
                //    cmbProduct2.Items.Add(mCmblist);
                //}
                cmbProduct2.DisplayMember = "name";
                cmbProduct2.ValueMember = "id";
                cmbProduct2.DataSource = mTable;
                cmbProduct2.SelectedIndex = -1;
            }
            else
            {
                cmbProduct2.Visible = false;
                cmbProduct3.Visible = false;
                //ProductId = ((MyCmbList)cmbProduct1.SelectedItem).Id;
                ProductId = (long)cmbProduct1.SelectedValue;
            }
        }

        private void cmbProduct2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cmbProduct3.Items.Clear();
            //var mTable = new T_ProductsTableAdapter().GetDataByParentId(((MyCmbList)cmbProduct2.SelectedItem).Id); //获取level3的产品
            cmbProduct3.DataSource = null;
            if (cmbProduct2.SelectedIndex == -1) return;
            var mTable = new T_ProductsTableAdapter().GetDataByParentId((long)cmbProduct2.SelectedValue); //获取level3的产品
            if (mTable.Rows.Count > 0)
            {
                cmbProduct3.Visible = true;
                ProductId = -1;
                //foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
                //{
                //    MyCmbList mCmblist = new MyCmbList();
                //    mCmblist.Id = mRow.Id;
                //    mCmblist.Name = mRow.Name;
                //    cmbProduct3.Items.Add(mCmblist);
                //}
                cmbProduct3.DisplayMember = "name";
                cmbProduct3.ValueMember = "id";
                cmbProduct3.DataSource = mTable;
                cmbProduct3.SelectedIndex = -1;
            }
            else
            {
                cmbProduct3.Visible = false;
                //ProductId = ((MyCmbList)cmbProduct2.SelectedItem).Id;
                ProductId = (long)cmbProduct2.SelectedValue;
            }
        }

        private void cmbProduct3_SelectedIndexChanged(object sender, EventArgs e)
        {
            //ProductId = ((MyCmbList)cmbProduct3.SelectedItem).Id;
            if (cmbProduct3.SelectedIndex == -1) return;
            ProductId = (long)cmbProduct3.SelectedValue;
        }
    }
}
