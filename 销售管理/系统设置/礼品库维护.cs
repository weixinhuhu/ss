using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Common;
using 销售管理.DAL.DataSetGiftsTableAdapters;

namespace 销售管理.系统设置
{
    public partial class 礼品库维护 : 销售管理.UserControlBase
    {
        public 礼品库维护()
        {
            InitializeComponent();
        }

        private void 礼品库维护_Load(object sender, EventArgs e)
        {
            dgvGifts.DataSource = t_GiftsTableAdapter.GetData();
            cmbGiftsName.DataSource = t_GiftsTableAdapter.GetData();
            cmbGiftsName.ValueMember = "Id";
            cmbGiftsName.DisplayMember = "GiftName";
            cmbGiftsName.SelectedIndex = -1;
            cmbGiftsName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbGiftsName.AutoCompleteSource = AutoCompleteSource.ListItems;
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string mSql = "select * from t_gifts where status <> '已删除' {0}";
            string mCondition1 = "";
            if (cmbGiftsName.Text != string.Empty)
                mCondition1 = "and giftname like '%" + cmbGiftsName.Text + "%'";
            else
                mCondition1 = "";

            mSql = string.Format(mSql, mCondition1);
            dgvGifts.DataSource = null;
            dgvGifts.DataSource = SqlHelper.GetData(mSql);
            if ((dgvGifts.DataSource as DataTable).Rows.Count <= 0)
            {
                MessageBox.Show("没有记录!");
            }

        }

        private void llType_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using(var mForm =  new 添加礼品种类())
            {
                mForm.ShowDialog();
            }
            btnFind_Click(sender, new EventArgs());
        }

        private void llNum_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var mForm = new 添加礼品库存())
            {
                mForm.ShowDialog();
            }
            btnFind_Click(sender, new EventArgs());
        }

        private void dgvGifts_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                if (e.ColumnIndex == dgvGifts.Columns["ColModify"].Index)//修改
                {
                    using (var mForm = new 添加礼品种类())
                    {
                        mForm.mId = Convert.ToInt64(dgvGifts.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                        mForm.ShowDialog();
                        btnFind_Click(sender, new EventArgs());
                    }
                }
                if (e.ColumnIndex == dgvGifts.Columns["ColDel"].Index)//删除
                {
                    if (MessageBox.Show("确认删除该礼品?", "警告", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                    {
                        int ret = new T_GiftsTableAdapter().MyDelete(Convert.ToInt64(dgvGifts.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                        if (ret > 0)
                        {
                            MessageBox.Show("删除成功");
                            btnFind_Click(sender, new EventArgs());
                            return;
                        }
                        else
                        {
                            MessageBox.Show("删除失败");
                            return;
                        }
                    }
                }
            }
        }
    }
}
