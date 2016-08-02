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
    public partial class 到票记录 : 销售管理.Main.FormBase
    {
        public 到票记录()
        {
            InitializeComponent();
        }

        private MYDBEntities2 Mydb = new MYDBEntities2();

        public int ContractGoodsId { set; get; }

        private void 到票记录_Load(object sender, EventArgs e)
        {
            InitData();
            dgvDaInvoice.DataSource = DaInvoiceBindingSource;
        }

        private void InitData()
        {
            if (ContractGoodsId <1)
            {
                return;
            }

            var daContractgoods = Mydb.DaContractGoods.SingleOrDefault(a => a.IntID == ContractGoodsId);
            if (daContractgoods != null)
                if (daContractgoods.DaInvoices.Count > 0)
                    DaInvoiceBindingSource.DataSource =
                        daContractgoods
                            .DaInvoices.Select(
                                a =>
                                    new
                                    {
                                        物料编号 = a.DaGood.VcNum,
                                        物品名称 = a.DaGood.VcName,
                                        到票数量 = a.NumCount,
                                        不含税单价 = a.MonPrice,
                                        不含税合计 = a.MonSumNoTax,
                                        含税单价 = a.DaContractGood.MonPrice,
                                        含税合计 = a.MonSum,
                                        录入时间 = a.DtCreate,
                                        录入人 = a.T_Users.UserName,
                                        状态 = a.ZdInvoiceStatu.VcDesc
                                    });
                else
                    DaInvoiceBindingSource.DataSource = new { 记录 = "无" };
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
