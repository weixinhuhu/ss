using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 配置连接字符串
{
    public partial class 加密解密 : Form
    {
        public 加密解密()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            string inStr = txtOldStr.Text.Trim();
            string outStr= Soft.Common.Utils.EncryptRc2(inStr);
            txtNewStr.Text = outStr;
        }

        private void btnDe_Click(object sender, EventArgs e)
        {
            string inStr = txtNewStr.Text.Trim();
            string outStr = Soft.Common.Utils.DecryptRc2(inStr);
            txtOldStr.Text = outStr;
        }
    }
}
