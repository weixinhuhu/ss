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
    public partial class 采购物品历史采购明细 : 销售管理.Main.FormBase
    {
        public 采购物品历史采购明细()
        {
            InitializeComponent();
        }

        private MYDBEntities2 mydb =new MYDBEntities2();
        public string GoodsNum;

        private void 采购物品历史采购明细_Load(object sender, EventArgs e)
        {
            dgvDCGH.AutoGenerateColumns = true;
            InitData();
            dgvDCGH.DataSource = bsHistory;
        }

        private void InitData()
        {
            //根据物品编号 找到物品id;
            DaGoods dg = mydb.DaGoods1.SingleOrDefault(a => a.VcNum == GoodsNum);
            if (dg != null)
            {

                var goodsHistory =
                    mydb.DaContractGoods.Where(a => a.DaPurchaseContract.IntStatus >= 5 && a.IntGoodsID == dg.IntID);
               
                if (goodsHistory.Any(c => c != null))
                {
                    bsHistory.DataSource = goodsHistory.Select(a => new
                    {
                        编号 = a.IntID,
                        物料编码 = a.DaGood.VcNum,
                        物品名称 = a.DaGood.VcName,
                        规格型号 = a.DaGood.VcNorms,
                        供应商 = a.DaPurchaseContract.DaSupplier.VcName,
                        采购单价 = a.MonPrice,
                        数量 = a.NumCount,
                        申请时间 = a.DaPurchaseContract.DtCreate,
                        采购人 = a.DaPurchaseContract.T_Users.UserName
                    }).ToList();
                }
                else
                {
                    bsHistory.DataSource = new
                    {
                        记录 = "无"
                    };
                }
            }
        }
    }
}
