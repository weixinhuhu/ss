using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Transactions;
using System.Windows.Forms;
using 销售管理.DAL;
using 销售管理.Main;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 采购报销 : FormBase
    {
        public 采购报销()
        {
            InitializeComponent();
        }

        public int MPurchaseContractId { set; get; }
        public string ContractNum { set; get; }
        private MYDBEntities2 mydb = new MYDBEntities2();
        private DataTable expenseTable = new DataTable();

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvDCG.SelectedRows.Count < 0)
                {
                    MessageBox.Show("请先选择采购物品！");
                    return;
                }
                if (string.IsNullOrWhiteSpace(txtExpenseNum.Text))
                {
                    MessageBox.Show("请输入报销个数！");
                    return;
                }
                
                //获取选中的ContractGoodsId
                var goodsId = Convert.ToInt32(dgvDCG.SelectedRows[0].Cells["dcgID"].Value);


                //判断是否已在下面的列表中
                if (expenseTable.Rows.Contains(goodsId))
                {
                    MessageBox.Show("已选择该采购物品！");
                    return;
                }
                //获取已到货、已到票数量、已报销数量
                var invoiceNum = Convert.ToInt32(dgvDCG.SelectedRows[0].Cells["dcg已到票数量"].Value);
                var stockinNum = Convert.ToInt32(dgvDCG.SelectedRows[0].Cells["dcg已到货数量"].Value);
                var expenseNum = Convert.ToInt32(dgvDCG.SelectedRows[0].Cells["dcg已报销数量"].Value);

                //获取当前报销数
                var currentNum = Convert.ToInt32(txtExpenseNum.Text);
                if (currentNum < 1)
                {
                    MessageBox.Show("报销个数需大于0");
                    return;
                }
                //判断报销个数是否超过已到货个数和已到票个数
                if (currentNum + expenseNum > invoiceNum)
                {
                    MessageBox.Show("报销数量超过已到票数量！");
                    return;
                }
                if (currentNum + expenseNum > stockinNum)
                {
                    MessageBox.Show("报销数量超过已到货数量！");
                    return;
                }
                //获取单价、计算金额
                decimal price = Convert.ToDecimal(dgvDCG.SelectedRows[0].Cells["dcg单价"].Value);
                decimal sum = price * currentNum;
                //插入
                ExpenseTableInsert(goodsId, Convert.ToInt32(dgvDCG.SelectedRows[0].Cells["dcgID"].Value), dgvDCG.SelectedRows[0].Cells["dcg物品名称"].Value.ToString(), price, currentNum, sum);
                ShowSum();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           

        }

        private void ShowSum()
        {
            labSum.Text = string.Format("本次报销合计：{0}", expenseTable.Compute("sum(金额)", "true"));
        }

        private void InitData()
        {
            if (MPurchaseContractId < 1)
                return;
            //var purcahseContract = mydb.DaPurchaseContracts.SingleOrDefault(a => a.IntID == MPurchaseContractId);
            //var mm= from a in purcahseContract.DaContractGoods 
            //   join b in mydb.da on a
            //purcahseContract.DaContractGoods.Select()
            int rowIndex = -1;
            if (dgvDCG.SelectedRows.Count > 0)
            {
                rowIndex = dgvDCG.SelectedRows[0].Index;

            }
            dgvDCG.DataSource = BLL.Da.GetContractGoodsTable(MPurchaseContractId);
            if (rowIndex > -1)
            {
                dgvDCG.FirstDisplayedScrollingRowIndex = rowIndex;
            }
            //dgvExpense.DataSource = expenseTable;
        }

        private void InitLab()
        {
            if (ContractNum == null)
            {
                var daPurchaseContract = mydb.DaPurchaseContracts.SingleOrDefault(a => a.IntID == MPurchaseContractId);
                if (daPurchaseContract == null)
                    return;

                ContractNum = daPurchaseContract.VcNum;

                labContractNum.Text = string.Format("合同编号：{0}", ContractNum);
                labSupplierName.Text = string.Format("供应商：{0}", daPurchaseContract.DaSupplier.VcName);
            }

        }

        private void InitTable()
        {
            expenseTable.Columns.Clear();
            expenseTable.Columns.Add("IntID").DataType = typeof(int);
            expenseTable.Columns.Add("IntContractGoodsId").DataType = typeof(int);
            expenseTable.Columns.Add("物品名称");
            expenseTable.Columns.Add("单价").DataType = typeof(decimal);
            expenseTable.Columns.Add("数量").DataType = typeof(decimal);
            expenseTable.Columns.Add("金额").DataType = typeof(decimal);
            //expenseTable.Columns.Add("日期").DataType = typeof (DateTime);
            expenseTable.PrimaryKey = new[] { expenseTable.Columns["IntID"] };
        }

        private void 采购报销_Load(object sender, EventArgs e)
        {
            daExpenseBindingSource.DataSource = expenseTable;
            dgvExpense.DataSource = daExpenseBindingSource;
            dgvExpense.DataBindingComplete +=Classes.PubFunc.dgv_DataBindingComplete_RemoveID;
            InitLab();
            InitTable();
            InitData();
        }

        private void ExpenseTableInsert(int daGoodsId, int contractGoodId, string daGoodsName, decimal daPrice, int daCount, decimal daSum)
        {
            var mRow = expenseTable.NewRow();

            mRow["IntID"] = daGoodsId;
            mRow["IntContractGoodsId"] = contractGoodId;
            mRow["物品名称"] = daGoodsName;
            mRow["单价"] = daPrice;
            mRow["数量"] = daCount;
            mRow["金额"] = daSum;
            expenseTable.Rows.Add(mRow);

        }

        private void btnExpense_Click(object sender, EventArgs e)
        {
            if (expenseTable.Rows.Count < 1)
            {
                MessageBox.Show("请选择要报销的物品");
                return;
            }
            //添加 合同物品明细
            foreach (DataRow mRow in expenseTable.Rows)
            {
                var mdcg = new DaExpense()
                {
                    IntContractGoodsID = Convert.ToInt32(mRow["IntContractGoodsId"]),
                    IntGoodsID = Convert.ToInt32(mRow["IntID"]),
                    IntEmpNum = Classes.PubClass.UserId,
                    MonPrice = Convert.ToDecimal(mRow["单价"]),
                    NumCount = Convert.ToInt32(mRow["数量"]),
                    MonSum = Convert.ToDecimal(mRow["金额"]),
                    IntStatus = 1
                };
                mydb.DaExpenses.Add(mdcg);
            }
            int ret = mydb.SaveChanges();
            if (ret > 0)
            {
                MessageBox.Show(@"保存成功");
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show(@"保存失败");
            }


        }

        private void dgvExpense_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == expense删除.Index)
            {
                expenseTable.Rows.Remove(((DataRowView)daExpenseBindingSource[e.RowIndex]).Row);
                ShowSum();
            }
        }
    }
}
