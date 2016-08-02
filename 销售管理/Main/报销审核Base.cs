using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;

namespace 销售管理.Main
{
    public partial class 报销审核Base : 销售管理.UserControlBase
    {
        public 报销审核Base()
        {
            InitializeComponent();
        }

        
        private void 报销审核Base_Load(object sender, EventArgs e)
        {
            dgvResult.DataSource = resultBindingSource;
        }
    }
}
