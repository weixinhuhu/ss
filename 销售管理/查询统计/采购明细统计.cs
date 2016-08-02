using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL;
using System.Linq;
using System.Data.Entity;
using System.IO;
using System.Linq.Expressions;
using System.Security.Cryptography;
using NPOI.SS.UserModel;
using 销售管理.Classes;
using 销售管理.Model.ViewModel;

namespace 销售管理.查询统计
{
    public partial class 采购明细统计 : 销售管理.UserControlBase
    {
        public 采购明细统计()
        {
            InitializeComponent();
        }

        public MYDBEntities2 myEntity;

        private void 采购明细统计_Load(object sender, EventArgs e)
        {
            myEntity = new MYDBEntities2();
            cmbType.SelectedIndex = 0;
            InitUsers();
            InitData();
        }

        private void InitUsers()
        {
            //获取采购角色List
            List<int> roles = myEntity.PTRoles.Where(a => a.ZMC.Contains("采购")).Select(a => a.ZBH).ToList();
            //获取所有采购用户
            IQueryable<T_Users> users = myEntity.T_Users.Where(a => roles.Contains(a.IntRoleID ?? 0));
            cmbUsers.ValueMember = "Id";
            cmbUsers.DisplayMember = "Name";
            List<Classes.PubClass.MyCmbList> listUsers; //用户List
            listUsers = users.Select(a => new Classes.PubClass.MyCmbList {Id=a.id,Name = a.UserName}).ToList();
            //插入全部
            listUsers.Insert(0, new Classes.PubClass.MyCmbList(0, "全部"));
            //绑定数据
            cmbUsers.DataSource = listUsers;
            if (!Common.CommonClass.SttUser.blSuperUser && !Common.AuthenticateRight.AuthOperation(140501))
            {
                if (listUsers.Any(a => a.Id == PubClass.UserId))
                {//如果登陆的用户是采购角色
                    cmbUsers.SelectedValue = Classes.PubClass.UserId;
                    cmbUsers.Enabled = false;
                }
                else
                {//不是采购角色
                    cmbUsers.SelectedIndex = -1;
                    cmbUsers.Enabled = false;
                }
            }
            else
            {
                //默认选中全部
                cmbUsers.SelectedIndex = 0;
            }
        }

