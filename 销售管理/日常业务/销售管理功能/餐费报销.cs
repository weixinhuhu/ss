using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetCardsTableAdapters;
using System.Data.SqlClient;
using Common;
using 销售管理.DAL.DataSetMealsTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 餐费报销 : 销售管理.UserControlBase
    {
        public 餐费报销()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            try
            {
//                string mSql = @"select ms.Id,ms.datadate,ms.backdate,un.username userid,cn.companyname customerid,ms.cardid,ca.cardname cardname,ms.mealmoney,ms.recdate,ms.status,op.username operid from t_meals ms
//left join t_users un on ms.userid = un.id
//left join t_customers cn on ms.customerid = cn.id
//left join t_cards ca on ms.cardid = ca.id
//left join t_users [op] on ms.operid = op.id
//left join (select tu.id, (isnull(ss.salesum,0) - isnull(gs.GiftSum,0)-isnull(ms.mealsum,0)) ed from t_users tu 
//left join(select isnull(sum(summoney)/200,0) salesum,username from T_Saledetails where saledate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') group by username) ss on tu.id = ss.username 
//left join(select isnull(sum(GiftSum),0) giftsum,userid from t_GiftStockOut where datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','审核未通过') group by userid) gs on tu.id = gs.userid 
//left join(select isnull(sum(mealmoney),0) mealsum,userid from t_meals where  datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status <>'已删除' group by userid) ms on tu.id=ms.userid 
//where tu.operright ='销售') edu on ms.userid = edu.id
//where ms.status <> '已删除' {0} {1} {2} {3} {4}";


                //添加部门字段  2015.5.11 wx
                string mSql = @"select ms.Id,ms.datadate,ms.backdate,un.username userid,un.DepartmentName DepartmentName,cn.companyname customerid,ms.cardid,ca.cardname cardname,ms.mealmoney,ms.recdate,ms.status,op.username operid,P.username IntUsedID from t_meals ms
left join t_users un on ms.userid = un.id
left join t_customers cn on ms.customerid = cn.id
left join t_cards ca on ms.cardid = ca.id
left join t_users [op] on ms.operid = op.id
LEFT JOIN T_Users P ON ms.IntUsedID=P.id
left join (select tu.id, (isnull(ss.salesum,0) - isnull(gs.GiftSum,0)-isnull(ms.mealsum,0)) ed from t_users tu 
left join(select isnull(sum(summoney)/200,0) salesum,username from T_Saledetails where saledate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') group by username) ss on tu.id = ss.username 
left join(select isnull(sum(GiftSum),0) giftsum,userid from t_GiftStockOut where datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','审核未通过') group by userid) gs on tu.id = gs.userid 
left join(select isnull(sum(mealmoney),0) mealsum,userid from t_meals where  datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status <>'已删除' group by userid) ms on tu.id=ms.userid 
where tu.operright ='销售') edu on ms.userid = edu.id
where ms.status <> '已删除' {0} {1} {2} {3} {4} {5} {6}";

                string mCUser = "", mCCustomer = "", mCCard = "", mCDate = "", mStatus = "", mDepartmentName = "", sUsedEmp = "";

                if (cmbUsers.Text != string.Empty)
                {
                    mCUser = "and un.username like'%" + cmbUsers.Text + "%'";
                }
                if (CBoxUsed.Text != string.Empty)
                {
                    sUsedEmp = "and P.username like'%" + CBoxUsed.Text + "%'";
                }
                if (cmbCustomers.Text != string.Empty)
                {
                    mCCustomer = "and cn.companyname like'%" + cmbCustomers.Text + "%'";
                }
                if (cmbCards.Text != string.Empty)
                {
                    mCCard = "and ms.cardid =" + cmbCards.SelectedValue;
                }
                if (dtpStart.Checked == true)
                {
                    mCDate = "and ms.datadate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd") + "'";
                }
                if (cmbStatus.Text != string.Empty)
                {
                    mStatus = "and ms.status ='"+ cmbStatus.Text +"'";
                }

                if (CmbDepartmentName.Text != string.Empty)
                {
                    mDepartmentName = "and un.DepartmentName ='" + CmbDepartmentName.Text + "'";
                }

                mSql = string.Format(mSql, mCUser, mCCustomer, mCCard, mCDate, mStatus, mDepartmentName, sUsedEmp);
                DataTable mTable = SqlHelper.GetData(mSql);
                DataRow mRow = mTable.NewRow();
                mRow["mealmoney"] = mTable.Compute("sum(mealmoney)", "true");

                mTable.Rows.Add(mRow);


                dgvGiftStockOut.DataSource = mTable;

                dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColDel"] = new DataGridViewTextBoxCell();
                dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColDel"].Value = "总计";

                dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColModify"] = new DataGridViewTextBoxCell();
                dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColModify"].Value = "";

                dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColGetCard"] = new DataGridViewTextBoxCell();
                dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColGetCard"].Value = "";

                dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColBackCard"] = new DataGridViewTextBoxCell();
                dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColBackCard"].Value = "";

                if ((dgvGiftStockOut.DataSource as DataTable).Rows.Count < 0)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }


        }

        private void 餐费报销_Load(object sender, EventArgs e)
        {
            //设置起始时间为当年第一天
            DateTime dt = DateTime.Now;
            dtpStart.Value = dt.AddMonths(-dt.Month + 1).AddDays(-dt.Day + 1);
            //
            cmbUsers.DisplayMember = "Username";
            cmbUsers.ValueMember = "Id";
            cmbUsers.DataSource = new T_UsersTableAdapter().GetData();
            cmbUsers.SelectedIndex = -1;

            CBoxUsed.DisplayMember = "Username";
            CBoxUsed.ValueMember = "Id";
            CBoxUsed.DataSource = new T_UsersTableAdapter().GetData();
            CBoxUsed.SelectedIndex = -1;

            if (!Common.AuthenticateRight.AuthOperation(110601) && !Common.CommonClass.SttUser.blSuperUser)
            {
                cmbUsers.SelectedValue = Classes.PubClass.UserId;
                cmbUsers.Enabled = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110602) && !Common.CommonClass.SttUser.blSuperUser)
            {
                ColDel.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110603) && !Common.CommonClass.SttUser.blSuperUser)
            {
                ColModify.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110604) && !Common.CommonClass.SttUser.blSuperUser)
            {
                ColGetCard.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110605) && !Common.CommonClass.SttUser.blSuperUser)
            {
                ColBackCard.Visible = false;
            }

            
            var mTable = new T_CardsTableAdapter().GetData();
            var mRow = mTable.NewRow();
            mRow["cardname"] = "";
            mRow["CardBalance"] = 0;
            mRow["UserName"] = "";
            mTable.Rows.InsertAt(mRow,0);
            cmbCards.DataSource = mTable;
            cmbCards.SelectedIndex = -1;
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var mForm = new 申请餐费报销())
            {
                mForm.ShowDialog();
                btnSearch_Click(sender, new EventArgs());
            }

        }

        private void dgvGiftStockOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            if (e.ColumnIndex == dgvGiftStockOut.Columns["ColDel"].Index)
            {
                //删除

                if (dgvGiftStockOut.Rows[e.RowIndex].Cells["statusDataGridViewTextBoxColumn"].Value.ToString() == "已领卡")
                {
                    MessageBox.Show("该消费卡尚未归还,不能删除!");
                    return;
                }
                if (MessageBox.Show("确认要删除该条记录吗?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != DialogResult.OK)
                {
                    return;
                }

                using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                {
                    mConn.Open();
                    using (SqlTransaction mTrans = mConn.BeginTransaction())
                    {
                        try
                        {
                            var adapter = new T_MealsTableAdapter();
                            adapter.Connection = mConn;
                            adapter.Transaction = mTrans;

                            int ret = 0;

                            ret = adapter.MyDelete(Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));

                            if (ret > 0)
                            {
                                if (dgvGiftStockOut.Rows[e.RowIndex].Cells["statusDataGridViewTextBoxColumn"].Value.ToString() == "已还卡") //已还卡的
                                {
                                    var adapter1 = new T_CardsTableAdapter();
                                    adapter1.Connection = mConn;
                                    adapter1.Transaction = mTrans;

                                    ret = adapter1.ExpenseById(-Convert.ToDecimal(dgvGiftStockOut.Rows[e.RowIndex].Cells["mealMoneyDataGridViewTextBoxColumn"].Value), Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["cardid"].Value));
                                }
                                if (ret > 0)
                                {
                                    mTrans.Commit();
                                    MessageBox.Show("删除成功");
                                    mConn.Close();
                                    btnSearch_Click(sender, new EventArgs());
                                    return;
                                }
                                else
                                {
                                    mTrans.Rollback();
                                    MessageBox.Show("删除失败:2");
                                    return;
                                }
                            }
                            else
                            {
                                mTrans.Rollback();
                                MessageBox.Show("删除失败:1");
                                return;
                            }

                        }
                        catch (Exception ex)
                        {
                            mTrans.Rollback();
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }

                }
            }
            if (e.ColumnIndex == dgvGiftStockOut.Columns["ColModify"].Index)
            {
                //修改
                using (var mForm =new 申请餐费报销())
                {
                    mForm.mId = Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.oldStatus = dgvGiftStockOut.Rows[e.RowIndex].Cells["statusDataGridViewTextBoxColumn"].Value.ToString();
                    mForm.oldCardName = dgvGiftStockOut.Rows[e.RowIndex].Cells["cardIdDataGridViewTextBoxColumn"].Value.ToString();
                    mForm.ShowDialog();
                    btnSearch_Click(sender, new EventArgs());
                }
            }
            if (e.ColumnIndex == dgvGiftStockOut.Columns["ColGetCard"].Index)
            {
                //领卡
                if (dgvGiftStockOut.Rows[e.RowIndex].Cells["statusDataGridViewTextBoxColumn"].Value.ToString() != "审核已通过" || dgvGiftStockOut.Rows[e.RowIndex].Cells["cardIdDataGridViewTextBoxColumn"].Value.ToString() == "现金")
                {
                    return;
                }

                long cardId = Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["CardId"].Value);
                var mRow =(销售管理.DAL.DataSetCards.T_CardsRow) new T_CardsTableAdapter().GetDataById(cardId).Rows[0];
                if (mRow.UserName.Trim() != string.Empty)
                {
                    MessageBox.Show("卡已被"+ mRow.UserName+"借出");
                    return;
                }

                using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                {
                    mConn.Open();
                    using (SqlTransaction mTrans = mConn.BeginTransaction())
                    {
                        try
                        {
                            var adapter = new T_MealsTableAdapter();
                            adapter.Connection = mConn;
                            adapter.Transaction = mTrans;

                            int ret = adapter.UpdateStatus("已领卡", Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));

                            if (ret > 0)
                            {
                                var adapter1 = new T_CardsTableAdapter();
                                adapter1.Connection = mConn;
                                adapter1.Transaction = mTrans;

                                ret = adapter1.UpdateUserName(Convert.ToString(dgvGiftStockOut.Rows[e.RowIndex].Cells["userIdDataGridViewTextBoxColumn"].Value), cardId);
                                if (ret > 0)
                                {
                                    mTrans.Commit();
                                    mConn.Close();
                                    MessageBox.Show("领卡成功");
                                    btnSearch_Click(sender, new EventArgs());
                                    return;
                                }
                                else
                                {
                                    mTrans.Rollback();
                                    MessageBox.Show("领卡失败:2");
                                    return;
                                }

                            }
                            else
                            {
                                mTrans.Rollback();
                                MessageBox.Show("领卡失败:1");
                                return;
                            }

                        }
                        catch (Exception ex)
                        {
                            mTrans.Rollback();
                            MessageBox.Show(ex.Message);
                            return;
                        }

                    }
                }

                
            }

            //还卡金额录入
            if (e.ColumnIndex == dgvGiftStockOut.Columns["ColBackCard"].Index)
            {
                //还卡
                if (dgvGiftStockOut.Rows[e.RowIndex].Cells["statusDataGridViewTextBoxColumn"].Value.ToString() != "已领卡" )
                {
                    MessageBox.Show("还未领卡!");
                    return;
                }

                using (var mForm = new 输入消费金额())
                {
                    long mId = Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    decimal mMoney=0;
                    DateTime mBackDate;
                    if (mForm.ShowDialog() == DialogResult.OK)
                    {
                        mMoney = mForm.mMoney;
                        mBackDate = mForm.mBackTime;

                        //修改日期：2016/8/8 修改内容：添加超额提示 
                        #region
                        String username;//销售姓名
                        String userid; //销售编号
                        String maxMoney;  //销售剩余额度
                        username = dgvGiftStockOut.Rows[e.RowIndex].Cells["IntUsedID"].Value.ToString();
                        if (username == String.Empty)
                        {
                            MessageBox.Show("获取‘使用人’失败！");
                            return;
                        }
                        String sql = string.Format(@"SELECT id FROM dbo.T_Users WHERE UserName='{0}'", username);
                        userid = SqlHelper.ExecuteScalar(sql).ToString();
                        string mSql = string.Format(@"select ss.salesum - gs.GiftSum-ms.mealsum from (select isnull(sum(summoney)/200,0) salesum from T_Saledetails where saledate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and username={0}) ss,(select isnull(sum(GiftSum),0) giftsum from t_GiftStockOut where userid={0} and datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','审核未通过')) gs,(select isnull(sum(mealmoney),0) mealsum from t_meals where userid={0} and datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status <>'已删除') ms", userid);
                        maxMoney = SqlHelper.ExecuteScalar(mSql).ToString();
                        if ((Convert.ToDecimal(maxMoney) - Convert.ToDecimal(mMoney)) <= -5000)
                        {
                            DialogResult dr;
                            dr = MessageBox.Show("剩余额度已超5000元，是否继续报销", "超额提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                            if (dr == DialogResult.No)
                            {
                                return;
                            }
                        }

                        #endregion

                        using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                        {
                            mConn.Open();
                            using (SqlTransaction mTrans = mConn.BeginTransaction())
                            {
                                try
                                {
                                    var adapter = new T_MealsTableAdapter();
                                    adapter.Connection = mConn;
                                    adapter.Transaction = mTrans;

                                    int ret = adapter.BackCard(mBackDate,mMoney, mId);

                                    if (ret > 0)
                                    {
                                        var adapter1 = new T_CardsTableAdapter();
                                        adapter1.Connection = mConn;
                                        adapter1.Transaction = mTrans;
                                        long mCardId = Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["CardId"].Value);

                                        ret = adapter1.BackCard(mMoney, mCardId);
                                        if (ret > 0)
                                        {
                                            mTrans.Commit();
                                            MessageBox.Show("还卡成功");
                                            btnSearch_Click(sender, new EventArgs());
                                            return;
                                        }
                                        else
                                        {
                                            mTrans.Rollback();
                                            MessageBox.Show("还卡失败:2");
                                            return;
                                        }
                                    }
                                    else
                                    {
                                        mTrans.Rollback();
                                        MessageBox.Show("还卡失败:1");
                                        return;
                                    }
                                }
                                catch (Exception ex)
                                {
                                    mTrans.Rollback();
                                    MessageBox.Show(ex.Message);
                                    return;
                                }
                            }
                        }
                    }
                }
            }
            
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1)
            {
                cmbCustomers.DataSource = new T_CustomersTableAdapter().GetData();
                cmbCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbCustomers.SelectedIndex = -1;
            }
            else
            {
                cmbCustomers.DataSource = new T_CustomersTableAdapter().GetDataByUserId(Convert.ToInt64(cmbUsers.SelectedValue));
                cmbCustomers.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
                cmbCustomers.AutoCompleteSource = AutoCompleteSource.ListItems;
                cmbCustomers.SelectedIndex = -1;
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            Classes.ExcelDeport.Deport(dgvGiftStockOut, 5);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


    }
}
