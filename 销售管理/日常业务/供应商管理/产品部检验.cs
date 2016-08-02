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
    public partial class 产品部检验 : UserControlBase
    {
        public 产品部检验()
        {
            InitializeComponent();
        }

        private MYDBEntities2 mydb = new MYDBEntities2();

        private void 产品部检验_Load(object sender, EventArgs e)
        {
            dgvStockIn.DataBindingComplete += Classes.PubFunc.dgv_DataBindingComplete;
            InitData();
        }


        private void InitData()
        {
            //初始化状态下拉列表
            InitCmbStatus();
            //绑定数据源
            dgvStockIn.DataSource = DaStockInBindingSource;
            //获取数据
            SearchData();
        }

        private void InitCmbStatus()
        {
            cmbStatus.ValueMember = "IntID";
            cmbStatus.DisplayMember = "VcDesc";
            List<ZdStockInStatu> mList = mydb.ZdStockInStatus.ToList();
            mList.Insert(0,new ZdStockInStatu(){IntID = -1,VcDesc = "全部"});
            cmbStatus.DataSource = mList; //
        }

        private void SearchData()
        {
            int rowIndex = -1;
            if (dgvStockIn.SelectedRows.Count > 0)
                rowIndex = dgvStockIn.SelectedRows[0].Index; // 记录鼠标点击的行
            IQueryable<DaStockIn> daStockIn = mydb.DaStockIns;
            if (txtContractNum.Text.Trim() != string.Empty)
            {
                daStockIn = daStockIn.Where(a => a.DaContractGood.DaPurchaseContract.VcNum == txtContractNum.Text.Trim());
            }
            if (txtGoodsName.Text.Trim() != string.Empty)
            {
                daStockIn = daStockIn.Where(a => a.DaGood.VcName == txtGoodsName.Text.Trim());
            }
            if ((int)cmbStatus.SelectedValue > 0)
            {
                daStockIn = daStockIn.Where(a => a.IntStatus == (int)cmbStatus.SelectedValue);
            }
            dgvNav1.DataSource = daStockIn.Select(a => new
            {
                编号= a.IntID,
                合同编号 = a.DaContractGood.DaPurchaseContract.VcNum,
                物料编号=  a.DaGood.VcNum,
                物品名称 = a.DaGood.VcName,
                数量= a.NumCount,
                状态  = a.ZdStockInStatu.VcDesc
            }
                );
            //DaStockInBindingSource.DataSource = .ToList();
            if (rowIndex > -1)
                dgvStockIn.FirstDisplayedScrollingRowIndex = rowIndex; //还原鼠标点击的行
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void dgvStockIn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            object obj = dgvStockIn.Rows[e.RowIndex].Cells["编号"];
            if (obj == null)
                return;
            //获取到货ID
            int daStockInId = Convert.ToInt32(dgvStockIn.Rows[e.RowIndex].Cells["编号"].Value);
            if (e.ColumnIndex == dsi检验通过.Index)
            {
                //审核通过
                
                if (
                    MessageBox.Show(
                        string.Format("确认采购物品：{0}检验通过？", dgvStockIn.Rows[e.RowIndex].Cells["物品名称"].Value), "提示",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    //获取到货ID
                    
                    
                    var daStockIn =  mydb.DaStockIns.SingleOrDefault(a => a.IntID == daStockInId);
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

                }


            }
            if (e.ColumnIndex == dsi检验不通过.Index)
            {
                
                //审核不通过
                if (
                    MessageBox.Show(
                        string.Format("确认采购物品：{0}检验不通过？", dgvStockIn.Rows[e.RowIndex].Cells["物品名称"].Value), "提示",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    
                    var daStockIn = mydb.DaStockIns.SingleOrDefault(a => a.IntID == daStockInId);
                    if (daStockIn != null)
                    {
                        daStockIn.IntStatus =3;

                        int ret = mydb.SaveChanges();
                        if (ret > 0)
                        {
                            MessageBox.Show("保存成功！");
                            //刷新
                            SearchData();
                        }
                    }

                }
            }
        }
    }
}
