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
    public partial class 采购物品审核 : 销售管理.Main.FormBase
    {
        public 采购物品审核()
        {
            InitializeComponent();
        }

        public int MPurchaseContractId { set; get; }
        private DaPurchaseContract daPurchaseContract;
        public string ContractNum { set; get; }
        private MYDBEntities2 mydb = new MYDBEntities2();

        private void 采购物品审核_Load(object sender, EventArgs e)
        {
            daPurchaseContract = mydb.DaPurchaseContracts.SingleOrDefault(a => a.IntID == MPurchaseContractId);
            if (daPurchaseContract == null)
                return;
            dgvDCG.DataBindingComplete += Classes.PubFunc.dgv_DataBindingComplete;
            dgvDCGH.DataBindingComplete += Classes.PubFunc.dgv_DataBindingComplete;
            InitData();
            //显示合同编号
            InitLab();
            dgvDCG.DataSource = CGBindingSource;
            dgvDCGH.DataSource = CGHBindingSource;
        }

        private void InitData()
        {
            if (MPurchaseContractId < 1)
                return;
            //var purcahseContract = mydb.DaPurchaseContracts.SingleOrDefault(a => a.IntID == MPurchaseContractId);
            //var mm= from a in purcahseContract.DaContractGoods 
            //   join b in mydb.da on a
            //purcahseContract.DaContractGoods.Select()
            
            CGBindingSource.DataSource = daPurchaseContract.DaContractGoods.Select(a=>new
            {
                编号 = a.IntGoodsID,
                物料编码 = a.DaGood.VcNum,
                物品名称 = a.DaGood.VcName,
                规格型号 = a.DaGood.VcNorms,
                采购单价 = a.MonPrice,
                参考单价 = a.DaGood.MonPrice,
                历史最低单价 = a.DaGood.DaContractGoods.Any(b => b.DaPurchaseContract.IntStatus>=5)? a.DaGood.DaContractGoods.Where(b=>b.DaPurchaseContract.IntStatus>=5).Min(b=>b.MonPrice):0,
                历史最高单价 =a.DaGood.DaContractGoods.Any(b => b.DaPurchaseContract.IntStatus >= 5)? a.DaGood.DaContractGoods.Where(b => b.DaPurchaseContract.IntStatus >= 5).Max(b => b.MonPrice):0,
                平均采购单价 =a.DaGood.DaContractGoods.Any(b => b.DaPurchaseContract.IntStatus >= 5)? a.DaGood.DaContractGoods.Where(b => b.DaPurchaseContract.IntStatus >= 5).Average(b => b.MonPrice):0      
            });
            
        }

        private void InitLab()
        {
            if (ContractNum == null)
            {
                ContractNum = daPurchaseContract.VcNum;
            }
            labContractNum.Text = string.Format("合同编号：{0}", ContractNum);
            labSupplierName.Text = string.Format("供应商：{0}", daPurchaseContract.DaSupplier.VcName);
        }

        private void dgvDCG_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDCG.SelectedRows.Count < 1)
                return;

            var goodsId = Convert.ToInt32(dgvDCG.SelectedRows[0].Cells["编号"].Value);
            var goodsHistory =
                mydb.DaContractGoods.Where(a => a.DaPurchaseContract.IntStatus >= 5 && a.IntGoodsID == goodsId);
            if (goodsHistory.Any())
            {
                CGHBindingSource.DataSource = goodsHistory.Select(a => new
                {
                    编号 = a.IntID,
                    物料编码 = a.DaGood.VcNum,
                    物品名称 = a.DaGood.VcName,
                    规格型号 = a.DaGood.VcNorms,
                    供应商=  a.DaPurchaseContract.DaSupplier.VcName,
                    采购单价 = a.MonPrice,
                    数量 = a.NumCount,
                    申请时间 = a.DaPurchaseContract.DtCreate,
                    采购人 = a.DaPurchaseContract.T_Users.UserName
                }).ToList();
            }
            else
            {
                CGHBindingSource.DataSource =  new
                {
                   记录= "无"
                };
            }
        }
    }
}
