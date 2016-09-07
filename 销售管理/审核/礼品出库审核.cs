using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetGiftsTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;


namespace 销售管理.审核
{
    public partial class 礼品出库审核 : 销售管理.UserControlBase
    {
        public 礼品出库审核()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql = @"select gso.Id,gso.datadate,un.username userid,un.DepartmentName,cn.companyname customerid,gso.giftid,gso.giftname,gso.giftnum,gso.giftprice,gso.giftsum,gso.status,an.username auditName,gso.auditdate,aa.ed,P.username IntUsedID from t_giftstockout gso left join t_users un on gso.userid = un.id left join t_customers cn on gso.customerid = cn.id left join t_users an on gso.auditid = an.id left join t_users P on gso.IntUsedID = P.id left join 
        (
select isnull(ss.salesum,0) - isnull(gs.GiftSum,0)-isnull(ms.mealsum,0) ed,a.id from t_users a
left join
(select sum(summoney)/200 salesum ,username from T_Saledetails where saledate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') group by username) ss on a.id = ss.username
left join
(select sum(GiftSum) giftsum,userid from t_GiftStockOut where datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','审核未通过','已提交等待领导审核') group by userid) gs on a.id = gs.userid
left join 
(select sum(mealmoney) mealsum,userid from t_meals where  datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','已提交等待领导审核') group by userid) ms on a.id = ms.userid

) aa on gso.userid = aa.id 
where gso.status <> '已删除' {0} {1} {2} {3} {4} {5}";
            string mC1 = "", mC2 = "", mC3 = "", mC4 = "", sDept = "", sUsedEmp = "";

            if (cmbUserName.Text != string.Empty)
            {
                mC1 = "and un.username like '%" + cmbUserName.Text + "%'";
            }
            if (CBoxUsed.Text != string.Empty)
            {
                sUsedEmp = "and P.username like '%" + CBoxUsed.Text + "%'";
            }
            if (cmbCustomers.Text != string.Empty)
            {
                mC2 = "and cn.companyname like '%" + cmbCustomers.Text + "%'";
            }
            if (cmbGifts.Text != string.Empty)
            {
                mC3 = "and gso.giftname like '%" + cmbGifts.Text + "%'";
            }
            if (cmbHasAudit.Text != string.Empty)
            {
                if (cmbHasAudit.Text == "未审核")
                {
                    mC4 = "and gso.status='已提交等待领导审核'";
                }
                else if (cmbHasAudit.Text == "审核未通过")
                {
                    mC4 = "and gso.status='" + cmbHasAudit.Text + "'";
                }
                else //已通过
                {
                    mC4 = "and gso.status not in('审核未通过','已提交等待领导审核')";
                }
            }
            if (CBoxDept.Text != string.Empty)
            {
                sDept = "and un.DepartmentName like '%" + CBoxDept.Text + "%'";
            }
            mSql = string.Format(mSql, mC1, mC2, mC3, mC4, sDept, sUsedEmp);

            dgvExAllocation.DataSource = SqlHelper.GetData(mSql);
            if ((dgvExAllocation.DataSource as DataTable).Rows.Count < 1)
            {
                MessageBox.Show("没有记录");
                return;
            }

           // refresh();
        }

       
       /// <summary>
       /// 刷新页面
       /// </summary>
       private void refresh()
        {
            string mSql = @"select gso.Id,gso.datadate,un.username userid,cn.companyname customerid,gso.giftid,gso.giftname,gso.giftnum,gso.giftprice,gso.giftsum,gso.status,an.username auditName,gso.auditdate,aa.ed,P.username IntUsedID from t_giftstockout gso left join t_users un on gso.userid = un.id left join t_customers cn on gso.customerid = cn.id left join t_users an on gso.auditid = an.id left join t_users P on gso.IntUsedID = P.id left join 
        (
select isnull(ss.salesum,0) - isnull(gs.GiftSum,0)-isnull(ms.mealsum,0) ed,a.id from t_users a
left join
(select sum(summoney)/200 salesum ,username from T_Saledetails where saledate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') group by username) ss on a.id = ss.username
left join
(select sum(GiftSum) giftsum,userid from t_GiftStockOut where datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','审核未通过','已提交等待领导审核') group by userid) gs on a.id = gs.userid
left join 
(select sum(mealmoney) mealsum,userid from t_meals where  datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','已提交等待领导审核') group by userid) ms on a.id = ms.userid

) aa on gso.userid = aa.id 
where gso.status <> '已删除' {0} {1} {2} {3} {4} {5}";
            string mC1 = "", mC2 = "", mC3 = "", mC4 = "", sDept = "", sUsedEmp = "";

            if (cmbUserName.Text != string.Empty)
            {
                mC1 = "and un.username like '%" + cmbUserName.Text + "%'";
            }
            if (CBoxUsed.Text != string.Empty)
            {
                sUsedEmp = "and P.username like '%" + CBoxUsed.Text + "%'";
            }
            if (cmbCustomers.Text != string.Empty)
            {
                mC2 = "and cn.companyname like '%" + cmbCustomers.Text + "%'";
            }
            if (cmbGifts.Text != string.Empty)
            {
                mC3 = "and gso.giftname like '%" + cmbGifts.Text + "%'";
            }
            if (cmbHasAudit.Text != string.Empty)
            {
                if (cmbHasAudit.Text == "未审核")
                {
                    mC4 = "and gso.status='已提交等待领导审核'";
                }
                else if (cmbHasAudit.Text == "审核未通过")
                {
                    mC4 = "and gso.status='" + cmbHasAudit.Text + "'";
                }
                else //已通过
                {
                    mC4 = "and gso.status not in('审核未通过','已提交等待领导审核')";
                }
            }
            if (CBoxDept.Text != string.Empty)
            {
                sDept = "and un.DepartmentName like '%" + CBoxDept.Text + "%'";
            }
            mSql = string.Format(mSql, mC1, mC2, mC3, mC4, sDept, sUsedEmp);

            dgvExAllocation.DataSource = SqlHelper.GetData(mSql);
            if ((dgvExAllocation.DataSource as DataTable).Rows.Count < 1)
            {
                return;
            }


        } 



        private void btnAudit_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认审核通过？", "提示", MessageBoxButtons.YesNo))
            {

                int ret = 0;
                string auditString = "";
                foreach (DataGridViewRow mRow in dgvExAllocation.Rows)
                {
                    if (Convert.ToBoolean(mRow.Cells["ColumnChecked"].Value) == true)
                    {
                        auditString += mRow.Cells["idDataGridViewTextBoxColumn"].Value + ",";
                    }
                }
                auditString = auditString.TrimEnd(',');
                if (auditString == "")
                {
                    MessageBox.Show("没有选择要审核的记录");
                    return;
                }
                //ret = t_ExpenseAllocationTableAdapter.UpdateLeaderBatchAudit("领导审核通过", Classes.PubClass.UserId, "", auditString);
                string mSql = string.Format("UPDATE T_GiftStockOut SET Status = '{0}',AuditId = '{1}', AuditDate = GETDATE()  WHERE Id IN ({2})", "审核已通过", Classes.PubClass.UserId, auditString);
                ret = SqlHelper.ExecuteNonQuery(mSql);
                if (ret > 0)
                {
                    MessageBox.Show("提交成功");

                    //20160906 显示bug修改
                    refresh();

                    //foreach (DataGridViewRow mRow in dgvExAllocation.Rows)
                    //{
                    //    if (Convert.ToBoolean(mRow.Cells["ColumnChecked"].Value) == true)
                    //    {
                    //        dgvExAllocation.Rows.Remove(mRow);
                    //    }
                    //}


                }
                else
                {
                    MessageBox.Show("提交失败");
                }

            }
        }

        private void btnAudit2_Click(object sender, EventArgs e)
        {
            if (DialogResult.Yes == MessageBox.Show("确认审核不通过？", "提示", MessageBoxButtons.YesNo))
            {

                int ret = 0;
                string auditString = "";
                foreach (DataGridViewRow mRow in dgvExAllocation.Rows)
                {
                    if (Convert.ToBoolean(mRow.Cells["ColumnChecked"].Value) == true)
                    {
                        auditString += mRow.Cells["idDataGridViewTextBoxColumn"].Value + ",";
                    }
                }
                auditString = auditString.TrimEnd(',');
                if (auditString == "")
                {
                    MessageBox.Show("没有选择要审核的记录");
                    return;
                }

                string mSql = string.Format("UPDATE T_GiftStockOut SET Status = '{0}',AuditId = '{1}', AuditDate = GETDATE()  WHERE (Id IN ({2}))", "审核未通过", Classes.PubClass.UserId, auditString);
                ret = SqlHelper.ExecuteNonQuery(mSql);
                if (ret > 0)
                {
                    MessageBox.Show("提交成功");

                    //20160906 显示bug修改
                    refresh();

                    //
                    //foreach (DataGridViewRow mRow in dgvExAllocation.Rows)
                    //{
                    //    if (Convert.ToBoolean(mRow.Cells["ColumnChecked"].Value) == true)
                    //    {
                    //        dgvExAllocation.Rows.Remove(mRow);
                    //    }
                    //}
                }
                else
                {
                    MessageBox.Show("提交失败");
                }

            }
        }

        private void 礼品出库审核_Load(object sender, EventArgs e)
        {
            //
            cmbUserName.DisplayMember = "Username";
            cmbUserName.ValueMember = "Id";
           // cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
            cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
            cmbUserName.SelectedIndex = -1;

            CBoxUsed.DisplayMember = "Username";
            CBoxUsed.ValueMember = "Id";
            //CBoxUsed.DataSource = new T_UsersTableAdapter().GetSalers();
            CBoxUsed.DataSource = new T_UsersTableAdapter().GetData();
            CBoxUsed.SelectedIndex = -1;

            CBoxDept.DisplayMember = "VcName";
            //CBoxDept.ValueMember = "IntId";
            CBoxDept.DataSource = SqlHelper.GetData("SELECT DISTINCT DepartmentName VcName FROM T_Users"); ;
            CBoxDept.SelectedIndex = -1;

            cmbHasAudit.SelectedIndex = 0;

            cmbGifts.DisplayMember = "GiftName";
            cmbGifts.ValueMember = "Id";
            cmbGifts.DataSource = new T_GiftsTableAdapter().GetData();
            cmbGifts.SelectedIndex = -1;
        }

        private void cmbUserName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUserName.SelectedIndex == -1)
            {
                cmbCustomers.DataSource = new T_CustomersTableAdapter().GetData();
                cmbCustomers.SelectedIndex = -1;
            }
            else
            {
                cmbCustomers.DataSource = new T_CustomersTableAdapter().GetDataByUserId(Convert.ToInt64(cmbUserName.SelectedValue));
                cmbCustomers.SelectedIndex = -1;
            }
        }
    }
}
