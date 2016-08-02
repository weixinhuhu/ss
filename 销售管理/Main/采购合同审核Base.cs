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
    public partial class 采购合同审核Base : 销售管理.UserControlBase
    {
        public 采购合同审核Base()
        {
            InitializeComponent();
        }
        
        private void 采购合同审核Base_Load(object sender, EventArgs e)
        {
            dgvDaPurchaseContract.DataSource = DaPurchaseContractBindingSource;
        }
    }
}