        private void InitData()
        {

            IQueryable<DaContractGood> mdcg = myEntity.DaContractGoods.Where(a=>a.DaPurchaseContract.IntStatus>=5);
            
            if (cmbType.Text.Contains("全部") == false)
            {
                //mDaPurchaseContracts = mDaPurchaseContracts.Where(d => d.IntType == cmbType.SelectedIndex - 1);
                mdcg = mdcg.Where(a => a.DaPurchaseContract.IntType == cmbType.SelectedIndex - 1);
            }
            if (dtpStart.Checked == true)
            {
               // mDaPurchaseContracts = mDaPurchaseContracts.Where(d => d.DtCreate >= dtpStart.Value && d.DtCreate <= dtpEnd.Value);
                mdcg =
                    mdcg.Where(
                        a =>
                            a.DaPurchaseContract.DtCreate >= dtpStart.Value &&
                            a.DaPurchaseContract.DtCreate <= dtpEnd.Value);
            }
            if (cmbUsers.SelectedIndex < 0)//用户选择为空 则显示自己的物品
            {
                //mDaPurchaseContracts = mDaPurchaseContracts.Where(a => a.IntEmpNum == Classes.PubClass.UserId);
                mdcg = mdcg.Where(a => a.DaPurchaseContract.IntEmpNum == Classes.PubClass.UserId);
            }
            else if ((long)cmbUsers.SelectedValue > 0)//用户选择不为空且不为全部
            {
               // mDaPurchaseContracts = mDaPurchaseContracts.Where(a => a.IntEmpNum == (long)cmbUsers.SelectedValue);
                mdcg = mdcg.Where(a => a.DaPurchaseContract.IntEmpNum == (long) cmbUsers.SelectedValue);
            }
            //物料编号起始
            if (txtGoodsNumStart.Text.Trim() != string.Empty)
            {
                mdcg = mdcg.Where(a => string.Compare( a.DaGood.VcNum,txtGoodsNumStart.Text.Trim())>=0);
            }
            if (txtGoodsNumEnd.Text.Trim() != string.Empty)
            {
                mdcg = mdcg.Where(a => string.Compare(a.DaGood.VcNum, txtGoodsNumEnd.Text.Trim()) <= 0);
            }
            if (txtSupplierNumStart.Text.Trim() != string.Empty)
            {
                mdcg = mdcg.Where(d => string.Compare(d.DaPurchaseContract.DaSupplier.VcNum, txtSupplierNumStart.Text.Trim()) >= 0);
            }
            if (txtSupplierNumEnd.Text.Trim() != string.Empty)
            {
                mdcg = mdcg.Where(d => string.Compare(d.DaPurchaseContract.DaSupplier.VcNum, txtSupplierNumEnd.Text.Trim()) <= 0);
            }
            if (string.IsNullOrWhiteSpace(txtGoodsName.Text) == false)
            {
                mdcg = mdcg.Where(d => d.DaGood.VcName.Contains(txtGoodsName.Text.Trim()));
            }
            if (string.IsNullOrWhiteSpace(txtSupplierName.Text) == false)
            {
                mdcg = mdcg.Where(d => d.DaPurchaseContract.DaSupplier.VcName.Contains(txtSupplierName.Text));
            }
            IQueryable<ViewCaiGouMingXi> query = mdcg.Select(a=>new ViewCaiGouMingXi
            {
                日期 = a.DaPurchaseContract.DtCreate,
                物料代码 = a.DaGood.VcNum,
                物料名称 = a.DaGood.VcName,
                规格型号 = a.DaGood.VcNorms,
                供应商长代码 = a.DaPurchaseContract.DaSupplier.VcNum,
                供应商名称 = a.DaPurchaseContract.DaSupplier.VcName,
                单据号码 = a.DaPurchaseContract.VcNum,
                币别 = "人民币",
                发票单位 = a.DaInvoices.Max(b=>b.VcUnit)??"",
                不含税单价 = a.DaInvoices.Sum(b=>b.MonPrice)!=null ?a.DaInvoices.Sum(b=>b.MonPrice):0,
                不含税合计 = a.DaInvoices.Sum(b => b.MonSumNoTax) != null ? a.DaInvoices.Sum(b => b.MonSumNoTax) : 0,
                含税合计 = a.DaInvoices.Sum(b => b.MonSum) != null ? a.DaInvoices.Sum(b => b.MonSum) : 0,
                发票数量 = a.DaInvoices.Sum(b => b.NumCount) != null ? a.DaInvoices.Sum(b => b.NumCount) : 0,
                入库单位 =a.DaStockIns.Max(c=>c.VcUnit)??"",
                入库数量 = a.DaStockIns.Sum(c => c.NumCount) != null ? a.DaInvoices.Sum(c => c.NumCount) : 0,
                入库单价 = a.DaStockIns.Max(c => c.MonPrice) != null ? a.DaInvoices.Sum(c => c.MonPrice) : 0,
                入库金额 = a.DaStockIns.Sum(c => c.MonSum) != null ? a.DaInvoices.Sum(c => c.MonSum) : 0
            });
            
            //IQueryable<ViewCaiGouMingXi> query1 = 
            //    from a in mDaPurchaseContracts
            //    join b in myEntity.DaContractGoods on a.IntID equals b.IntContractID
            //    from c in myEntity.DaStockIns
            //    from d in myEntity.DaInvoices
            //    where d.IntContractGoodsID == b.IntID && c.IntContractGoodsID == b.IntID
            //    select new ViewCaiGouMingXi
            //    {
            //        日期 = a.DtCreate,
            //        物料代码 = b.DaGood.VcNum,
            //        物料名称 = b.DaGood.VcName,
            //        规格型号 = b.DaGood.VcNorms,
            //        供应商长代码 = a.DaSupplier.VcNum,
            //        供应商名称 = a.DaSupplier.VcName,
            //        单据号码 = a.VcNum,
            //        币别 = "人民币",
            //        发票单位 = d.VcUnit,
            //        不含税单价 = d.MonPrice,
            //        不含税合计 = d.MonSumNoTax,
            //        含税合计 = d.MonSum,
            //        发票数量 = d.NumCount,
            //        入库单位 = c.VcUnit,
            //        入库数量 = c.NumCount,
            //        入库单价 = c.MonPrice,
            //        入库金额 = c.MonSum
            //    };
             //物料编号起始
            //if (txtGoodsNumStart.Text.Trim() != string.Empty)
            //{
            //    query = query.Where(a => String.CompareOrdinal(a.物料代码, txtGoodsNumStart.Text.Trim()) >= 0);
            //}
            //if (txtGoodsNumEnd.Text.Trim() != string.Empty)
            //{
            //    query = query.Where(a => String.CompareOrdinal(a.物料代码, txtGoodsNumStart.Text.Trim()) <= 0);
            //}
            //if (txtSupplierNumStart.Text.Trim() != string.Empty)
            //{
            //    query = query.Where(d => String.CompareOrdinal(d.供应商长代码, txtSupplierNumStart.Text.Trim()) >= 0);
            //}
            //if (txtSupplierNumEnd.Text.Trim() != string.Empty)
            //{
            //    query = query.Where(d => String.CompareOrdinal(d.供应商长代码, txtSupplierNumEnd.Text.Trim()) <= 0);
            //}

            DaPurchaseContractBindingSource.DataSource = query.ToList();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook(new FileStream(Application.StartupPath + "\\office\\财务统计模板.xls", FileMode.Open, FileAccess.Read));
                //IWorkbook mWorkbook =
                //ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ISheet mSheet = mWorkbook.GetSheet("采购明细表");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;

                DataGridView mView = dgvDaPurchaseContract;

                //添加标头
                IRow mRow;//= mSheet.CreateRow(0);
                //for (i = 0; i <= mView.Columns.Count - 1; i++)
                //{
                //    mCell = mRow.CreateCell(i);
                //    mCell.SetCellValue(mView.Columns[i].HeaderText);
                //    mCell.CellStyle = styleRight;
                //}
                //添加内容

                for (i = 1; i <= mView.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i + 2);
                    for (j = 0; j <= mView.Columns.Count - 1; j++)
                    {
                        if (mView.Columns[j].Visible == false)
                            continue;
                        mCell = mRow.CreateCell(j);

                        if (Classes.PubFunc.IsNumber(Convert.ToString(mView.Rows[i - 1].Cells[j].Value)) == true && j != dpc单据号码.Index)
                        {
                            mCell.SetCellValue(Convert.ToDouble(mView.Rows[i - 1].Cells[j].Value));
                        }
                        else
                        {
                            mCell.SetCellValue(Convert.ToString(mView.Rows[i - 1].Cells[j].Value));
                        }
                        mCell.CellStyle = styleRight;

                    }
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = "财务采购统计-" + DateTime.Now.ToString("yyyyMMddhhmmss");
                if (mDialog.ShowDialog() == DialogResult.OK)
                {
                    Stream mFile = mDialog.OpenFile();
                    mWorkbook.Write(mFile);
                    mFile.Close();
                    MessageBox.Show("保存成功！", "提示");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
