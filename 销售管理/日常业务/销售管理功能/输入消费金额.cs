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
    public partial class 输入消费金额 : Form
    {
        public 输入消费金额()
        {
            InitializeComponent();
        }

        public long mId = -1;
        public decimal mMoney = 0;
        public DateTime mBackTime ;

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMoney.Text.Trim() == string.Empty)
            {
                toolTip1.Show("金额不能为空!", txtMoney, 0, txtMoney.Height, 2000);
                return;
            }
            try
            {
                mMoney = Convert.ToDecimal(txtMoney.Text);
                mBackTime = dtpBackDate.Value.Date;
                this.DialogResult = System.Windows.Forms.DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

 
    }
}
