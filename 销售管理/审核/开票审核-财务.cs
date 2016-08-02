using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetInvoiceTableAdapters;
using NPOI.SS.UserModel;
using System.IO;

namespace 销售管理.日常业务
{
    public partial class 开票审核_财务 : 销售管理.UserControlBase
    {
        public 开票审核_财务()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            mSql = @"SELECT a.Id, b.UserName AS UserName, c.CompanyName AS CustomerName, 
      a.InvoiceContent, a.InvoiceDate, a.InvoiceType, a.InvoiceMoney, a.SubmitDate, 
      d.UserName AS BusinessAudit, a.BusinessDate, e.UserName AS FinanceAudit, 
      a.FinanceDate, a.Status, a.InvoiceNo
FROM T_Invoice AS a LEFT OUTER JOIN
      T_Users AS b ON a.UserName = b.id LEFT OUTER JOIN
      T_Customers AS c ON a.CustomerName = c.id LEFT OUTER JOIN
      T_Users AS d ON a.BusinessAudit = d.id LEFT OUTER JOIN
      T_Users AS e ON a.FinanceAudit = e.id";
            if (cmbHasAudit.Text == "未审核")
            {
                mSql += " where a.status = '商务已审核等待财务审核'";
                dgvInvoice.Columns["ColAudit"].Visible = true;
                dgvInvoice.Columns["ColAudit1"].Visible = true;
                ColCancel.Visible = false;
            }
            else
            {
                //if (Classes.PubClass.UserRight == "领导")
                //{
                //    mSql += " where a.FinanceAudit is not null";
                //}
                //else
                //{
                //    mSql += " where a.FinanceAudit ='" + Classes.PubClass.UserId + "'";
                //}
                mSql += " where a.FinanceAudit is not null";
                dgvInvoice.Columns["ColAudit"].Visible = false;
                dgvInvoice.Columns["ColAudit1"].Visible = false;
                ColCancel.Visible = true;
            }

            if (cmbUserName.Text != "")
            {
                mSql += " and b.username like '%" + cmbUserName.Text + "%'";
            }

            if (txtCustomerName.Text != "")
            {
                mSql += " and c.CompanyName like '%" + txtCustomerName.Text + "%'";
            }
            if (dtp1.Checked == true)
            {
                mSql += " and datediff(d,a.submitDate,'" + dtp1.Value.Date.ToString("yyyy/MM/dd") + "') =0";
            }

            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            if (cmbHasAudit.Text == "已审核")
            {
                ColModify.Visible = true;
            }
            else
            {
                ColModify.Visible = false;
            }

            try
            {
                adapter.Fill(mTable);
                dgvInvoice.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void 开票审核_财务_Load(object sender, EventArgs e)
        {
            dgvInvoice.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dgvInvoice, true, null);
            cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.SelectedIndex = -1;
            cmbHasAudit.SelectedIndex = 0;
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvInvoice.Columns["ColAudit"].Index)
                {
                    using (var mForm = new 开票审核_输入发票号())
                    {
                        if (DialogResult.OK == mForm.ShowDialog())
                        {
                            string InvoiceNo = mForm.txtInvoiceNo.Text.Trim();
                            int ret = new T_InvoiceTableAdapter().UpdateFinanceAudit("财务已开票", Classes.PubClass.UserId, InvoiceNo, Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                            if (ret > 0)
                            {
                                MessageBox.Show("提交成功");
                                dgvInvoice.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show("提交失败");
                            }
                        }
                    }
                }
                if (e.ColumnIndex == dgvInvoice.Columns["ColAudit1"].Index)
                {
                    if (DialogResult.Yes == MessageBox.Show("确认审核不通过？", "提示", MessageBoxButtons.YesNo))
                    {

                        int ret = new T_InvoiceTableAdapter().UpdateFinanceAudit("财务审核不通过", Classes.PubClass.UserId, null,Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                        if (ret > 0)
                        {
                            MessageBox.Show("提交成功");
                            dgvInvoice.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("提交失败");
                        }

                    }
                }
                if (e.ColumnIndex == dgvInvoice.Columns["ColModify"].Index)
                {
                    using (var mForm = new 开票审核_输入发票号())
                    {
                        if (DialogResult.OK == mForm.ShowDialog())
                        {
                            int ret = new T_InvoiceTableAdapter().UpdateInvoiceNo(mForm.txtInvoiceNo.Text.Trim(),Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                            if (ret > 0)
                            {
                                MessageBox.Show("提交成功");
                            }
                            else
                            {
                                MessageBox.Show("提交失败");
                            }
                        }
                    }
                }
                if (e.ColumnIndex == ColCancel.Index)
                {
                    if (MessageBox.Show("确定作废吗?", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    {
                        int ret = new T_InvoiceTableAdapter().UpdateFinanceAudit("发票作废", Classes.PubClass.UserId, dgvInvoice.Rows[e.RowIndex].Cells[invoiceNoDataGridViewTextBoxColumn.Index].Value.ToString(), Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                        if (ret > 0)
                        {
                            MessageBox.Show("提交成功");
                            btnSerch.PerformClick();
                            //dgvInvoice.Rows.RemoveAt(e.RowIndex);
                        }
                        else
                        {
                            MessageBox.Show("提交失败");
                        }
                    }
                }
                //if (e.ColumnIndex == dgvInvoice.Columns["ColCombine"].Index && Classes.PubClass.UserStatus == "正常")
                //{
                //    string mCompanyName = "651984618945316891318";
                //    int mCount = 0;
                //    foreach (DataGridViewRow mRow in dgvInvoice.Rows)
                //    {
                //        if (Convert.ToBoolean(mRow.Cells["ColPrint"].Value) == true)
                //        {
                //            mCompanyName = mRow.Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();
                //            mCount++;
                //        }

                //    }
                //    if (mCount >= 20)
                //    {
                //        MessageBox.Show("选中的个数不能超过20个");
                //        return;
                //    }
                //    if (mCompanyName != "651984618945316891318" && Convert.ToString(dgvInvoice.Rows[e.RowIndex].Cells["customerNameDataGridViewTextBoxColumn"].Value) != mCompanyName)
                //    {
                //        DataGridViewCheckBoxCell mCell = dgvInvoice[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                //        mCell.EditingCellFormattedValue = false;
                //        mCell.EditingCellValueChanged = true;
                //        mCell.Value = mCell.FormattedValue;
                //        MessageBox.Show("与已选择的公司名称不一致");
                //    }
                //    else
                //    {
                //        DataGridViewCheckBoxCell mCell = dgvInvoice[e.ColumnIndex, e.RowIndex] as DataGridViewCheckBoxCell;
                //        mCell.EditingCellFormattedValue = bool.Parse(mCell.EditedFormattedValue.ToString());
                //        mCell.EditingCellValueChanged = true;
                //        mCell.Value = mCell.FormattedValue;
                //    }
                //}
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                using (申请开票详细 mForm = new 申请开票详细())
                {
                    mForm.mId = Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.ShowDialog();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Classes.ExcelDeport.InvoiceDeport(dgvInvoice);
        }
    }
}
