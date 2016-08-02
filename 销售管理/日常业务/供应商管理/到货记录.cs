using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 到货记录 : 销售管理.Main.FormBase
    {
        public 到货记录()
        {
            InitializeComponent();
        }

        private MYDBEntities2 Mydb = new MYDBEntities2();

        public int ContractGoodsId { set; get; }
        private void 到货记录_Load(object sender, EventArgs e)
        {
            InitData();
            dgvDaStockIn.DataSource = DaStockInBindingSource;
        }

        private void InitData()
        {
            if (ContractGoodsId < 1)
                return;
            var daContractgoods = Mydb.DaContractGoods.SingleOrDefault(a => a.IntID == ContractGoodsId);
            if (daContractgoods != null)
                if (daContractgoods.DaStockIns.Count > 0)
                    DaStockInBindingSource.DataSource =
                        daContractgoods
                            .DaStockIns.Select(
                                a =>
                                    new
                                    {
                                        物料编号 = a.DaGood.VcNum,
                                        物品名称 = a.DaGood.VcName,
                                        入库数量 = a.NumCount,
                                        录入时间 = a.DtCreate,
                                        录入人 = a.T_Users.UserName,
                                        状态 = a.ZdStockInStatu.VcDesc
                                    });
                else
                    DaStockInBindingSource.DataSource = new {记录="无"};
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
