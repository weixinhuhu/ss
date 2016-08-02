using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetUsersTableAdapters;
using Common;

namespace 销售管理.日常业务
{
    public partial class 申请开票 : 销售管理.UserControlBase
    {
        public 申请开票()
        {
            InitializeComponent();
        }

        private void llAddStockOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (申请开票详细 mForm = new 申请开票详细())
            {
                mForm.ShowDialog();
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql;

            mSql = @"SELECT a.Id , b.UserName UserName, c.CompanyName AS CustomerName, a.InvoiceNo,
      a.InvoiceContent, a.InvoiceDate, a.InvoiceType, a.InvoiceMoney, a.SubmitDate, 
      d.UserName AS BusinessAudit, a.BusinessDate, e.UserName AS FinanceAudit, 
      a.FinanceDate, a.Status
FROM T_Invoice AS a LEFT OUTER JOIN
      T_Users AS b ON a.UserName = b.id LEFT OUTER JOIN
      T_Customers AS c ON a.CustomerName = c.id LEFT OUTER JOIN
      T_Users AS d ON a.BusinessAudit = d.id LEFT OUTER JOIN
      T_Users AS e ON a.FinanceAudit = e.id where 1=1 ";

            if (Classes.PubClass.UserRight != "领导" && Classes.PubClass.UserRight != "超级管理员" && Classes.PubClass.UserRight != "商务经理" && Classes.PubClass.UserRight != "商务助理")
            {
                mSql += @" and a.UserName='" + Classes.PubClass.UserId + "'";
            }
            else if (cmbUserName.Text.Trim() != "")
            {
                mSql += " and a.UserName = '" + cmbUserName.SelectedValue + "'";

            }

            if (txtCusName.Text.Trim() != "")
            {
                mSql += " and c.CompanyName like '%" + txtCusName.Text.Trim() + "%'";
            }
            
            if (dtp1.Checked == true)
            {
                mSql += " and a.InvoiceDate between '" + dtp1.Value.Date + "' and '" + dtp2.Value.Date +"'";
            }

            if (txtInoviceNo.Text.Trim() != "")
            {
                mSql += " and a.InvoiceNo = '" + txtInoviceNo.Text.Trim() + "'";
            }
            if (cmbStatus.Text == "已通过")
            {
                mSql += " and a.status = '财务已开票'";
            }
            if (cmbStatus.Text == "未通过")
            {
                mSql += " and a.status like '%不通过%'";
            }
            if (cmbStatus.Text == "审核中")
            {
                mSql += " and a.status like '%等待%'";
            }

            mSql += " order by SubmitDate desc";
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
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
                //MessageBox.Show("查询成功");
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex <0)
            {
                return;
            }
            if (e.ColumnIndex == dgvInvoice.Columns["ColModify"].Index)
            {
                using (申请开票详细 mForm = new 申请开票详细())
                {
                    mForm.isModify = true;
                    mForm.mId = Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.ShowDialog();
                }
            }
        }

        private void 申请开票_Load(object sender, EventArgs e)
        {
            dgvInvoice.GetType().GetProperty("DoubleBuffered", System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic).SetValue(dgvInvoice, true, null);
            //cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
            //cmbUserName.DisplayMember = "UserName";
            //cmbUserName.SelectedIndex = -1;
            if (!Common.AuthenticateRight.AuthOperation(110401) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.ValueMember = "Id";
                cmbUserName.SelectedIndex = -1;
                label1.Visible = true;
                cmbUserName.Visible = true;
                
            }
        }

        private void dgvInvoice_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (申请开票详细 mForm = new 申请开票详细())
            {
                mForm.mId = Convert.ToInt64(dgvInvoice.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                mForm.ShowDialog();
            }
        }
    }
}
