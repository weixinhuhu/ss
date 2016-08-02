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
    public partial class 采购借款 : 销售管理.Main.FormBase
    {
        public 采购借款()
        {
            InitializeComponent();
        }

        private MYDBEntities2 mydb = new MYDBEntities2();

        public int MyPurchaseContractId { set; get; }

        private DaLoan _daLoan ;

        private void 采购借款_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            if (MyPurchaseContractId < 1)
                return;

            var mPurchaseContract = mydb.DaPurchaseContracts.SingleOrDefault(a => a.IntID == MyPurchaseContractId);

            if (mPurchaseContract == null)
            {
                return;
            }
            if (_daLoan == null)
            {
                _daLoan = new DaLoan()
                {
                    IntEmpNum = Classes.PubClass.UserId,
                    IntPurchaseContractID = MyPurchaseContractId,
                    IntStatus = 1,
                    DtLoanDate = DateTime.Now.Date
                };
            }

            txtContractNum.Text = mPurchaseContract.VcNum;
            txtSupplierName.Text = mPurchaseContract.DaSupplier.VcName;

            txtMoney.DataBindings.Add("Text", _daLoan, "MonMoney");
            dtpDate.DataBindings.Add("Value", _daLoan, "DtLoanDate");

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtMoney.Text))
                {
                    MessageBox.Show("请输入借款金额");
                    return;
                }
                if (Convert.ToDecimal(txtMoney.Text) <= 0)
                {
                    MessageBox.Show("借款金额需大于0");
                    return;
                }
                if (_daLoan != null)
                {
                    mydb.DaLoans.Add(_daLoan);
                }
                int ret = mydb.SaveChanges();

                if (ret > 0)
                {
                    MessageBox.Show("保存成功");
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("保存失败");
                }
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var item in ex.EntityValidationErrors)
                {
                    foreach (var item2 in item.ValidationErrors)
                    {
                        //MessageBox.Show(string.Format("{0}:{1}\r\n", item2.PropertyName, item2.ErrorMessage));
                        MessageBox.Show(string.Format("{0}\r\n", item2.ErrorMessage));
                    }
                }
            }
            
        }
    }
}
