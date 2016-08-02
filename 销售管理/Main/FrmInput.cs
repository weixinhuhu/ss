using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 销售管理.Main
{
    public partial class FrmInput : Form
    {
        public FrmInput()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtInput.Text.Trim() == string.Empty)
            {
                toolTip1.Show("用户组名称不能为空", txtInput, 0, txtInput.Height, 2000);
                return;
            }
            DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
