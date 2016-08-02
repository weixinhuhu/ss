using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetSaleDetailsTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using Common;

namespace 销售管理.日常业务
{
    public partial class 销售明细管理 : 销售管理.UserControlBase
    {
        public 销售明细管理()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql;

            mSql = @"SELECT a.Id, c.UserName,e.companyname customername, e.CompanyName, a.SaleMonth, a.SaleDate, d.name as ProductName, a.Amount, a.Price, a.SumMoney, a.SettlementModes, a.ExpenseAllocation, a.MakeInvoice, a.SubmitDate, a.InvoiceContent, a.InvoiceMonth, a.InvoiceDate, a.InvoiceType, a.InvoiceNo,b.TableNo,b.status exstatus,isnull(f.hasInvoice,0) hasInvoice,isnull(g.Invoicing,0) Invoicing,a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0) caninvoice,a.stockoutno FROM dbo.T_SaleDetails a left join T_Users c on a.UserName = c.Id left join T_ExpenseAllocation b on a.ExpenseAllocation=b.Id left join T_Products d on a.productName = d.id left join t_customers e on a.customername = e.id left join (select saledetailsid,isnull(sum(amount),0) hasInvoice from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status = '财务已开票' group by saledetailsid) f on a. id = f.saledetailsid left join (select saledetailsid,isnull(sum(amount),0) Invoicing from t_invoiceoutstock a left join t_invoice b on a.invoiceid = b.id where b.status like '%等待%' group by saledetailsid) g on g.saledetailsid = a.id where ascii(a.CustomerName) < 123 and  1=1 ";

            if (!Common.AuthenticateRight.AuthOperation(110301)&& Common.CommonClass.SttUser.blSuperUser==false)
            {
                mSql += @" and a.UserName='" + Classes.PubClass.UserId + "'";
            }
            else if (cmbUserName.Text.Trim() != "")
            {
                mSql += " and c.UserName like '%" + cmbUserName.Text.Trim() + "%'";

            }

            if (txtCusName.Text.Trim() != "")
            {
                mSql += " and e.CompanyName like '%" + txtCusName.Text.Trim() + "%'";
            }
            //if (txtMonth.Text.Trim() != "")
            //{
            //    mSql += " and a.SaleMonth = '" + txtMonth.Text.Trim() + "'";
            //}
            if (dtp1.Checked == true)
            {
                mSql += " and a.SaleDate between '" + dtp1.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtp2.Value.Date.ToString("yyyy-MM-dd") + " 23:59:59'";
            }
            if (txtProductName.Text.Trim() != "")
            {
                mSql += " and d.Name like '%" + txtProductName.Text.Trim() + "%'";
            }
            if (txtStockNo.Text.Trim() != "")
            {
                mSql += " and a.StockOutNo = '" + txtStockNo.Text.Trim() + "'";
            }
            if (cmbInvoice.Text != "")
            {
                //添加不开票选项
                if (cmbInvoice.Text == "不开票")
                    mSql += "and a.InvoiceFlag='不开票'";
               
                if (cmbInvoice.Text == "未开票")
                    mSql += " and a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0)>0 ";

                if (cmbInvoice.Text == "已开票")
                    mSql += "  and a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0)=0 ";

                //if (cmbInvoice.Text == "未开票")
                //    mSql += " and a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0)>0";
                //else
                //    mSql += " and a.amount - isnull(f.hasinvoice,0) - isnull(g.invoicing,0)=0";

                
            }

            switch (cmbStatus.Text)
            {
                case "全部":
                    break;
                case "未完成":
                    mSql += " and (b.status is null or b.status ='' or b.status like '%不通过%')";
                    break;
                case "审核中":
                    mSql += " and (b.status like '%等待%')";
                    break;
                case "已完成":
                    mSql += " and (b.status = '领导审核通过')";
                    break;
            }
            //mSql += " order by saledate desc";
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            //dgvSaleDetails.DataSource = tSaleDetailsBindingSource;
            dgvNav1.Conn = conn;
            dgvNav1.OrderField = "saledate";
            dgvNav1.OrderDirection = "desc";
            // dgvNav1.PrimaryKey = "a.Id";
            dgvNav1.MyBs = tSaleDetailsBindingSource;
            dgvNav1.OriginSql = mSql;
            //SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            //DataTable mTable = new DataTable();
            //try
            //{
            //    adapter.Fill(mTable);
            //    dgvSaleDetails.DataSource = mTable;
            //    if (mTable.Rows.Count < 1)
            //    {
            //        MessageBox.Show("没有记录");
            //        return;
            //    }
            //    //MessageBox.Show("查询成功");
            //    return;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}
        }

        private void 销售明细管理_Load(object sender, EventArgs e)
        {
            dgvSaleDetails.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dgvSaleDetails, true, null);

            cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "id";
            cmbUserName.SelectedIndex = -1;
            if (!Common.AuthenticateRight.AuthOperation(110301) && !CommonClass.SttUser.blSuperUser)
            {

                cmbUserName.SelectedValue = Classes.PubClass.UserId;
                cmbUserName.Enabled = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110302) && !CommonClass.SttUser.blSuperUser)
            {
                dgvNav1.AddNewItem.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110303) && !CommonClass.SttUser.blSuperUser)
            {
                ColModify.Visible = false;
            }
            DateTime dt = DateTime.Now;
            dtp1.Value = dt.AddMonths(-dt.Month + 1).AddDays(-dt.Day + 1);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (销售明细录入 mForm = new 销售明细录入())
            {
                mForm.ShowDialog();
            }
        }

        private void dgvSaleDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == dgvSaleDetails.Columns["ColModify"].Index && Classes.PubClass.UserStatus == "正常")
                {
                    if (dgvSaleDetails.Rows[e.RowIndex].Cells["expenseStatus"].Value.ToString() == "领导审核通过")
                    {
                        MessageBox.Show("领导审核通过的订单不能修改");
                        return;
                    }
                    销售明细维护 mForm = new 销售明细维护();
                    mForm.mId = Convert.ToInt64(dgvSaleDetails.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.ShowDialog();

                }
                if (e.ColumnIndex == dgvSaleDetails.Columns["TableNo"].Index && Classes.PubClass.UserStatus == "正常")
                {
                    if (dgvSaleDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString() == "申请费用分配")
                    {
                        using (申请费用分配 mForm = new 申请费用分配())
                        {
                            mForm.mRow = dgvSaleDetails.Rows[e.RowIndex];
                            if (mForm.ShowDialog() == DialogResult.OK)
                            {
                                int mIndex = dgvSaleDetails.FirstDisplayedScrollingRowIndex; //记录当前第一行
                                btnSerch_Click(sender, e);
                                dgvSaleDetails.FirstDisplayedScrollingRowIndex = mIndex; //还原当前第一行
                            }
                        }
                    }
                    else
                    {
                        //MessageBox.Show(dgvSaleDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].FormattedValue.ToString());
                        using (申请费用分配 mForm = new 申请费用分配())
                        {
                            mForm.isModify = true;
                            mForm.mRow = dgvSaleDetails.Rows[e.RowIndex];
                            mForm.ExId = Convert.ToInt64(dgvSaleDetails.Rows[e.RowIndex].Cells["ExpenseAllocation"].Value);

                            if (mForm.ShowDialog() == DialogResult.OK)
                            {
                                btnSerch_Click(sender, e);
                            }

                            //  mForm.ShowDialog();
                        }
                    }
                }
                if (e.ColumnIndex == dgvSaleDetails.Columns["ColPrint"].Index && Classes.PubClass.UserStatus == "正常")
                {
                    string mCompanyName = "651984618945316891318";
                    int mCount = 0;
                    foreach (DataGridViewRow mRow in dgvSaleDetails.Rows)
                    {
                        if (Convert.ToBoolean(mRow.Cells["ColPrint"].Value) == true)
                        {
                            mCompanyName = mRow.Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();
                            mCount++;
                        }

                    }
                    if (mCount >= 20)
                    {
                        MessageBox.Show("选中的个数不能超过20个");
                        return;
                    }
                    if (mCompanyName != "651984618945316891318" && Convert.ToString(dgvSaleDetails.Rows[e.RowIndex].Cells["customerNameDataGridViewTextBoxColumn"].Value) != mCompanyName)
                    {
                        DataGridViewCheckBoxCell mCell = dgvSaleDetails[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                        mCell.EditingCellFormattedValue = false;
                        mCell.EditingCellValueChanged = true;
                        mCell.Value = mCell.FormattedValue;
                        MessageBox.Show("与已选择的公司名称不一致");
                    }
                    else
                    {
                        DataGridViewCheckBoxCell mCell = dgvSaleDetails[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                        mCell.EditingCellFormattedValue = bool.Parse(mCell.EditedFormattedValue.ToString());
                        mCell.EditingCellValueChanged = true;
                        mCell.Value = mCell.FormattedValue;
                    }
                }
                //if (e.ColumnIndex == 2)
                //{
                //    if (dgvSaleDetails.Rows[e.RowIndex].Cells["operNameDataGridViewTextBoxColumn"].Value.ToString() == Classes.PubClass.LoginName)
                //    {
                //        if (MessageBox.Show("确认删除该客户资料？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                //        {
                //            long mId = Convert.ToInt64(dgvSaleDetails.Rows[e.RowIndex].Cells[0].Value);
                //            int ret = new T_SaleDetailsTableAdapter().DeleteById(mId);
                //            if (ret > 0)
                //            {
                //                dgvSaleDetails.Rows.RemoveAt(e.RowIndex);
                //            }
                //            else
                //            {
                //                MessageBox.Show("删除失败");
                //            }

                //        }
                //    }

                //}
            }
        }

        private void dgvSaleDetails_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            using (打印收货单 mForm = new 打印收货单())
            {
                //mForm.mRow = dgvSaleDetails.Rows[e.RowIndex];
                //mForm.ShowDialog();
                mForm.mDataTable = new DataTable();
                mForm.mDataTable.Columns.Add("公司名称");
                mForm.mDataTable.Columns.Add("产品名称");
                mForm.mDataTable.Columns.Add("规格型号");
                mForm.mDataTable.Columns.Add("数量");

                foreach (DataGridViewRow mRow in dgvSaleDetails.Rows)
                {
                    if (Convert.ToBoolean(mRow.Cells["ColPrint"].Value) == true)
                    {
                        DataRow mDR = mForm.mDataTable.Rows.Add();
                        mDR["公司名称"] = mRow.Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();
                        mDR["产品名称"] = mRow.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
                        mDR["数量"] = mRow.Cells["amountDataGridViewTextBoxColumn"].Value.ToString();
                    }
                }

                if (mForm.mDataTable.Rows.Count < 1)
                {
                    MessageBox.Show("必须选择一行或多行");
                    return;
                }
                mForm.ShowDialog();
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            using (销售明细录入 mForm = new 销售明细录入())
            {
                mForm.ShowDialog();
            }
        }
    }
}
