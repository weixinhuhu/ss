using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetGiftsTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using System.Data.SqlClient;
using Common;
using 销售管理.DAL.DataSetGiftStockOutTableAdapters;

namespace 销售管理.日常业务
{
    public partial class 礼品出库申请 : Form
    {
        public 礼品出库申请()
        {
            InitializeComponent();
        }

        public long mId = -1;
        decimal mOldNum = 0;
        long mOldGiftId = -1;
        decimal mOldSum = 0;
        bool isLoading = false;
        public bool hasStockOut = false;

        private void 礼品出库申请_Load(object sender, EventArgs e)
        {
            isLoading = true;
            cmbUsers.DisplayMember = "UserName";
            cmbUsers.ValueMember = "Id";
            cmbUsers.DataSource = new T_UsersTableAdapter().GetData();
            cmbUsers.SelectedIndex = -1;
            
            CBoxUser.DisplayMember = "UserName";
            CBoxUser.ValueMember = "Id";
            CBoxUser.DataSource = new T_UsersTableAdapter().GetData();
            CBoxUser.SelectedIndex = -1;
            
            cmbGifts.DisplayMember = "GiftName";
            cmbGifts.ValueMember = "Id";
            cmbGifts.DataSource = new T_GiftsTableAdapter().GetData();
            cmbGifts.SelectedIndex = -1;

            if (!Common.AuthenticateRight.AuthOperation(110506) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUsers.SelectedValue = Classes.PubClass.UserId;
                cmbUsers.Enabled = false;
                CBoxUser.SelectedValue = Classes.PubClass.UserId;
            }

            if (Common.AuthenticateRight.AuthOperation(110507) )
            {
                string mSql = string.Format("select id ,Username from t_users where id={0} or id =17", Classes.PubClass.UserId);
                SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
                SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
                DataTable mTable = new DataTable();
                adapter.Fill(mTable);
                cmbUsers.DataSource = mTable;
                cmbUsers.Enabled = true;
                CBoxUser.DataSource = mTable;
            }
           

            if (mId > -1)
            {
                var mTable = new T_GiftStockOutTableAdapter().GetDataById(mId);
                if (mTable.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetGiftStockOut.T_GiftStockOutRow)mTable.Rows[0];
                    cmbUsers.SelectedValue = mRow.UserId;
                    CBoxUser.SelectedValue = mRow.IntUsedID;
                    cmbCustomers.SelectedValue = mRow.CustomerId;
                    cmbGifts.SelectedValue = mRow.GiftId;
                    txtCurrentNum.Text = mRow.GiftNum.ToString();
                    txtSum.Text = mRow.GiftSum.ToString();
                    mOldNum = mRow.GiftNum;
                    mOldGiftId = mRow.GiftId;
                    mOldSum = mRow.GiftSum;
                    dtpDataDate.Value = mRow.DataDate;
                }
                else
                {
                    MessageBox.Show("没有找到该条出库记录");
                }
            }
            isLoading = false;
        }

