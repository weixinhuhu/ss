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
    public partial class 客户资料管理 : 销售管理.UserControlBase
    {
        public 客户资料管理()
        {
            InitializeComponent();
        }

        private void 客户资料管理_Load(object sender, EventArgs e)
        {
            
            
            tCustomersBindingSource.DataSource = t_CustomersTableAdapter.GetDataAndCountByUserId(Classes.PubClass.UserId);
                        
            cmbUserName.DataSource = new T_UsersTableAdapter().GetData();
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "ID";
            cmbUserName.SelectedValue = Classes.PubClass.UserId;
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            string mSql,mSql1;
            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);

            mSql = @"SELECT   a.id,b.username opername1, a.CompanyName, a.CompanyAddress,a.BusinessContactName, a.BusinessContactTel,a.BusinessContactPhone, a.BusinessContactEmail, a.TechContactName, a.TechContactTel, a.TechContactPhone,a.TechContactEmail, b.UserName,a.delivername,a.deliveraddress,a.deliverphone FROM  T_Customers a left join t_users b on a.opername=b.id where 1=1 and (status ='正常' or status is null) ";
            mSql1 = @"union all select null,'总计',Convert(varchar(20),Count(*)),null,null,null,null,null,null,null,null,null,null,null,null,null  from t_customers a where 1=1 and (status ='正常' or status is null)";
            if (cmbUserName.Text.Trim() != "")
            {
                mSql += " and a.opername = " + cmbUserName.SelectedValue ;
                mSql1 += " and a.opername = " + cmbUserName.SelectedValue;
            }

            if (txtComName.Text.Trim() != "")
            {
                mSql += " and a.CompanyName like '%" + txtComName.Text.Trim() + "%'";
                mSql1 += " and a.CompanyName like '%" + txtComName.Text.Trim() + "%'";
            }
            if (txtBusinessName.Text.Trim() != "")
            {
                mSql += " and a.BusinessContactName like '%" + txtBusinessName.Text.Trim() + "%'";
                mSql1 += " and a.BusinessContactName like '%" + txtBusinessName.Text.Trim() + "%'";
            }
            if (txtTechName.Text.Trim() != "")
            {
                mSql += " and a.TechContactName like '%" + txtTechName.Text.Trim() + "%'";
                mSql1 += " and a.TechContactName like '%" + txtTechName.Text.Trim() + "%'";
            }

           mSql += mSql1;
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvContact.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                    return;
                }
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dgvContact.EndEdit();

        }

        private void dgvContact_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                if (e.ColumnIndex == 1)
                {
                    if ((dgvContact.Rows[e.RowIndex].Cells["OperName"].Value.ToString() == Classes.PubClass.UserName || Common.AuthenticateRight.AuthOperation(110101) || CommonClass.SttUser.blSuperUser) && Classes.PubClass.UserStatus == "正常")
                    {
                        客户资料维护 mForm = new 客户资料维护();
                        mForm.mId = Convert.ToInt64(dgvContact.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                        mForm.ShowDialog();
                        
                    }
                }
                if (e.ColumnIndex == 2)
                {
                    if ((dgvContact.Rows[e.RowIndex].Cells["OperName"].Value.ToString() == Classes.PubClass.UserName || Common.AuthenticateRight.AuthOperation(110101) || CommonClass.SttUser.blSuperUser) && Classes.PubClass.UserStatus == "正常")
                    {
                        if (MessageBox.Show("确认删除该客户资料？", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                        {
                            long mId = Convert.ToInt64(dgvContact.Rows[e.RowIndex].Cells[0].Value);
                            int ret = t_CustomersTableAdapter.DeleteById(mId);
                            if (ret > 0)
                            {
                                dgvContact.Rows.RemoveAt(e.RowIndex);
                            }
                            else
                            {
                                MessageBox.Show("删除失败");
                            }

                        }
                    }

                }
            }
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            客户资料维护 mForm = new 客户资料维护();
            mForm.ShowDialog();
        }

        private void dgvContact_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            if (dgvContact.Rows.Count > 0)
            {
                if (!Common.AuthenticateRight.AuthOperation(110101) && Common.CommonClass.SttUser.blSuperUser==false)
                {
                    foreach (DataGridViewRow mRow in dgvContact.Rows)
                    {
                        if (dgvContact.Rows[mRow.Index].Cells["OperName"].Value.ToString() != Classes.PubClass.UserName)
                        {
                            for (int i = 5; i < dgvContact.Columns.Count; i++)
                            {
                                dgvContact.Rows[mRow.Index].Cells[i].Value = "";
                            }
                        }
                    }
                    
                }
                if (dgvContact.Rows[dgvContact.Rows.Count-1].Cells["OperName"].Value.ToString() == "总计")
                {
                    dgvContact.Rows[dgvContact.Rows.Count - 1].Cells["ColModify"]=new DataGridViewTextBoxCell();
                    dgvContact.Rows[dgvContact.Rows.Count - 1].Cells["ColDel"] = new DataGridViewTextBoxCell();
                }
            }
        }

        private void cmbUserName_DataSourceChanged(object sender, EventArgs e)
        {
            (cmbUserName.DataSource as 销售管理.DAL.DataSetUsers.T_UsersDataTable).AddT_UsersRow("", "", "", "", "", "", "",0,0);
        }

    }
}
