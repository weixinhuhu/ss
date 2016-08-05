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
    public partial class 采购借款记录 : 销售管理.Main.FormBase
    {
        public 采购借款记录()
        {
            InitializeComponent();
        }

        public MYDBEntities2 Mydb;// = new MYDBEntities2();

        public int MyPurchaseContractId { set; get; }

        public bool DisplayWriteOff = false;

        private void 采购借款记录_Load(object sender, EventArgs e)
        {
            if (Mydb == null) 
                Mydb = new MYDBEntities2();
            btnWriteOff.Visible = DisplayWriteOff;
            InitData();
            dgvLoan.DataSource = DaLoanBindingSource;
            dgvLoan.DataBindingComplete += Classes.PubFunc.dgv_DataBindingComplete;
        }

        private void InitData()
        {
            if (MyPurchaseContractId < 1)
                return;
            int rowIndex = -1;
            if (dgvLoan.SelectedRows.Count > 0)
            {
                rowIndex = dgvLoan.SelectedRows[0].Index;
            }

            var purchaseContract = Mydb.DaPurchaseContracts.SingleOrDefault(a => a.IntID == MyPurchaseContractId);
            if (purchaseContract != null)
            {
                if (purchaseContract.DaLoans.Count > 0)
                {
                    DaLoanBindingSource.DataSource = purchaseContract.DaLoans.Select(a => new
                    {
                        编号 = a.IntID,
                        合同编号 = a.DaPurchaseContract.VcNum,
                        供应商 = a.DaPurchaseContract.DaSupplier.VcName,
                        借款金额 = a.MonMoney,
                        借款日期 = a.DtLoanDate,
                        状态 = a.ZdLoanStatu.VcDesc
                    });
                }
                else
                {
                    DaLoanBindingSource.DataSource = new { 记录 = "无" };
                }
            }
            if (rowIndex > -1 && rowIndex<dgvLoan.Rows.Count)
            {

                dgvLoan.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnWriteOff_Click(object sender, EventArgs e)
        {
            if (dgvLoan.SelectedRows.Count < 1)
            {
                MessageBox.Show("请选择要冲销的借款记录");
                return;
            }
            try
            {
                //冲销
                //判断状态是否为已借款
                //获取借款编号
                var daLoanId = Convert.ToInt32(dgvLoan.SelectedRows[0].Cells["编号"].Value);
                var daLoan = Mydb.DaLoans.SingleOrDefault(a => a.IntID == daLoanId);
                if (daLoan == null)
                    return;
                if (daLoan.IntStatus == 2)
                    return;
                daLoan.IntStatus = 2;
                int ret = Mydb.SaveChanges();
                if (ret > 0)
                {
                    MessageBox.Show("冲销完成");
                    InitData();
                    return;
                }
                else
                {
                    MessageBox.Show("冲销失败");
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
