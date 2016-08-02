using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetStockOutTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using System.Data.SqlClient;

namespace 销售管理.日常业务
{
    public partial class 出库申请 : 销售管理.UserControlBase
    {
        public 出库申请()
        {
            InitializeComponent();
        }

        private void 出库申请_Load(object sender, EventArgs e)
        {
            dgvStockOut.DataSource = new T_StockOutTableAdapter().GetDataByUserId(Classes.PubClass.UserId);
            if (Classes.PubClass.UserRight == "领导" || Classes.PubClass.UserRight == "超级管理员" || Classes.PubClass.UserRight == "商务经理" || Classes.PubClass.UserRight == "商务助理")
            {
                cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.SelectedIndex = -1;
                label1.Visible = true;
                cmbUserName.Visible = true;
                llAddStockOut.Visible = true;

            }
            else
            {
                //ColModify.Visible = false;
            }
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql = @"SELECT a.Id, b.UserName, c.CompanyName AS CustomerName, a.SaleDate, 
      g.Name as ProductName, a.Amount, a.Price, a.SumMoney, a.SettlementModes, a.CityID, 
      a.SubmitDate, d.UserName AS BusinessAudit, a.BusinessDate, 
      e.UserName AS LeaderAudit, a.LeaderDate, f.UserName AS KeeperAudit, 
      a.KeeperDate, a.StockOutNo, a.Status
FROM T_StockOut AS a LEFT OUTER JOIN
      T_Users AS b ON a.UserName = b.id LEFT OUTER JOIN
      T_Customers AS c ON a.CustomerName = c.id LEFT OUTER JOIN
      T_Users AS d ON a.BusinessAudit = d.id LEFT OUTER JOIN
      T_Users AS e ON a.LeaderAudit = e.id LEFT OUTER JOIN
      T_Users AS f ON a.KeeperAudit = f.id left outer join
      T_Products as g on a.ProductName = g.id
WHERE (a.UserName = " + Classes.PubClass.UserId + ") ";

            if (txtCusName.Text.Trim() != string.Empty)
            {
                mSql += " and c.CustomerName like '%" + txtCusName.Text.Trim() + "%'";
            }
            if(txtProductName.Text.Trim() != string.Empty)
            {
                mSql += " and g.name like '%"+ txtProductName.Text.Trim() +"%'";
            }

            mSql += " order by SubmitDate desc";
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvStockOut.DataSource = mTable;
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

        private void llAddStockOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (出库单详细 mForm = new 出库单详细())
            {
                mForm.ShowDialog();
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
