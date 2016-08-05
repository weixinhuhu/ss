using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 销售管理.日常业务
{
    public partial class 输入礼品退回数量 : Form
    {
        public 输入礼品退回数量()
        {
            InitializeComponent();
        }

        public decimal mBackNum = 0;
        public decimal mCurrent = 0;

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtBackNum.Text.Trim() == string.Empty)
            {
                toolTip1.Show("请输入退回礼品数量!", txtBackNum, 0, txtBackNum.Height, 2000);
                return;
            }
            try
            {
                mBackNum = Convert.ToDecimal(txtBackNum.Text);
                if (mBackNum > 0)
                {
                    if (mBackNum > mCurrent)
                    {
                        toolTip1.Show("退回礼品数量不能大于出库数量!", txtBackNum, 0, txtBackNum.Height, 2000);
                        return;
                    }
                    this.DialogResult = System.Windows.Forms.DialogResult.OK;
                    this.Close();
                }
                else
                {
                    toolTip1.Show("退回礼品数量,必须大于0!", txtBackNum, 0, txtBackNum.Height, 2000);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }
    }
}
