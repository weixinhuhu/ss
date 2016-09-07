using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetCardsTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using Soft.Common;

namespace 销售管理.审核
{
    public partial class 消费卡申请审核 : 销售管理.UserControlBase
    {
        public 消费卡申请审核()
        {
            InitializeComponent();
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            refresh(); 
        }
        /// <summary>
        /// 刷新查询数据
        /// </summary>
        private void refresh() {
            string mSql = @"select ms.Id,ms.datadate,un.username userid,cn.companyname customerid,ms.cardid,ca.cardname cardname,ca.cardbalance,edu.ed,ms.mealmoney,ms.recdate,ms.status,an.username auditid,ms.auditdate,p.DepartmentName,P.username IntUsedID from t_meals ms
left join t_users un on ms.userid = un.id
left join t_customers cn on ms.customerid = cn.id
left join t_cards ca on ms.cardid = ca.id
left join t_users [an] on ms.operid = an.id
left join t_users P on ms.IntUsedID = P.id
left join (select isnull(ss.salesum,0) - isnull(gs.GiftSum,0)-isnull(ms.mealsum,0) ed,a.id from t_users a
left join
(select sum(summoney)/200 salesum ,username from T_Saledetails where saledate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') group by username) ss on a.id = ss.username
left join
(select sum(GiftSum) giftsum,IntUsedID from t_GiftStockOut where datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','审核未通过','已提交等待领导审核') group by IntUsedID) gs on a.id = gs.IntUsedID
left join 
(select sum(mealmoney) mealsum,IntUsedID from t_meals where  datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','已提交等待领导审核') group by IntUsedID) ms on a.id = ms.IntUsedID
) edu on ms.IntUsedID = edu.id
where ms.status <> '已删除' {0} {1} {2} {3} {4} {5}";//
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
            if (cmbCards.Text != string.Empty)
            {
                mC3 = "and ca.cardname like '%" + cmbCards.Text + "%'";
            }
            if (cmbHasAudit.Text != string.Empty)
            {
                //dgvExAllocation.Columns["ColumnChecked"].Visible = false;
                if (cmbHasAudit.Text == "未审核")
                {
                    mC4 = "and ms.status='已提交等待领导审核'";
                    //dgvExAllocation.Columns["ColumnChecked"].Visible = true;
                }
                else if (cmbHasAudit.Text == "审核未通过")
                {
                    mC4 = "and ms.status='" + cmbHasAudit.Text + "'";
                }
                else //已通过
                {
                    mC4 = "and ms.status not in('审核未通过','已提交等待领导审核')";
                }
            }
            if (CBoxDept.Text != string.Empty)
            {
                sDept = "and P.DepartmentName like '%" + CBoxDept.Text + "%'";
            }
            mSql = string.Format(mSql, mC1, mC2, mC3, mC4, sDept, sUsedEmp);

            var mTable = SqlHelper.GetData(mSql);

            dgvExAllocation.DataSource = mTable;
            if (mTable.Rows.Count < 1)
            {
                Dlg.ShowOKInfo("没有记录");
                return;
            }
        }

        private void 消费卡申请审核_Load(object sender, EventArgs e)
        {
            cmbUserName.DisplayMember = "Username";
            cmbUserName.ValueMember = "Id";
         //   cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
            cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
            cmbUserName.SelectedIndex = -1;

            CBoxUsed.DisplayMember = "Username";
            CBoxUsed.ValueMember = "Id";
         //   CBoxUsed.DataSource = new T_UsersTableAdapter().GetSalers();
            CBoxUsed.DataSource = new T_UsersTableAdapter().GetData();
            CBoxUsed.SelectedIndex = -1;

            CBoxDept.DisplayMember = "VcName";
            //CBoxDept.ValueMember = "IntId";
            CBoxDept.DataSource = SqlHelper.GetData("SELECT DISTINCT DepartmentName VcName FROM T_Users"); ;
            CBoxDept.SelectedIndex = -1;

            cmbHasAudit.SelectedIndex = 0;

            cmbCards.DisplayMember = "CardName";
            cmbCards.ValueMember = "Id";
            cmbCards.DataSource = new T_CardsTableAdapter().GetData();
            cmbCards.SelectedIndex = -1;
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
                    Dlg.ShowErrorInfoAndHelp("没有选择要审核的记录");
                    return;
                }
                //ret = t_ExpenseAllocationTableAdapter.UpdateLeaderBatchAudit("领导审核通过", Classes.PubClass.UserId, "", auditString);
                string mSql = string.Format("UPDATE T_Meals SET Status = '{0}',AuditId = '{1}', AuditDate = GETDATE()  WHERE Id IN ({2})", "审核已通过", Classes.PubClass.UserId, auditString);
                ret = SqlHelper.ExecuteNonQuery(mSql);
                if (ret > 0)
                {
                    Dlg.ShowOKInfo("保存成功");
                    //修改页面显示2016.9.6
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
                    Dlg.ShowErrorInfo("保存失败");
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
                    Dlg.ShowErrorInfoAndHelp("没有选择要审核的记录");
                    return;
                }

                string mSql = string.Format("UPDATE T_Meals SET Status = '{0}',AuditId = '{1}', AuditDate = GETDATE()  WHERE (Id IN ({2}))", "审核未通过", Classes.PubClass.UserId, auditString);
                ret = SqlHelper.ExecuteNonQuery(mSql);
                if (ret > 0)
                {
                    Dlg.ShowOKInfo("保存成功!");

                    //修改页面显示2016.9.6
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
                    Dlg.ShowErrorInfo("保存失败");
                }

            }
        }


    }
}