        private void cmbUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUsers.SelectedIndex == -1)
            {
                txtMaxSum.Text = "0";
                return;
            }
            cmbCustomers.DisplayMember = "CompanyName";
            cmbCustomers.ValueMember = "Id";
            cmbCustomers.DataSource = new T_CustomersTableAdapter().GetAllDataByUserId(Convert.ToInt64(cmbUsers.SelectedValue));
            cmbCustomers.SelectedIndex = -1;
            //查询本年度该领用人的剩余额度

            string mSql = string.Format(@"select ss.salesum - gs.GiftSum-ms.mealsum from (select isnull(sum(summoney)/200,0) salesum from T_Saledetails where saledate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and username={0}) ss,(select isnull(sum(GiftSum),0) giftsum from t_GiftStockOut where userid={0} and datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status not in('已删除','审核未通过')) gs,(select isnull(sum(mealmoney),0) mealsum from t_meals where userid={0} and datadate between (convert(varchar(4),getdate(),120) + '-01-01') and (convert(varchar(4),getdate(),120) + '-12-31') and status <>'已删除') ms", cmbUsers.SelectedValue);

            txtMaxSum.Text = SqlHelper.ExecuteScalar(mSql).ToString();
            if (txtMaxSum.Text == string.Empty)
            {
                txtMaxSum.Text = "0";
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbUsers.Text == string.Empty)
            {
                toolTip1.Show("请选择领用人!", cmbUsers, 0, cmbUsers.Height, 2000);
                return;
            }
            if (CBoxUser.Text == string.Empty)
            {
                toolTip1.Show("请选择使用人!", CBoxUser, 0, CBoxUser.Height, 2000);
                return;
            }
            if (cmbCustomers.Text == string.Empty)
            {
                toolTip1.Show("请选择客户名称!", cmbCustomers, 0, cmbCustomers.Height, 2000);
                return;
            }
            if (cmbGifts.Text == string.Empty)
            {
                toolTip1.Show("请选择礼品名称!", cmbGifts, 0, cmbGifts.Height, 2000);
                return;
            }
            if (txtCurrentNum.Text == string.Empty)
            {
                toolTip1.Show("请输入领用用量!", txtCurrentNum, 0, txtCurrentNum.Height, 2000);
                return;
            }
            long mNewGiftId = Convert.ToInt64(cmbGifts.SelectedValue);
            if (mId == -1 || mNewGiftId != mOldGiftId)//新增
            {
                if (Convert.ToDecimal(txtCurrentNum.Text) > Convert.ToDecimal(txtStockNum.Text))
                {
                    toolTip1.Show("领用数量不得大于库存数量!", txtCurrentNum, 0, txtCurrentNum.Height, 2000);
                    return;
                }

            }
            else
            {//修改
                if ((Convert.ToDecimal(txtCurrentNum.Text) - mOldNum) > Convert.ToDecimal(txtStockNum.Text))
                {
                    toolTip1.Show("领用数量不得大于库存数量!", txtCurrentNum, 0, txtCurrentNum.Height, 2000);
                    return;
                }
            }

            string operRight="";
            DataTable mTempTable = new T_UsersTableAdapter().GetDataById(Convert.ToInt64(cmbUsers.SelectedValue));
            销售管理.DAL.DataSetUsers.T_UsersRow mRow;
            if (mTempTable.Rows.Count > 0)
            {
                mRow = (销售管理.DAL.DataSetUsers.T_UsersRow)mTempTable.Rows[0];
                operRight = mRow.OperRight;
            }
            //if (Convert.ToDecimal(txtSum.Text) - mOldSum > Convert.ToDecimal(txtMaxSum.Text) && operRight != "领导" && operRight != "融通创投" && operRight != "金融卡事业部" && operRight != "财务")
            //{
            //    toolTip1.Show("领用礼品金额不能超过最大允许金额!", txtMaxSum, 0, txtMaxSum.Height, 2000);
            //    return;
            //}

<<<<<<< HEAD
            //修改时间：2016/8/8 修改内容：添加销售角色剩余额度判断
            #region
            if (operRight == "销售" && Convert.ToDecimal(txtMaxSum.Text) - Convert.ToDecimal(txtSum.Text) < -5000)
            {
                MessageBox.Show("剩余额度已超5000元,礼品出库申请提交失败！", "超额提醒");
                return;
            }
            #endregion


