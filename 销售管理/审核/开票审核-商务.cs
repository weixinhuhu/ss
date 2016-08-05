using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetInvoiceTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 开票审核_商务 : 销售管理.UserControlBase
    {
        public 开票审核_商务()
        {
            InitializeComponent();
        }

        private void 开票审核_商务_Load(object sender, EventArgs e)
        {
            dgvInvoice.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dgvInvoice, true, null);
            cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.SelectedIndex = -1;
            cmbHasAudit.SelectedIndex = 0;
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
                mSql += " where a.status = '已提交等待商务审核'";
                dgvInvoice.Columns["ColAudit"].Visible = true;
                dgvInvoice.Columns["ColAudit1"].Visible = true;
            }
            else
            {
                //if (Classes.PubClass.UserRight == "领导")
                //{
                //    mSql += " where a.businessAudit is not null";
                //}
                //else
                //{
                //    mSql += " where a.businessAudit ='" + Classes.PubClass.UserId + "'";
                //}
                mSql += " where a.businessAudit is not null";
                dgvInvoice.Columns["ColAudit"].Visible = false;
                dgvInvoice.Columns["ColAudit1"].Visible = false;
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

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == dgvInvoice.Columns["ColAudit"].Index)
                {
                    if (DialogResult.Yes == MessageBox.Show("确认审核通过？", "提示", MessageBoxButtons.YesNo))
                    {
                        int ret = new T_InvoiceTableAdapter().UpdateBusinessAudit(Classes.PubClass.UserId, "商务已审核等待财务审核", Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
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
                if (e.ColumnIndex == dgvInvoice.Columns["ColAudit1"].Index)
                {
                    if (DialogResult.Yes == MessageBox.Show("确认审核不通过？", "提示", MessageBoxButtons.YesNo))
                    {
                       
                        int ret =new T_InvoiceTableAdapter().UpdateBusinessAudit( Classes.PubClass.UserId, "商务审核不通过", Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
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
    }
}
