using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 报销记录 : 销售管理.Main.FormBase
    {
        public 报销记录()
        {
            InitializeComponent();
        }

        public int MyPurchaseContractId {set;get;}

        private MYDBEntities2 mydb = new MYDBEntities2();

        private void 报销记录_Load(object sender, EventArgs e)
        {
            InitData();
            dgvDaStockIn.DataSource = DaExpenseBindingSource;
        }

        private void InitData()
        {
            if (MyPurchaseContractId < 1)
                return;
            var daExpenses =
                mydb.DaExpenses.Where(a => a.DaContractGood.DaPurchaseContract.IntID == MyPurchaseContractId)
                    .Select(a=>new
                    {
                        物料编号= a.DaContractGood.DaGood.VcNum,
                        物品名称= a.DaContractGood.DaGood.VcName,
                        规格型号= a.DaContractGood.DaGood.VcNorms,
                        单价 = a.MonPrice,
                        报销数量=a.NumCount,
                        金额 = a.MonSum,
                        状态 = a.ZdExpenseStatu.VcDesc
                    });
            if (daExpenses.Any())
            {
                DaExpenseBindingSource.DataSource = daExpenses.ToList();
            }
            else
            {
                DaExpenseBindingSource.DataSource = new {记录="无"};
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

    
    }
}
