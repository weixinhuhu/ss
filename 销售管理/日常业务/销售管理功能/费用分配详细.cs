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
    public partial class 费用分配详细 : Form
    {
        public 费用分配详细()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string mSql;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);

            mSql = @"SELECT Id, Month, UserName, TableNo, CustomerName, ProjectName, ProductName, ProductType, Amount, DeliverPrice, DeliverSum, SalePrice, SaleSum, DepartSum, SaleWages, CommissionPrice, CommissionSum, SaleComission, AgentPrice, AgentSum, AgentCommission, IsPaid, PaidDate, Status, BusinessAudit, BusinessDate, BusinessRemark, FinanceAudit, FinanceDate, FinanceRemark, LeaderAudit, LeaderDate, LeaderRemark, RecDate, SaleDetailsId FROM dbo.T_ExpenseAllocation where status = '已提交等待商务审核'";

            

            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();

            try
            {
                adapter.Fill(mTable);
                dgvExAllocation.DataSource = mTable;
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
    }
}
