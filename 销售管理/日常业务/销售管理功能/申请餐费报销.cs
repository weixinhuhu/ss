using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetCardsTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using System.Data.SqlClient;
using Common;
using 销售管理.DAL.DataSetMealsTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 申请餐费报销 : Form
    {
        public 申请餐费报销()
        {
            InitializeComponent();
        }

        public long mId = -1;
        long oldCardId = -1;
        public string oldCardName = "";
        public string oldStatus = "";
        decimal oldMealMoney = 0;

        private void 申请餐费报销_Load(object sender, EventArgs e)
        {
            cmbUsers.DataSource = new T_UsersTableAdapter().GetData();
            cmbUsers.SelectedIndex = -1;
            CBoxUsed.DataSource = new T_UsersTableAdapter().GetData();
            CBoxUsed.SelectedIndex = -1;

            if (!Common.AuthenticateRight.AuthOperation(110606) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUsers.SelectedValue = Classes.PubClass.UserId;
                cmbUsers.Enabled = false;
                CBoxUsed.SelectedValue = Classes.PubClass.UserId;
            }
            if (!Common.AuthenticateRight.AuthOperation(110607) && !CommonClass.SttUser.blSuperUser)
            {
                cmbCard.DataSource = new T_CardsTableAdapter().GetDataWithOutCash();
                cmbCard.SelectedIndex = -1;
            }
            else
            {
                cmbCard.DataSource = new T_CardsTableAdapter().GetData();
                cmbCard.SelectedIndex = -1;
            }
            
            if (Common.AuthenticateRight.AuthOperation(110608))
            {
                string mSql = string.Format("select id ,Username from t_users where id={0} or id =17",Classes.PubClass.UserId);
                SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
                SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
                DataTable mTable = new DataTable();
                adapter.Fill(mTable);
                cmbUsers.DataSource = mTable;
                cmbUsers.Enabled = true;
                CBoxUsed.DataSource = mTable;
            }
            
            //else if (Classes.PubClass.UserRight == "领导")
            //{
            //    string mSql = string.Format("select id ,Username from t_users where operright='销售' or id ={0}", Classes.PubClass.UserId);
            //    SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            //    SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            //    DataTable mTable = new DataTable();
            //    adapter.Fill(mTable);
            //    cmbUsers.DataSource = mTable;
            //    cmbUsers.Enabled = true;
            //}

            if (mId > -1)
            {
                var mTable = new T_MealsTableAdapter().GetDataById(mId);
                if (mTable.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetMeals.T_MealsRow)mTable.Rows[0];
                    cmbUsers.SelectedValue = mRow.UserId;
                    CBoxUsed.SelectedValue = mRow.IntUsedID;
                    cmbCustomers.SelectedValue = mRow.CustomerId;
                    cmbCard.SelectedValue = mRow.CardId;
                    oldCardId = mRow.CardId;
                    txtMealMoney.Text = mRow.MealMoney.ToString();
                    oldMealMoney = mRow.MealMoney;

                    dtpDataDate.Value = mRow.DataDate;
                }
            }
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1)
            {
                txtMaxSum.Text = "0";
                return;
            }

            cmbCustomers.DataSource = new T_CustomersTableAdapter().GetAllDataByUserId(Convert.ToInt64(cmbUsers.SelectedValue));
            DataTable mTable = new DataTable();
            
            cmbCustomers.SelectedIndex = -1;
            //查询本年度该领用人的剩余额度

            string mSql = string.Format(@"select ss.salesum - gs.GiftSum-ms.mealsum from (select isnull(sum(summoney)/200,0) salesum from T_Saledetails where saledate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and username={0}) ss,(select isnull(sum(GiftSum),0) giftsum from t_GiftStockOut where userid={0} and datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','审核未通过')) gs,(select isnull(sum(mealmoney),0) mealsum from t_meals where userid={0} and datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status <>'已删除') ms", cmbUsers.SelectedValue);

            txtMaxSum.Text = SqlHelper.ExecuteScalar(mSql).ToString();
            if (txtMaxSum.Text == string.Empty)
            {
                txtMaxSum.Text = "0";
            }
        }

        private void cmbCard_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (mId == -1)
            {
                if (cmbCard.Text == "现金")
                {
                    labMealMoney.Visible = true;
                    txtMealMoney.Visible = true;
                    labDatadate.Visible = true;
                    dtpDataDate.Visible = true;
                    txtCardBalance.Visible = false;
                    labCardBalance.Visible = false;
                    return;
                }
                else
                {
                    labMealMoney.Visible = false;
                    txtMealMoney.Visible = false;
                    labDatadate.Visible = false;
                    dtpDataDate.Visible = false;
                    txtCardBalance.Visible = true;
                    labCardBalance.Visible = true;
                    txtMealMoney.Text = "0";
                }
            }
            try
            {
                var mTable = new T_CardsTableAdapter().GetDataById(Convert.ToInt64(cmbCard.SelectedValue));
                if (mTable.Rows.Count > 0)
                {
                    txtCardBalance.Text = ((销售管理.DAL.DataSetCards.T_CardsRow)mTable.Rows[0]).CardBalance.ToString();
                }
                else
                {
                    txtCardBalance.Text = "0";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbUsers.Text == string.Empty)
                {
                    toolTip1.Show("请选择领用人!", cmbUsers, 0, cmbUsers.Height, 2000);
                    return;
                }
                if (CBoxUsed.Text == string.Empty)
                {
                    toolTip1.Show("请选择使用人!", CBoxUsed, 0, CBoxUsed.Height, 2000);
                    return;
                }
                if (cmbCustomers.Text == string.Empty)
                {
                    toolTip1.Show("请选择客户名称!", cmbCustomers, 0, cmbCustomers.Height, 2000);
                    return;
                }
                if (cmbCard.Text == string.Empty)
                {
                    toolTip1.Show("请选择消费卡!", cmbCard, 0, cmbCard.Height, 2000);
                    return;
                }
                if (txtMealMoney.Text.Trim() == string.Empty)
                {
                    toolTip1.Show("请输入消费金额!", txtMealMoney, 0, txtMealMoney.Height, 2000);
                    return;
                }
                Decimal mealMoney = 0, maxMoney = 0, cardBalance = 0;
                if (decimal.TryParse(txtMealMoney.Text, out mealMoney) == false)
                {
                    toolTip1.Show("请输入正确的消费金额", txtMealMoney, 0, txtMealMoney.Height, 2000);
                    return;
                }
                maxMoney = Convert.ToDecimal(txtMaxSum.Text);
                cardBalance = Convert.ToDecimal(txtCardBalance.Text);

                //if(mId!=-1 || oldCardId !=Convert.ToInt64(cmbCard.SelectedValue)) 
                //{
                //    //新增或换消费卡
                //    if (mealMoney > cardBalance)
                //    {
                //        toolTip1.Show("消费金额不能大于消费卡内剩余金额", txtCardBalance, 0, txtCardBalance.Height, 2000);
                //        return;
                //    }
                //}
                //else
                //{
                //    if (mealMoney-oldMealMoney > cardBalance)
                //    {
                //        toolTip1.Show("消费金额不能大于消费卡内剩余金额加原消费额", txtCardBalance, 0, txtCardBalance.Height, 2000);
                //        return;
                //    }
                //}

<<<<<<< HEAD
   
=======
>>>>>>> 62df0ec5f762e8817eb8dc258c165b1eeafe81c6
                long userid = Convert.ToInt64(cmbUsers.SelectedValue);
                string userRight = "";
                var mUserTable = new T_UsersTableAdapter().GetDataById(userid);
                if (mUserTable.Rows.Count > 0)
                {
                    var mUserRow = mUserTable[0];
                    userRight = mUserRow.OperRight.Trim();
                }
                else
                {
                    MessageBox.Show("查找用户权限失败!");
                    return;
                }
                

                if (cmbCard.Text == "现金")
                {
                    if (mealMoney - oldMealMoney > maxMoney && (!Common.AuthenticateRight.AuthOperation(110609) && !CommonClass.SttUser.blSuperUser))
                    {
                        toolTip1.Show("消费金额不能大于剩余额度", txtMealMoney, 0, txtMealMoney.Height, 2000);
                        return;
                    }
                }

<<<<<<< HEAD
                //修改日期2016/8/8   添加超额提醒
                if ((maxMoney - mealMoney) < -5000)
                {
                    DialogResult dr;
                    dr = MessageBox.Show("剩余额度已超5000元，是否继续报销", "超额提醒", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1);
                    if (dr == DialogResult.No)
                    {
                        return;
                    }
                }


                //数据库操作
                #region
=======

>>>>>>> 62df0ec5f762e8817eb8dc258c165b1eeafe81c6
                using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                {
                    mConn.Open();
                    using (SqlTransaction mTrans = mConn.BeginTransaction())
                    {
                        try
                        {
                            if (mId < 0)
                            {
                                //插入
                                var adapter = new T_MealsTableAdapter();
                                adapter.Connection = mConn;
                                adapter.Transaction = mTrans;
                                int ret = 0;
                                string status = "现金";
                                if (cmbCard.Text != "现金")
                                {
                                    status = "已提交等待领导审核";
                                }
                                //添加餐费报销记录
<<<<<<< HEAD

=======
>>>>>>> 62df0ec5f762e8817eb8dc258c165b1eeafe81c6
                                ret = adapter.Insert(dtpDataDate.Value.Date, Convert.ToInt64(cmbUsers.SelectedValue), Convert.ToInt64(cmbCustomers.SelectedValue), Convert.ToInt64(cmbCard.SelectedValue), mealMoney, Classes.PubClass.UserId, status, Convert.ToInt64(CBoxUsed.SelectedValue));
                                if (ret > 0)
                                {
                                    //var adapter1 = new T_CardsTableAdapter();
                                    //adapter1.Connection = mConn;
                                    //adapter1.Transaction = mTrans;

                                    //ret = adapter1.ExpenseById(mealMoney, Convert.ToInt64(cmbCard.SelectedValue));
                                    if (ret > 0)
                                    {
                                        mTrans.Commit();
                                        MessageBox.Show("插入成功");
                                        btnSave.Enabled = false;
                                    }
                                    else
                                    {
                                        mTrans.Rollback();
                                        MessageBox.Show("插入失败:2");
                                        return;
                                    }
                                }
                                else
                                {
                                    mTrans.Rollback();
                                    MessageBox.Show("插入失败:1");
                                    return;
                                }
                            }
                            else
                            {
                                //修改
                                var adapter = new T_MealsTableAdapter();
                                adapter.Connection = mConn;
                                adapter.Transaction = mTrans;
                                int ret = 0;
                                long newCardId = Convert.ToInt64(cmbCard.SelectedValue);
                                ret = adapter.UpdateById(dtpDataDate.Value.Date, Convert.ToInt64(cmbUsers.SelectedValue), Convert.ToInt64(cmbCustomers.SelectedValue), newCardId, mealMoney, Classes.PubClass.UserId, Convert.ToInt64(CBoxUsed.SelectedValue), mId);

                                if (ret > 0)
                                {
                                    //修改已完成的申请
                                    if (oldStatus == "已还卡" || oldStatus == "现金")
                                    {
                                        if (oldCardId != newCardId || oldMealMoney != mealMoney)
                                        {
                                            var adapter1 = new T_CardsTableAdapter();
                                            adapter1.Connection = mConn;
                                            adapter1.Transaction = mTrans;
                                            if (oldCardName != "现金")
                                            {
                                                //旧消费方式为卡
                                                ret = adapter1.ExpenseById(-oldMealMoney, oldCardId);
                                            }
                                            if (ret > 0)
                                            {
                                                if (cmbCard.Text != "现金")
                                                {
                                                    //新消费方式为消费卡
                                                    ret = adapter1.ExpenseById(mealMoney, newCardId);
                                                    adapter.UpdateStatus("已还卡", mId);
                                                }
                                                else
                                                {
                                                    adapter.UpdateStatus("现金", mId);
                                                }
                                                if (ret > 0)
                                                {
                                                    mTrans.Commit();
                                                    MessageBox.Show("修改成功");
                                                    btnSave.Enabled = false;
                                                    return;
                                                }
                                                else
                                                {
                                                    mTrans.Rollback();
                                                    MessageBox.Show("修改失败:3");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                mTrans.Rollback();
                                                MessageBox.Show("修改失败:2");
                                                return;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        //未完成的申请
                                        mTrans.Commit();
                                        MessageBox.Show("修改成功");
                                        btnSave.Enabled = false;
                                        return;
                                    }

                                    //}
                                }
                                else
                                {
                                    mTrans.Rollback();
                                    MessageBox.Show("修改失败:1");
                                    return;
                                }
<<<<<<< HEAD
                            }
=======

                            }

>>>>>>> 62df0ec5f762e8817eb8dc258c165b1eeafe81c6
                        }
                        catch (Exception ex)
                        {
                            mTrans.Rollback();
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
<<<<<<< HEAD

                #endregion 
           
            }
         
=======
            }

>>>>>>> 62df0ec5f762e8817eb8dc258c165b1eeafe81c6
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
