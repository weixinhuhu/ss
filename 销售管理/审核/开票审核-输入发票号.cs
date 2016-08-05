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
    public partial class 开票审核_输入发票号 : Form
    {
        public 开票审核_输入发票号()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtInvoiceNo.Text.Trim()) == true)
            {
                toolTip1.Show("发票号不能为空", txtInvoiceNo,0, txtInvoiceNo.Height, 2000);
                return;
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
