using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using System.Data.SqlClient;
using NPOI.SS.UserModel;
using System.IO;
using Common;

namespace 销售管理.查询统计
{
    public partial class 开票信息查询 : 销售管理.UserControlBase
    {
        public 开票信息查询()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mSql="",mDateCondition="",mOperCondition="",mCompanyCondition="";

          //  mSql = "select max(c.username) 销售名称,max(tc.companyname) 客户名称,sum(summoney) 累计销售额,sum(hasInvoice * Price) 已开金额,sum(Invoicing * price) 审核中金额,sum(caninvoice * price) 剩余可开金额 from  (SELECT a.Id,a.username,a.customername , a.SaleDate, d.name as ProductName, a.Price, a.Amount,isnull(f.hasInvoice,0) hasInvoice,isnull(g.Invoicing,0) Invoicing,a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0) caninvoice, a.SumMoney,a.stockoutno FROM dbo.T_SaleDetails a left join T_Products d on a.productName = d.id left join (select saledetailsid,isnull(sum(amount),0) hasInvoice from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status = '财务已开票' group by saledetailsid) f on a. id = f.saledetailsid left join (select saledetailsid,isnull(sum(amount),0) Invoicing from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status like '%等待%' group by saledetailsid) g on g.saledetailsid = a.id where ascii(a.CustomerName) < 123) mResult left join t_customers tc on mResult.customername = tc.id left join T_Users c on mResult.UserName = c.Id where 1=1 {0} {1} {2} group by customername,mresult.username order by mResult.username,customername";
            
            //添加过滤不开票
            mSql = "select max(c.username) 销售名称,max(tc.companyname) 客户名称,sum(summoney) 累计销售额,sum(hasInvoice * Price) 已开金额,sum(Invoicing * price) 审核中金额,sum(caninvoice * price) 剩余可开金额 from  (SELECT a.Id,a.username,a.customername , a.SaleDate, d.name as ProductName, a.Price, a.Amount,isnull(f.hasInvoice,0) hasInvoice,isnull(g.Invoicing,0) Invoicing,a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0) caninvoice, a.SumMoney,a.stockoutno FROM dbo.T_SaleDetails a left join T_Products d on a.productName = d.id left join (select saledetailsid,isnull(sum(amount),0) hasInvoice from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status = '财务已开票' group by saledetailsid) f on a. id = f.saledetailsid left join (select saledetailsid,isnull(sum(amount),0) Invoicing from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status like '%等待%' group by saledetailsid) g on g.saledetailsid = a.id where ascii(a.CustomerName) < 123) mResult left join t_customers tc on mResult.customername = tc.id left join T_Users c on mResult.UserName = c.Id where 1=1 {0} {1} {2} group by customername,mresult.username order by mResult.username,customername";




            if (cbDate.Checked == true)
            {
//                mSql = @"SELECT f.UserName 销售员, a.CompanyName 客户名称, c.summoney 销售额, e.summoney 已开票金额
//FROM T_Customers AS a LEFT OUTER JOIN
//          (SELECT ISNULL(SUM(SumMoney), 0) AS summoney, CustomerName
//         FROM T_SaleDetails AS b where InvoiceDate between  '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + @"' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + @" 23:59:59'
//         GROUP BY CustomerName) AS c ON a.id = c.CustomerName LEFT OUTER JOIN
//          (SELECT ISNULL(SUM(InvoiceMoney), 0) AS summoney, CustomerName
//         FROM T_Invoice AS d  where SaleDate between  '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + @"' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + @" 23:59:59'
//         WHERE (Status NOT LIKE '%不通过%')
//         GROUP BY CustomerName) AS e ON a.id = e.CustomerName LEFT OUTER JOIN
//      T_Users AS f ON a.OperName = f.id where 1=1";
                mDateCondition = string.Format("and saledate between '{0}' and '{1}'",dtpStart.Value.Date.ToString("yyyy-MM-dd"),dtpEnd.Value.Date.ToString("yyyy-MM-dd")+ @" 23:59:59");
            }
            else
            {
//                mSql = @"SELECT f.UserName 销售员, a.CompanyName 客户名称, c.summoney 销售额, e.summoney 已开票金额
//FROM T_Customers AS a LEFT OUTER JOIN
//          (SELECT ISNULL(SUM(SumMoney), 0) AS summoney, CustomerName
//         FROM T_SaleDetails AS b
//         GROUP BY CustomerName) AS c ON a.id = c.CustomerName LEFT OUTER JOIN
//          (SELECT ISNULL(SUM(InvoiceMoney), 0) AS summoney, CustomerName
//         FROM T_Invoice AS d
//         WHERE (Status NOT LIKE '%不通过%')
//         GROUP BY CustomerName) AS e ON a.id = e.CustomerName LEFT OUTER JOIN
//      T_Users AS f ON a.OperName = f.id where 1=1";
                mDateCondition = "";
            }
            if (cmbUsername.Text != "查询所有")
            {
                //mSql += " and a.OperName = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "'";
                mOperCondition = string.Format("and mResult.username={0}",((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id );
            }
            if (txtCustomer.Text != "")
            {
                //mSql += " and a.CompanyName like '%" + txtCustomer.Text.Trim() + "%'";
                mCompanyCondition = string.Format("and 销售名称 like '%{0}%'",txtCustomer.Text.Trim());
            }
            mSql = string.Format(mSql, mDateCondition, mOperCondition, mCompanyCondition);
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvReport.DataSource = null;
                dgvReport.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 开票信息查询_Load(object sender, EventArgs e)
        {
            //获取销售列表
            var mTable1 = new T_UsersTableAdapter().GetSalers();
            foreach (销售管理.DAL.DataSetUsers.T_UsersRow mRow in mTable1.Rows)
            {
                cmbUsername.Items.Add(new Classes.PubClass.MyCmbList(mRow.id, mRow.UserName));
            }
            cmbUsername.Items.Insert(0, "查询所有");
            cmbUsername.SelectedIndex = 0;

            if (!Common.AuthenticateRight.AuthOperation(140401) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUsername.SelectedIndex = cmbUsername.FindStringExact(Classes.PubClass.UserName);
                cmbUsername.Enabled = false;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;

                DataGridView mView = dgvReport;

                //添加标头
                IRow mRow = mSheet.CreateRow(0);
                for (i = 0; i <= mView.Columns.Count - 1; i++)
                {
                    mCell = mRow.CreateCell(i);
                    mCell.SetCellValue(mView.Columns[i].HeaderText);
                    mCell.CellStyle = styleRight;
                }
                //添加内容

                for (i = 1; i <= mView.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i);
                    for (j = 0; j <= mView.Columns.Count - 1; j++)
                    {
                        mCell = mRow.CreateCell(j);

                        if (Classes.PubFunc.IsNumber(Convert.ToString(mView.Rows[i - 1].Cells[j].Value)) == true)
                        {
                            mCell.SetCellValue(Convert.ToDouble(mView.Rows[i - 1].Cells[j].Value));
                        }
                        else
                        {
                            mCell.SetCellValue(Convert.ToString(mView.Rows[i - 1].Cells[j].Value));
                        }
                        mCell.CellStyle = styleRight;

                    }
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = "开票信息-" + DateTime.Now.ToString("yyyyMMddhhmmss");
                if (mDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream mFile = mDialog.OpenFile();
                    mWorkbook.Write(mFile);
                    mFile.Close();
                    MessageBox.Show("保存成功！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
