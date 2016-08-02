using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetGiftStockOutTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetGiftsTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using System.Data.SqlClient;
using Common;

namespace 销售管理.日常业务
{
    public partial class 礼品出库管理 : 销售管理.UserControlBase
    {
        public 礼品出库管理()
        {
            InitializeComponent();
        }

        private void 礼品出库管理_Load(object sender, EventArgs e)
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

            if (!Common.AuthenticateRight.AuthOperation(110501) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUsers.SelectedValue = Classes.PubClass.UserId;
               cmbUsers.Enabled = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110502) && !CommonClass.SttUser.blSuperUser)
            {
                 ColBack.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110503) && !CommonClass.SttUser.blSuperUser)
            {
                 ColDel.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110504) && !CommonClass.SttUser.blSuperUser)
            {
                  ColStockOut.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(110505) && !CommonClass.SttUser.blSuperUser)
            {
                 ColModify.Visible = false;
            }


            cmbGifts.DisplayMember = "GiftName";
            cmbGifts.ValueMember = "Id";
            cmbGifts.DataSource = new T_GiftsTableAdapter().GetData();
            cmbGifts.SelectedIndex = -1;

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mSql = "select gso.id, gso.datadate datadate,un.username userid,un.departmentname departmentname,cn.companyname customerid,gso.giftid,gso.giftname giftname,gso.giftnum,gso.giftprice,gso.giftsum,gso.status,an.username auditid,gso.auditdate,gso.recdate,gso.hasstockout,P.username IntUsedID from t_giftstockout gso left join t_users un on gso.userid = un.id left join t_users an on gso.auditid = an.id LEFT JOIN T_Users P ON gso.IntUsedID=P.id left join t_customers cn on cn.id = customerid where gso.status <>'已删除' {0} {1} {2} {3} {4} {5} {6}";
            string mCUser = "", sUesd = "", mCCustomer = "", mCGift = "", mCDate = "", mCStockOut = "", mDepartmentName = "";//mCRight=""
            if (cmbUsers.Text != string.Empty)
            {
                mCUser = "and un.username like '%" + cmbUsers.Text + "%'";
            }
            if (CBoxUsed.Text != string.Empty)
            {
                sUesd = "and P.username like '%" + CBoxUsed.Text + "%'";
            }            
            if (cmbCustomers.Text != string.Empty)
            {
                mCCustomer = "and cn.companyname like '%" + cmbCustomers.Text + "%'";
            }
            if (cmbGifts.Text != string.Empty)
            {
                mCGift = "and gso.giftname like '%" + cmbGifts.Text + "%'";
            }
            if (dtpStart.Checked == true)
            {
                mCDate = "and gso.datadate between '" + dtpStart.Value.Date.ToString("yyyy-MM-dd")+ "' and '" + dtpEnd.Value.Date.ToString("yyyy-MM-dd")+ "'";
            }
            if (cmbSotckOut.Text != string.Empty)
            {
                mCStockOut = "and gso.hasstockout='" + cmbSotckOut.Text + "'";
            }
            if (CmbDepartmentName.Text != string.Empty)
            {
                mDepartmentName = "and un.DepartmentName ='" + CmbDepartmentName.Text + "'";
            }


            //if (Classes.PubClass.UserRight != "超级管理员" && Classes.PubClass.UserRight != "领导" && Classes.PubClass.UserRight != "商务经理")
            //{
            //    mCRight = "and gso.userid =" + Classes.PubClass.UserId;
            //}
            mSql = string.Format(mSql, mCUser, sUesd, mCCustomer, mCGift, mCDate, mCStockOut, mDepartmentName);
            DataTable mTable=SqlHelper.GetData(mSql);
            
            DataRow mRow = mTable.NewRow();
            if (mTable.Rows.Count > 0)
            {
                mRow["GiftNum"] = mTable.Compute("sum(giftnum)", "true");
                mRow["Giftsum"] = mTable.Compute("sum(giftsum)", "true");
            }
            mTable.Rows.Add(mRow);
            dgvGiftStockOut.DataSource = mTable;
            dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColDel"] = new DataGridViewTextBoxCell();
            dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColDel"].Value = "总计";

            dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColModify"] = new DataGridViewTextBoxCell();
            dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColModify"].Value = "";

            dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColBack"] = new DataGridViewTextBoxCell();
            dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColBack"].Value = "";

            dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColStockOut"] = new DataGridViewTextBoxCell();
            dgvGiftStockOut.Rows[dgvGiftStockOut.Rows.Count - 1].Cells["ColStockOut"].Value = "";

            if ((dgvGiftStockOut.DataSource as DataTable).Rows.Count < 1)
            {
                MessageBox.Show("没有记录");
                return;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var mForm = new 礼品出库申请())
            {
                mForm.ShowDialog();
                btnSearch_Click(sender, e);
            }
        }

        private void dgvGiftStockOut_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == dgvGiftStockOut.Rows.Count-1) return;
            if (e.RowIndex > -1)
            {
                try
                {
                    if (e.ColumnIndex == dgvGiftStockOut.Columns["ColModify"].Index)//修改
                    {
                        using (var mForm = new 礼品出库申请())
                        {
                            mForm.mId = Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                            if(dgvGiftStockOut.Rows[e.RowIndex].Cells["HasStockOut"].Value.ToString() == "已出库")
                            {
                                mForm.hasStockOut = true;
                            }
                            mForm.ShowDialog();
                            btnSearch_Click(sender, new EventArgs());
                        }
                    }
                    if (e.ColumnIndex == dgvGiftStockOut.Columns["ColDel"].Index)//删除
                    {
                        if (MessageBox.Show("确认要删除该条记录吗?", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                            {
                                mConn.Open();
                                using (SqlTransaction mTrans = mConn.BeginTransaction())
                                {
                                    try
                                    {
                                        var adapter = new T_GiftStockOutTableAdapter();
                                        adapter.Connection = mConn;
                                        adapter.Transaction = mTrans;

                                        //删除该条记录
                                        int ret = 0;
                                        ret = adapter.UpdateStatus("已删除", Classes.PubClass.UserId, Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value)); // 状态改为已删除
                                        if (ret > 0)
                                        {
                                            if (dgvGiftStockOut.Rows[e.RowIndex].Cells["HasStockOut"].Value.ToString() == "已出库") 
                                            {
                                                //如果已出库,则礼品退回库存
                                                var adapter1 = new T_GiftsTableAdapter();
                                                adapter1.Connection = mConn;
                                                adapter1.Transaction = mTrans;

                                                ret = adapter1.AddStockNum(Convert.ToDecimal(dgvGiftStockOut.Rows[e.RowIndex].Cells["giftNumDataGridViewTextBoxColumn"].Value), Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["giftIdDataGridViewTextBoxColumn"].Value)); //礼品退回库存
                                            }

                                            if (ret > 0)
                                            {
                                                mTrans.Commit();
                                                MessageBox.Show("删除成功!");
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
                                    }
                                }

                            }

                        }
                    }
                    if (e.ColumnIndex == dgvGiftStockOut.Columns["ColStockOut"].Index)//出库
                    {
                        if (dgvGiftStockOut.Rows[e.RowIndex].Cells["HasStockOut"].Value.ToString() != "未出库" || dgvGiftStockOut.Rows[e.RowIndex].Cells["Status"].Value.ToString() != "审核已通过")
                        {
                            return;
                        }
                        if (MessageBox.Show("是否确认出库?","警告", MessageBoxButtons.YesNo) == DialogResult.Yes)//出库时修改库存
                        {
                            try
                            {
                                using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                                {
                                    mConn.Open();
                                    using (SqlTransaction mTrans = mConn.BeginTransaction())
                                    {
                                        try
                                        {
                                            int ret = 0;
                                            var adapter = new T_GiftStockOutTableAdapter();
                                            adapter.Connection = mConn;
                                            adapter.Transaction = mTrans;
                                            ret = adapter.StockOut(Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                                            if (ret > 0)
                                            {
                                                var adapter1 = new T_GiftsTableAdapter();
                                                adapter1.Connection = mConn;
                                                adapter1.Transaction = mTrans;
                                                decimal mCurrentNum = Convert.ToDecimal(dgvGiftStockOut.Rows[e.RowIndex].Cells["giftNumDataGridViewTextBoxColumn"].Value);
                                                long mGiftId = Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["giftIdDataGridViewTextBoxColumn"].Value);
                                                ret = adapter1.AddStockNum(-mCurrentNum, mGiftId);
                                                if (ret > 0)
                                                {
                                                    mTrans.Commit();
                                                    MessageBox.Show("出库成功!");
                                                    mConn.Close();
                                                    btnSearch_Click(sender, new EventArgs());
                                                    return;
                                                }
                                                else
                                                {
                                                    mTrans.Rollback();
                                                    MessageBox.Show("出库失败:2");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                mTrans.Rollback();
                                                MessageBox.Show("出库失败:1");
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
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                                return;
                            }
                        }
                    }
                    if (e.ColumnIndex == dgvGiftStockOut.Columns["ColBack"].Index)//退回
                    {
                        if (dgvGiftStockOut.Rows[e.RowIndex].Cells["HasStockOut"].Value.ToString() != "已出库")
                        {
                            MessageBox.Show("礼品出库后才能退回!");
                            return;
                        }
                        using (var mForm = new 输入礼品退回数量())
                        {
                            mForm.mCurrent = Convert.ToDecimal(dgvGiftStockOut.Rows[e.RowIndex].Cells["giftNumDataGridViewTextBoxColumn"].Value);
                            if (mForm.ShowDialog() == DialogResult.OK)
                            {
                                decimal mBackNum = mForm.mBackNum;

                                using (SqlConnection mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                                {
                                    mConn.Open();
                                    using (SqlTransaction mTrans = mConn.BeginTransaction())
                                    {
                                        try
                                        {
                                            var adapter = new T_GiftStockOutTableAdapter();
                                            adapter.Connection = mConn;
                                            adapter.Transaction = mTrans;

                                            int ret = 0;
                                            ret = adapter.BackStock(mBackNum, Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                                            if (ret > 0)
                                            {
                                                var adapter1 = new T_GiftsTableAdapter();
                                                adapter1.Connection = mConn;
                                                adapter1.Transaction = mTrans;

                                                ret = adapter1.AddStockNum(mBackNum, Convert.ToInt64(dgvGiftStockOut.Rows[e.RowIndex].Cells["giftIdDataGridViewTextBoxColumn"].Value));
                                                if (ret > 0)
                                                {
                                                    mTrans.Commit();
                                                    MessageBox.Show("礼品退回成功");
                                                    mConn.Close();
                                                    btnSearch_Click(sender, new EventArgs());
                                                    return;
                                                }
                                                else
                                                {
                                                    mTrans.Rollback();
                                                    MessageBox.Show("礼品退回失败:2");
                                                    return;
                                                }
                                            }
                                            else
                                            {
                                                mTrans.Rollback();
                                                MessageBox.Show("礼品退回失败:1");
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
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

        private void CBoxUsed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
