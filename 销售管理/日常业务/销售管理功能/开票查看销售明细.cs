using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetInvoiceOutStockTableAdapters;
using 销售管理.DAL.DataSetInvoiceTableAdapters;
using System.Data.SqlClient;

namespace 销售管理.日常业务
{
    public partial class 开票查看销售明细 : Form
    {
        public 开票查看销售明细()
        {
            InitializeComponent();
        }
        public DataTable mSelected;
        public long mInvoiceId=-1;
        public int mSubId = -1;
        private void dgvInvoiceDetails_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //if (e.RowIndex > -1)
            //{
            //    //var dtSaleDetails = new T_InvoiceTableAdapter().GetDataById(Convert.ToInt64(dgvInvoiceDetails["ColSaleDetailsId", e.RowIndex]));
            //    //dgvCustomerSaleDetails.DataSource = dtSaleDetails;
            //    string mSql;
            //    mSql = "SELECT a.Id, c.UserName,e.companyname customername, a.SaleDate, d.name as ProductName, a.Price, a.Amount,isnull(f.hasInvoice,0) hasInvoice,isnull(g.Invoicing,0) Invoicing,a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0) caninvoice, a.SumMoney,a.stockoutno FROM dbo.T_SaleDetails a left join T_Users c on a.UserName = c.Id left join T_Products d on a.productName = d.id left join t_customers e on a.customername = e.id left join (select saledetailsid,isnull(sum(amount),0) hasInvoice from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status = '财务已开票' group by saledetailsid) f on a. id = f.saledetailsid left join (select saledetailsid,isnull(sum(amount),0) Invoicing from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status like '%等待%' group by saledetailsid) g on g.saledetailsid = a.id where ascii(a.CustomerName) < 123 and  a.id = " + Convert.ToInt64(dgvInvoiceDetails["ColSaleDetailsId", e.RowIndex].Value).ToString();
            //    SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            //    SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            //    DataTable mTable = new DataTable();
            //    try
            //    {
            //        adapter.Fill(mTable);
            //        dgvCustomerSaleDetails.DataSource = mTable;
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show(ex.Message);
            //        return;
            //    }
            //}
            if (e.RowIndex > -1)
            {
                long mSaleDetailsId = Convert.ToInt64(dgvInvoiceDetails.Rows[e.RowIndex].Cells["ColSaleDetailsId"].Value);
                foreach (DataGridViewRow mRow in dgvCustomerSaleDetails.Rows)
                {
                    if (Convert.ToInt64(mRow.Cells["ColumnId"].Value) == mSaleDetailsId)
                    {
                        mRow.Selected = true;
                        break;
                    }
                }
            }
        }

        private void 开票查看销售明细_Load(object sender, EventArgs e)
        {
            if (mInvoiceId < 0 || mSubId < 0)
            {
                MessageBox.Show("没有销售明细ID和子项ID");
                return;
            }
            //显示开票详细
            var mdtInvoiceDetails = new T_InvoiceOutStockTableAdapter().GetDataByInvoiceIdAndSubId(mInvoiceId, mSubId);
            if (mdtInvoiceDetails.Rows.Count > 0)
            {
                foreach (销售管理.DAL.DataSetInvoiceOutStock.T_InvoiceOutStockRow mRow in mdtInvoiceDetails.Rows)
                {
                    int mIndex = dgvInvoiceDetails.Rows.Add();

                    dgvInvoiceDetails["ColSaleDetailsId", mIndex].Value = mRow.SaleDetailsId;
                    //dgvInvoiceDetails["ColProductName", mIndex].Value = mRow.pr;
                    dgvInvoiceDetails["ColPrice", mIndex].Value = mRow.Price;
                    dgvInvoiceDetails["ColAmount", mIndex].Value = mRow.Amount;
                    dgvInvoiceDetails["ColSumMoney", mIndex].Value = mRow.SumMoney;
                    
                    //dgvInvoiceDetails["ColSaleDate", mIndex].Value = mRow["SaleDate"];
                    //dgvInvoiceDetails["ColStockOutNo", mIndex].Value = mRow["StockOutNo"];
                }
                //dgvInvoiceDetails.SelectedRows[0].Selected = false;
            }
            dgvInvoiceDetails.ClearSelection();
            //显示销售明细
            string mSql;
            mSql = "SELECT a.Id, c.UserName,e.companyname customername, a.SaleDate, d.name as ProductName, a.Price, a.Amount,isnull(f.hasInvoice,0) hasInvoice,isnull(g.Invoicing,0) Invoicing,a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0) caninvoice, a.SumMoney,a.stockoutno FROM dbo.T_SaleDetails a left join T_Users c on a.UserName = c.Id left join T_Products d on a.productName = d.id left join t_customers e on a.customername = e.id left join (select saledetailsid,isnull(sum(amount),0) hasInvoice from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status = '财务已开票' group by saledetailsid) f on a. id = f.saledetailsid left join (select saledetailsid,isnull(sum(amount),0) Invoicing from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status like '%等待%' group by saledetailsid) g on g.saledetailsid = a.id where ascii(a.CustomerName) < 123 and  a.id in (select SaleDetailsId from t_InvoiceOutStock where invoiceId = " + mInvoiceId.ToString() + " and subid=" + mSubId.ToString()+ ")";
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvCustomerSaleDetails.DataSource = mTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            dgvCustomerSaleDetails.ClearSelection();
        }


    }
}
