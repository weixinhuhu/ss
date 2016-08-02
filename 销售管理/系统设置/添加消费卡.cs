using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetCardsTableAdapters;

namespace 销售管理.系统设置
{
    public partial class 添加消费卡 : Form
    {
        public 添加消费卡()
        {
            InitializeComponent();
        }

        public long mId = -1;

        private void 添加消费卡_Load(object sender, EventArgs e)
        {
            if (mId > -1)
            {
                var mTable = new T_CardsTableAdapter().GetDataById(mId);
                if (mTable.Rows.Count > 0)
                {
                    var mRow = (销售管理.DAL.DataSetCards.T_CardsRow)mTable.Rows[0];
                    txtCardName.Text = mRow.CardName;
                    txtCardBalance.Text = mRow.CardBalance.ToString();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if (txtCardName.Text.Trim() == string.Empty)
            {
                toolTip1.Show("消费卡名称不能为空", txtCardName, 0, txtCardName.Height, 2000);
                return;
            }
            if (txtCardBalance.Text.Trim() == string.Empty)
            {
                toolTip1.Show("消费卡余额不能为空", txtCardBalance, 0, txtCardBalance.Height, 2000);
                return;
            }
            try
            {
                var adapter = new T_CardsTableAdapter();
                int ret = 0;
                if (mId > 0)
                {
                    ret = adapter.UpdateById(txtCardName.Text.Trim(), Convert.ToDecimal(txtCardBalance.Text), mId);
                    if (ret > 0)
                    {
                        MessageBox.Show("修改成功!");
                        btnSave.Enabled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("修改失败!");
                        return;
                    }
                }
                else
                {
                    ret = adapter.Insert(txtCardName.Text.Trim(), Convert.ToDecimal(txtCardBalance.Text));
                    if (ret > 0)
                    {
                        MessageBox.Show("添加成功!");
                        btnSave.Enabled = false;
                        return;
                    }
                    else
                    {
                        MessageBox.Show("添加失败!");
                        return;
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
}
