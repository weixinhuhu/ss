using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetCardsTableAdapters;

namespace 销售管理.系统设置
{
    public partial class 消费卡维护 : 销售管理.UserControlBase
    {
        public 消费卡维护()
        {
            InitializeComponent();
        }

        private void 消费卡维护_Load(object sender, EventArgs e)
        {
            dgvCards.DataSource = new T_CardsTableAdapter().GetData();
        }

        private void dgvCards_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == dgvCards.Columns["ColDel"].Index)//删除
            {
                if (MessageBox.Show("确认删除该消费卡?", "警告", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    var adapter = new T_CardsTableAdapter();
                    int ret = 0;
                    ret = adapter.MyDelete(Convert.ToInt64(dgvCards.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value));
                    if (ret > 0)
                    {
                        MessageBox.Show("删除成功");
                        return;
                    }
                    else
                    {
                        MessageBox.Show("删除失败");
                        return;
                    }
                }
            }
            if (e.ColumnIndex == dgvCards.Columns["ColModify"].Index)//修改
            {
                using (var mForm = new 添加消费卡())
                {
                    mForm.mId = Convert.ToInt64(dgvCards.Rows[e.RowIndex].Cells["idDataGridViewTextBoxColumn"].Value);
                    mForm.Text = "修改消费卡";
                    mForm.ShowDialog();
                    dgvCards.DataSource = new T_CardsTableAdapter().GetData();
                }
            }
        }

        private void llAdd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (var mForm = new 添加消费卡())
            {
                mForm.ShowDialog();
                dgvCards.DataSource = new T_CardsTableAdapter().GetData();
            }
        }
    }
}
