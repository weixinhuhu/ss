using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 销售管理.日常业务
{
    public partial class 开票选择销售明细 : Form
    {
        public 开票选择销售明细()
        {
            InitializeComponent();
        }

        public long m_CustomerId = -1;

        private void txtAmout_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("0123456789".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }
        public DataTable mSelected ;
        public string cantSelect;

        private void 开票选择销售明细_Load(object sender, EventArgs e)
        {
            InitData("");
            
        }

        private void InitData(string productName)
        {
            string mSql;
            
            mSql = "SELECT a.Id, c.UserName,e.companyname customername, a.SaleDate, d.name as ProductName, a.Price, a.Amount,isnull(f.hasInvoice,0) hasInvoice,isnull(g.Invoicing,0) Invoicing,a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0) caninvoice, a.SumMoney,a.stockoutno FROM dbo.T_SaleDetails a left join T_Users c on a.UserName = c.Id left join T_Products d on a.productName = d.id left join t_customers e on a.customername = e.id left join (select saledetailsid,isnull(sum(amount),0) hasInvoice from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status = '财务已开票' group by saledetailsid) f on a. id = f.saledetailsid left join (select saledetailsid,isnull(sum(amount),0) Invoicing from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status like '%等待%' group by saledetailsid) g on g.saledetailsid = a.id where ascii(a.CustomerName) < 123   and  a.customername = " + m_CustomerId.ToString()  ;
                     
            //排除不开票信息
            mSql += "and a.InvoiceFlag <>'不开票' ";
                   
            if (cantSelect != "")
            {
                mSql += " and a.id not in(" + cantSelect + ")";
            }
            if (productName != "")
            {
                mSql += " and d.name like '%" + productName.Replace(" ", "%") + "%'";
            }
         

            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvCustomerSaleDetails.DataSource = mTable;
                (dgvCustomerSaleDetails.DataSource as DataTable).PrimaryKey = new DataColumn[1] { (dgvCustomerSaleDetails.DataSource as DataTable).Columns[0] };
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
                if (mSelected != null)
                {
                    foreach (DataRow mRow in mSelected.Rows)
                    {
                        int mIndex = dgvInvoiceDetails.Rows.Add();

                        dgvInvoiceDetails["ColSaleDetailsId", mIndex].Value = mRow["SaleDetailsId"];
                        dgvInvoiceDetails["ColProductName", mIndex].Value = mRow["ProductName"];
                        dgvInvoiceDetails["ColPrice", mIndex].Value = mRow["Price"];
                        dgvInvoiceDetails["ColAmount", mIndex].Value = mRow["Amount"];
                        dgvInvoiceDetails["ColSumMoney", mIndex].Value = mRow["SumMoney"];
                        dgvInvoiceDetails["ColSaleDate", mIndex].Value = mRow["SaleDate"];
                        dgvInvoiceDetails["ColStockOutNo", mIndex].Value = mRow["StockOutNo"];
                        dgvCustomerSaleDetailsReduce(mIndex);
                    }
                }
                //MessageBox.Show("查询成功");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtAmout.Text.Trim() == "")
                {
                    MessageBox.Show("请数入本次开票数量");
                    return;
                }
                int canInvoice = Convert.ToInt32(dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnCanInvoice"].Value);
                int nowInvoice = Convert.ToInt32(txtAmout.Text);
                if (canInvoice <= 0)
                {
                    MessageBox.Show("可开数量必须大于0");
                    return;
                }
                if (nowInvoice <= 0)
                {
                    MessageBox.Show("本次开票数量必须大于0");
                    return;
                }
                if (canInvoice < nowInvoice)
                {
                    MessageBox.Show("数量不能大于可开数量");
                    return;
                }
                //判断单价是否一致
                if (dgvInvoiceDetails.Rows.Count > 0)
                {
                    decimal mPrice = Convert.ToDecimal(dgvInvoiceDetails.Rows[0].Cells["ColPrice"].Value);
                    decimal mNewPrice = Convert.ToDecimal(dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnPrice"].Value);
                    if (mPrice != mNewPrice)
                    {
                        MessageBox.Show("所选记录的单价不一致!请选择单价一致的记录");
                        return;
                    }
                }

                //添加到下面的列表,并减少相应的数量
                int mIndex = dgvInvoiceDetails.Rows.Add();
                
                dgvInvoiceDetails["ColSaleDetailsId", mIndex].Value = dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnId"].Value;
                dgvInvoiceDetails["ColProductName", mIndex].Value = dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnProductName"].Value;
                dgvInvoiceDetails["ColPrice", mIndex].Value = dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnPrice"].Value;
                dgvInvoiceDetails["ColAmount", mIndex].Value = nowInvoice;
                dgvInvoiceDetails["ColSumMoney", mIndex].Value = Convert.ToDecimal(dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnPrice"].Value) * nowInvoice;
                dgvInvoiceDetails["ColSaleDate", mIndex].Value = dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnSaleDate"].Value;
                dgvInvoiceDetails["ColStockOutNo", mIndex].Value = dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnStockOutNo"].Value;
                //dgvInvoiceDetails["ColIndex", mIndex].Value = dgvCustomerSaleDetails.SelectedRows[0].Index;
                dgvCustomerSaleDetailsReduce(mIndex);
                //(dgvCustomerSaleDetails.DataSource as DataTable).Rows.Find(dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnId"].Value)["caninvoice"] = Convert.ToDecimal((dgvCustomerSaleDetails.DataSource as DataTable).Rows.Find(dgvCustomerSaleDetails.SelectedRows[0].Cells["ColumnId"].Value)["caninvoice"]) - nowInvoice;
                //dgvCustomerSaleDetails.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (dgvInvoiceDetails.SelectedRows.Count > 0)
            {
                int nowInvoice = Convert.ToInt32(dgvInvoiceDetails["ColAmount", dgvInvoiceDetails.SelectedRows[0].Index].Value);
                //int mIndex = Convert.ToInt32(dgvInvoiceDetails["ColIndex", dgvInvoiceDetails.SelectedRows[0].Index].Value);
                //(dgvCustomerSaleDetails.DataSource as DataTable).Rows[mIndex]["caninvoice"] = Convert.ToDecimal((dgvCustomerSaleDetails.DataSource as DataTable).Rows[mIndex]["caninvoice"]) + nowInvoice;
                (dgvCustomerSaleDetails.DataSource as DataTable).Rows.Find(dgvInvoiceDetails.SelectedRows[0].Cells["ColSaleDetailsId"].Value)["caninvoice"] = Convert.ToDecimal((dgvCustomerSaleDetails.DataSource as DataTable).Rows.Find(dgvInvoiceDetails.SelectedRows[0].Cells["ColSaleDetailsId"].Value)["caninvoice"]) + nowInvoice;
                dgvCustomerSaleDetails.Refresh();
                dgvInvoiceDetails.Rows.Remove(dgvInvoiceDetails.SelectedRows[0]);
            }
            else
            {
                MessageBox.Show("请选择要移除的行");
            }
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            //if (dgvInvoiceDetails.Rows.Count < 1)
            //{
            //    MessageBox.Show("请选择出库单");
            //    return;
            //}
            try
            {
                //mSelected.Clear();
                if (dgvInvoiceDetails.Rows.Count > 0)
                {
                    mSelected = new DataTable();
                    //添加标头
                    mSelected.Columns.Add("SaleDetailsId");
                    mSelected.Columns.Add("ProductName");
                    mSelected.Columns.Add("Price");
                    mSelected.Columns.Add("Amount");
                    mSelected.Columns.Add("SumMoney");
                    mSelected.Columns.Add("StockOutNo");
                    mSelected.Columns.Add("SaleDate");
                    //将dgvInvoiceDetails 放到DateTable

                    foreach (DataGridViewRow mRow in dgvInvoiceDetails.Rows)
                    {
                        mSelected.Rows.Add(mRow.Cells["ColSaleDetailsId"].Value, mRow.Cells["ColProductName"].Value, mRow.Cells["ColPrice"].Value, mRow.Cells["ColAmount"].Value, mRow.Cells["ColSumMoney"].Value, mRow.Cells["ColStockOutNo"].Value, mRow.Cells["ColSaleDate"].Value);
                    }
                }
                else
                {
                    mSelected = null;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }
        private void dgvCustomerSaleDetailsReduce(int index)
        {
            (dgvCustomerSaleDetails.DataSource as DataTable).Rows.Find(dgvInvoiceDetails["ColSaleDetailsId", index].Value)["caninvoice"] = Convert.ToDecimal((dgvCustomerSaleDetails.DataSource as DataTable).Rows.Find(dgvInvoiceDetails["ColSaleDetailsId", index].Value)["caninvoice"]) - Convert.ToDecimal(dgvInvoiceDetails["ColAmount", index].Value);
            dgvCustomerSaleDetails.Refresh();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrencyManager cm = (CurrencyManager)BindingContext[dgvCustomerSaleDetails.DataSource];
            cm.SuspendBinding();
            switch (cmbCanInvoice.Text)
            {
                case "所有":
                    foreach (DataGridViewRow mRow in dgvCustomerSaleDetails.Rows)
                    {
                        mRow.Visible = true;
                    }
                    break;
                case "可开票":
                    foreach (DataGridViewRow mRow in dgvCustomerSaleDetails.Rows)
                    {
                        if (Convert.ToDecimal(mRow.Cells["ColumnCanInvoice"].Value) > 0)
                            mRow.Visible = true;
                        else
                            mRow.Visible = false;
                    }
                    break;
                case "不可开票":
                    
                    foreach (DataGridViewRow mRow in dgvCustomerSaleDetails.Rows)
                    {
                        if (Convert.ToDecimal(mRow.Cells["ColumnCanInvoice"].Value) > 0)
                            mRow.Visible = false;
                        else
                            mRow.Visible = true;
                    }
                    break;
            }
            cm.ResumeBinding();
        }

        private void dgvInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                long saleDetailsId = Convert.ToInt64(dgvInvoiceDetails.Rows[e.RowIndex].Cells["ColSaleDetailsId"].Value);
                foreach(DataGridViewRow mRow in dgvCustomerSaleDetails.Rows)
                {
                    if (Convert.ToInt64(mRow.Cells["ColumnId"].Value) == saleDetailsId)
                    {
                        mRow.Selected = true;
                        dgvCustomerSaleDetails.FirstDisplayedScrollingRowIndex = mRow.Index;
                        break;
                    }
                }
            }
        }

        private void btnFiter_Click(object sender, EventArgs e)
        {
            InitData(txtProductName.Text.Trim());
            comboBox1_SelectedIndexChanged(sender, e);
        }
    }
}
