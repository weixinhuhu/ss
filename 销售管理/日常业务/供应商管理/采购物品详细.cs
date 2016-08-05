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
    public partial class 采购物品详细 : 销售管理.Main.FormBase
    {
        public 采购物品详细()
        {
            InitializeComponent();
        }

        public int MPurchaseContractId { set; get; }
        public string ContractNum { set; get; }
        private MYDBEntities2 mydb = new MYDBEntities2();

        private void 采购物品详细_Load(object sender, EventArgs e)
        {
            InitData();
            //显示合同编号
            InitLab();
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
            dgvDCG.DataSource= BLL.Da.GetContractGoodsTable(MPurchaseContractId);
            if (rowIndex > -1)
            {
                dgvDCG.FirstDisplayedScrollingRowIndex = rowIndex;
            }
        }

        private void InitLab()
        {
            if (ContractNum ==null)
            {
                var daPurchaseContract = mydb.DaPurchaseContracts.SingleOrDefault(a => a.IntID == MPurchaseContractId);
                if (daPurchaseContract != null)
                    ContractNum = daPurchaseContract.VcNum;
            }
            labContractNum.Text = string.Format("合同编号：{0}", ContractNum);
        }

       

        private void tsb到货记录_Click(object sender, EventArgs e)
        {
            if (dgvDCG.SelectedRows.Count < 1)
            {
                MessageBox.Show("请先选择采购物品");
                return;
            }
            int rowIndex = dgvDCG.SelectedRows[0].Index;
            int mContractGoodId = Convert.ToInt32(dgvDCG[dcgID.Index, rowIndex].Value);
            using (var mForm = new 到货记录())
            {
                mForm.ContractGoodsId = mContractGoodId;
                mForm.ShowDialog();
            }
        }

        private void tsb到票记录_Click(object sender, EventArgs e)
        {
            if (dgvDCG.SelectedRows.Count < 1)
            {
                MessageBox.Show("请先选择采购物品");
                return;
            }
            int rowIndex = dgvDCG.SelectedRows[0].Index;

            int mContractGoodId = Convert.ToInt32(dgvDCG[dcgID.Index, rowIndex].Value);
            using (var mForm = new 到票记录())
            {
                mForm.ContractGoodsId = mContractGoodId;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    InitData();
                }
            }
        }

        private void tsb到货_Click(object sender, EventArgs e)
        {
            if (dgvDCG.SelectedRows.Count < 1)
            {
                MessageBox.Show("请先选择采购物品");
                return;
            }
            int rowIndex = dgvDCG.SelectedRows[0].Index;

            //获取ContractGoodsId
            int mContractGoodId = Convert.ToInt32(dgvDCG[dcgID.Index, rowIndex].Value);
            using (var mForm = new 到货信息编辑())
            {
                mForm.MContractGoodsId = mContractGoodId;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    InitData();
                }
            }
        }

        private void tsb到票_Click(object sender, EventArgs e)
        {
            if (dgvDCG.SelectedRows.Count < 1)
            {
                MessageBox.Show("请先选择采购物品");
                return;
            }
            int rowIndex = dgvDCG.SelectedRows[0].Index;

            int mContractGoodId = Convert.ToInt32(dgvDCG[dcgID.Index, rowIndex].Value);
            using (var mForm = new 发票信息编辑())
            {
                mForm.MContractGoodsId = mContractGoodId;
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    InitData();
                }
            }
        }
    }
}
