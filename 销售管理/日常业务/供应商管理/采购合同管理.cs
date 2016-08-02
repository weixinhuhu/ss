using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Windows.Forms;
using 销售管理.Classes;
using 销售管理.DAL;
using Common;

namespace 销售管理.日常业务.供应商管理
{
    public partial class 采购合同管理 : UserControlBase
    {
        public 采购合同管理()
        {
            InitializeComponent();
        }

        MYDBEntities2 _myEntity = new MYDBEntities2();



        private void Add_Clicked(object sender, EventArgs e)
        {
            using (采购合同编辑 mForm = new 采购合同编辑())
            {
                mForm.myEntity = _myEntity;

                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    //添加成功,刷新

                    InitPurchaseContract();
                }
            }
        }

        private void 采购合同管理_Load(object sender, EventArgs e)
        {
            //AddEvents();
            dgvNav1.MyBs = DaPurchaseContractBindingSource;
            dgvDaPurchaseContract.DataBindingComplete += Classes.PubFunc.dgv_DataBindingComplete;
            InitCmbUser();
            InitPurchaseContract();
            dgvDaPurchaseContract.DataSource = DaPurchaseContractBindingSource;
            //验证权限
            if (!Common.AuthenticateRight.AuthOperation(120301) && !CommonClass.SttUser.blSuperUser)
            {
                dgvNav1.AddNewItem.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120302) && !CommonClass.SttUser.blSuperUser)
            {
                tsbExpense.Visible = false;
                tsb报销记录.Visible = false;
            }
            if (!Common.AuthenticateRight.AuthOperation(120303) && !CommonClass.SttUser.blSuperUser)
            {
                tsb借款.Visible = false;
                tsb借款记录.Visible = false;
            }
        }


        private void InitCmbUser()
        {
            cmbUserName.DataSource = _myEntity.T_Users.ToList(); //new T_UsersTableAdapter().GetData();
            ((List<T_Users>)cmbUserName.DataSource).Insert(0, new T_Users() { UserName = "查询所有" });
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "Id";

            if (!Common.AuthenticateRight.AuthOperation(120304) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUserName.SelectedValue = PubClass.UserId;
                cmbUserName.Enabled = false;

            }
            else
            {
                cmbUserName.SelectedIndex = 0;
            }
        }

        private void InitPurchaseContract()
        {

            IQueryable<DaPurchaseContract> mDaPurchaseContracts = _myEntity.DaPurchaseContracts;
            if (txtNum.Text.Trim() != string.Empty)
            {
                mDaPurchaseContracts = mDaPurchaseContracts.Where(d => d.VcNum.Contains(txtNum.Text.Trim()));
            }
            if (cmbUserName.SelectedIndex > 0)
            {
                mDaPurchaseContracts = mDaPurchaseContracts.Where(d => d.IntEmpNum == (long)cmbUserName.SelectedValue);
            }
            //dgvNav1.MyBs = DaPurchaseContractBindingSource;
            dgvNav1.DataSource = mDaPurchaseContracts.Select(a => new
            {
                编号 = a.IntID,
                合同编号 = a.VcNum,
                供货方 = a.DaSupplier.VcName,
                总价 = a.MonSum,
                联系人 = a.VcLinkMan,
                联系电话 = a.VcTel,
                传真 = a.VcFax,
                手机 = a.VcMobile,
                采购类型 = a.ZdPurchaseContractType.VcDesc,
                合同存放柜 = a.VcCabinet,
                合同存档卷宗 = a.VcFolder,
                备注 = a.VcRemark,
                申请人 = a.VcApplicant,
                申请部门 = a.VcApplicantDep,
                申请公司 = a.DaCompany.VcName,
                状态 = a.ZdContractStatu.VcDesc,
                录入人 = a.T_Users.UserName,
                录入时间 = a.DtCreate

            });

        }

        //private void dgvDaPurchaseContract_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        //{
        //    if (e.RowIndex < 0) return;

        //    return;

        //    if (e.RowIndex < DaPurchaseContractBindingSource.Count)
        //    {
        //        var daPurchaseContract = (DaPurchaseContract)DaPurchaseContractBindingSource[e.RowIndex];
        //        var grid = dgvDaPurchaseContract;
        //        if (daPurchaseContract != null)
        //        {
        //            grid.Rows[e.RowIndex].Cells[dpc采购类型.Index].Value = MyDictionarys.采购类型[daPurchaseContract.IntType];
        //            /*
        //            grid.Rows[e.RowIndex].Cells[dpc录入人.Index].Value = daPurchaseContract.T_Users.UserName;
        //            //grid.Rows[e.RowIndex].Cells[dpc采购物品.Index].Value = daPurchaseContract.DaGood.VcName;
        //            grid.Rows[e.RowIndex].Cells[dpc供货方.Index].Value = daPurchaseContract.DaSupplier.VcName;
        //            grid.Rows[e.RowIndex].Cells[dpc采购类型.Index].Value = MyDictionarys.采购类型[daPurchaseContract.IntType];
        //            grid.Rows[e.RowIndex].Cells[dpc状态.Index].Value = daPurchaseContract.ZdContractStatu.VcDesc;
        //            //if (daPurchaseContract.DaContractGoods.Sum(d=>d.NumCount)<= daPurchaseContract..DaInvoices.Sum(d=>d.NumCount))
        //            //{
        //            //    grid.Rows[e.RowIndex].Cells[dpc到票.Index].Value = "已到票";
        //            //}
        //            //if (daPurchaseContract.DaContractGoods.Sum(d => d.NumCount) <= daPurchaseContract.DaStockIns.Sum(d => d.NumCount))
        //            //{
        //            //    grid.Rows[e.RowIndex].Cells[dpc到货.Index].Value = "已到货";
        //            //}
        //             */
        //        }


        //    }
        //}

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitPurchaseContract();
        }



        private void dgvDaPurchaseContract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var dgv = dgvDaPurchaseContract;
            if (e.RowIndex < 0)
                return;


            int rowIndex = dgv.SelectedRows[0].Index;

            using (采购合同编辑 mForm = new 采购合同编辑())
            {
                //获取合同ID
                var obj = dgvDaPurchaseContract.SelectedRows[0].Cells["编号"].Value;
                if (obj == null)
                    return;
                int mContractId = Convert.ToInt32(obj);
                //mForm.myEntity = myEntity;
                mForm.mDaPurchaseContractID = mContractId;
                //mForm.mDaPurchaseContract = (DaPurchaseContract)DaPurchaseContractBindingSource[rowIndex];
                if (mForm.ShowDialog() == DialogResult.OK)
                {
                    //添加成功,刷新

                    InitPurchaseContract();
                }
            }
        }

        private void dgvDaPurchaseContract_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //获取合同ID
            var obj = dgvDaPurchaseContract["编号", e.RowIndex].Value;
            if (obj == null)
                return;
            int mContractId = Convert.ToInt32(obj);

            if (e.ColumnIndex == dpc采购物品.Index)
            {
                //int mContractId = ((DaPurchaseContract)DaPurchaseContractBindingSource[e.RowIndex]).IntID;
                using (var mForm = new 采购物品详细())
                {
                    mForm.MPurchaseContractId = mContractId;
                    if (mForm.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }

        }

        private void tsbExpense_Click(object sender, EventArgs e)
        {
            if (dgvDaPurchaseContract.SelectedRows.Count < 1)
                return;
            //获取合同ID
            var obj = dgvDaPurchaseContract.SelectedRows[0].Cells["编号"].Value;
            if (obj == null)
                return;
            int mContractId = Convert.ToInt32(obj);
            using (var mForm = new 采购报销())
            {
                mForm.MPurchaseContractId = mContractId;
                if (mForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (dgvDaPurchaseContract.SelectedRows.Count < 1)
                return;
            //获取合同ID
            var obj = dgvDaPurchaseContract.SelectedRows[0].Cells["编号"].Value;
            if (obj == null)
                return;
            int mContractId = Convert.ToInt32(obj);

            using (var mForm = new 报销记录())
            {
                mForm.MyPurchaseContractId = mContractId;
                if (mForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void tsb借款记录_Click(object sender, EventArgs e)
        {
            if (dgvDaPurchaseContract.SelectedRows.Count < 1)
                return;
            var obj = dgvDaPurchaseContract.SelectedRows[0].Cells["编号"].Value;
            if (obj == null)
                return;
            int mContractId = Convert.ToInt32(obj);

            using (var mForm = new 采购借款记录())
            {
                mForm.Mydb = _myEntity;
                mForm.MyPurchaseContractId = mContractId;
                if (mForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }

        private void tsb借款_Click(object sender, EventArgs e)
        {
            if (dgvDaPurchaseContract.SelectedRows.Count < 1)
                return;
            var obj = dgvDaPurchaseContract.SelectedRows[0].Cells["编号"].Value;
            if (obj == null)
                return;
            int mContractId = Convert.ToInt32(obj);

            using (var mForm = new 采购借款())
            {
                mForm.MyPurchaseContractId = mContractId;
                if (mForm.ShowDialog() == DialogResult.OK)
                {

                }
            }
        }



    }
}