=======
>>>>>>> 62df0ec5f762e8817eb8dc258c165b1eeafe81c6
            try
            {
                decimal mCurrentNum = Convert.ToDecimal(txtCurrentNum.Text);
                txtCurrentNum_TextChanged(sender, e);
                decimal mSum = Convert.ToDecimal(txtSum.Text);


                using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                {
                    mConn.Open();
                    using (SqlTransaction mTrans = mConn.BeginTransaction())
                    {
                        try
                        {
                            if (mId < 0)
                            {//插入
                                var adapter = new T_GiftStockOutTableAdapter();
                                adapter.Connection = mConn;
                                adapter.Transaction = mTrans;
                                int ret = 0;
                                ret = adapter.Insert(dtpDataDate.Value.Date.ToString(), Convert.ToInt64(cmbUsers.SelectedValue), Convert.ToInt64(cmbCustomers.SelectedValue), Convert.ToInt64(cmbGifts.SelectedValue), cmbGifts.Text, mCurrentNum, Convert.ToDecimal(txtGiftPrice.Text), mSum, "已提交等待领导审核", null, null, Classes.PubClass.UserId, Convert.ToInt64(CBoxUser.SelectedValue));
                                //if (ret > 0)
                                //{
                                //    var adapter1 = new T_GiftsTableAdapter();
                                //    adapter1.Connection = mConn;
                                //    adapter1.Transaction = mTrans;

                                //    ret = adapter1.AddStockNum(-mCurrentNum, Convert.ToInt64(cmbGifts.SelectedValue));
                                if (ret > 0)
                                {
                                    mTrans.Commit();
                                    MessageBox.Show("插入成功");
                                    btnSave.Enabled = false;
                                    return;
                                }
                                else
                                {
                                    mTrans.Rollback();
                                    MessageBox.Show("插入失败:2");
                                    return;
                                }

                                //}
                                //else
                                //{
                                //    mTrans.Rollback();
                                //    MessageBox.Show("插入失败:1");
                                //    return;
                                //}
                            }
                            else
                            {//修改
                                //先修改记录信息
                                var adapter = new T_GiftStockOutTableAdapter();
                                adapter.Connection = mConn;
                                adapter.Transaction = mTrans;

                                int ret = 0;
                                ret = adapter.UpdateById(dtpDataDate.Value.Date, Convert.ToInt64(cmbUsers.SelectedValue), Convert.ToInt64(cmbCustomers.SelectedValue), Convert.ToInt64(cmbGifts.SelectedValue), cmbGifts.Text.ToString(), mCurrentNum, Convert.ToDecimal(txtGiftPrice.Text), mSum, Classes.PubClass.UserId, Convert.ToInt64(CBoxUser.SelectedValue), mId);

                                if (ret > 0)
                                {
                                    if (hasStockOut == true)
                                    {
                                        if (mCurrentNum != mOldNum || mOldGiftId != mNewGiftId)
                                        {

                                            var adapter1 = new T_GiftsTableAdapter();
                                            adapter1.Connection = mConn;
                                            adapter1.Transaction = mTrans;

                                            ret = adapter1.AddStockNum(mOldNum, mOldGiftId);
                                            if (ret > 0)
                                            {
                                                ret = adapter1.AddStockNum(-mCurrentNum, mNewGiftId);
                                                if (ret < 1)
                                                {
                                                    mTrans.Rollback();
                                                    MessageBox.Show("修改数量失败:2");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                mTrans.Rollback();
                                                MessageBox.Show("修改数量失败:1");
                                                return;
                                            }
                                        }
                                    }
                                    mTrans.Commit();
                                    MessageBox.Show("保存成功!");
                                    btnSave.Enabled = false;
                                }
                                else
                                {
                                    mTrans.Rollback();
                                    MessageBox.Show("修改失败:1");
                                    return;
                                }
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

        }

        private void txtCurrentNum_TextChanged(object sender, EventArgs e)
        {
            if (txtGiftPrice.Text != string.Empty)
            {
                decimal mGiftPrice = Convert.ToDecimal(txtGiftPrice.Text);
                if (txtCurrentNum.Text != string.Empty)
                {
                    decimal mCurrentNum = Convert.ToDecimal(txtCurrentNum.Text);
                    decimal mSum = mGiftPrice * mCurrentNum;
                    txtSum.Text = mSum.ToString("0.00");
                }

            }
        }

        private void cmbGifts_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (isLoading == true) return;
            var mTable = new T_GiftsTableAdapter().GetDataById(Convert.ToInt64(cmbGifts.SelectedValue));
            if (mTable.Rows.Count > 0)
            {
                var mRow = (销售管理.DAL.DataSetGifts.T_GiftsRow)mTable.Rows[0];
                txtGiftPrice.Text = mRow.Price.ToString();
                txtStockNum.Text = mRow.StockNum.ToString();
            }
            else
            {
                txtGiftPrice.Text = "0";
                txtStockNum.Text = "0";
            }
        }

    }
}
