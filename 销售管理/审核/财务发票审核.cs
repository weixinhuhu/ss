using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;

namespace 销售管理.审核
{
    public partial class 财务发票审核 : 销售管理.UserControlBase
    {
        public 财务发票审核()
        {
            InitializeComponent();
        }

        private MYDBEntities2 mydb = new MYDBEntities2();

        private void 财务发票审核_Load(object sender, EventArgs e)
        {
            dgvInvoice.DataBindingComplete += Classes.PubFunc.dgv_DataBindingComplete;
            InitData();
        }

        private void InitCmbStatus()
        {
            cmbStatus.ValueMember = "IntID";
            cmbStatus.DisplayMember = "VcDesc";
            List<ZdInvoiceStatu> mList = mydb.ZdInvoiceStatus.ToList();
            mList.Insert(0, new ZdInvoiceStatu() {IntID = -1, VcDesc = "全部"});
            cmbStatus.DataSource = mList; //
        }

        private void InitData()
        {
            InitCmbStatus();
            //绑定数据源
            dgvInvoice.DataSource = DaInvoiceBindingSource;
            dgvNav1.MyBs = DaInvoiceBindingSource;
            SearchData();
        }

        private void SearchData()
        {
            int rowIndex = -1;
            if (dgvInvoice.SelectedRows.Count > 0)
                rowIndex = dgvInvoice.SelectedRows[0].Index; // 记录鼠标点击的行
            IQueryable<DaInvoice> daInvoice = mydb.DaInvoices;
            if (txtContractNum.Text.Trim() != string.Empty)
            {
                daInvoice = daInvoice.Where(a => a.DaContractGood.DaPurchaseContract.VcNum == txtContractNum.Text.Trim());
            }
            if (txtGoodsName.Text.Trim() != string.Empty)
            {
                daInvoice = daInvoice.Where(a => a.DaGood.VcName == txtGoodsName.Text.Trim());
            }
            if ((int) cmbStatus.SelectedValue > 0)
            {
                daInvoice = daInvoice.Where(a => a.IntStatus == (int) cmbStatus.SelectedValue);
            }
            dgvNav1.DataSource = daInvoice.Select(a => new
            {
                编号 = a.IntID,
                合同编号 = a.DaContractGood.DaPurchaseContract.VcNum,
                发票编号 = a.VcNum,
                入库单号 = a.VcStockInNo,
                物料编号 = a.DaGood.VcNum,
                物品名称 = a.DaGood.VcName,
                数量 = a.NumCount,
                状态 = a.ZdInvoiceStatu.VcDesc
            }
                );
            //DaStockInBindingSource.DataSource = .ToList();
            if (rowIndex > -1)
                dgvInvoice.FirstDisplayedScrollingRowIndex = rowIndex; //还原鼠标点击的行
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void dgvInvoice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            object obj = dgvInvoice.Rows[e.RowIndex].Cells["编号"];
            if (obj == null)
                return;
            //获取到货ID
            int daStockInId = Convert.ToInt32(dgvInvoice.Rows[e.RowIndex].Cells["编号"].Value);
            if (e.ColumnIndex == dsi审核通过.Index)
            {
                //审核通过

                if (
                    MessageBox.Show(
                        string.Format("确认采购物品：{0}审核通过？", dgvInvoice.Rows[e.RowIndex].Cells["物品名称"].Value), "提示",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取到货ID


                    var daStockIn = mydb.DaInvoices.SingleOrDefault(a => a.IntID == daStockInId);
                    if (daStockIn != null)
                    {

                        daStockIn.IntStatus = 2;

                        int ret = mydb.SaveChanges();
                        if (ret > 0)
                        {
                            MessageBox.Show("保存成功！");
                            //刷新
                            SearchData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("没有找到该到票信息");
                    }

                }


            }
            if (e.ColumnIndex == dsi审核不通过.Index)
            {

                //审核不通过
                if (
                    MessageBox.Show(
                        string.Format("确认采购物品：{0}审核不通过？", dgvInvoice.Rows[e.RowIndex].Cells["物品名称"].Value), "提示",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {

                    var daStockIn = mydb.DaInvoices.SingleOrDefault(a => a.IntID == daStockInId);
                    if (daStockIn != null)
                    {
                        daStockIn.IntStatus = 3;

                        int ret = mydb.SaveChanges();
                        if (ret > 0)
                        {
                            MessageBox.Show("保存成功！");
                            //刷新
                            SearchData();
                        }
                    }
                    else
                    {
                        MessageBox.Show("没有找到该到票信息");
                    }

                }
            }
        }
    }
}
