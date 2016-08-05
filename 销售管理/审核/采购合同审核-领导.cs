using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.日常业务.供应商管理;
using 销售管理.DAL;
using 销售管理.Classes;
using System.Linq;

namespace 销售管理.审核
{
    public partial class 采购合同审核_领导 : 销售管理.Main.采购合同审核Base
    {
        public 采购合同审核_领导()
        {
            InitializeComponent();
        }
        public MYDBEntities2 mydb = new MYDBEntities2();

        private void 采购合同审核_Load(object sender, EventArgs e)
        {
            //dgvNav1.MyBs = DaPurchaseContractBindingSource;
            BindingEvent();
            InitCmbUser();
            InitCmb();
            InitPurchaseContract();
        }

        private void BindingEvent()
        {
            dgvDaPurchaseContract.DataBindingComplete += Classes.PubFunc.dgv_DataBindingComplete;
            tsb审核通过.Click += tsb审核通过_Click;
            tsb审核不通过.Click += tsb审核不通过_Click;
            dgvDaPurchaseContract.CellDoubleClick += dgvDaPurchaseContract_CellDoubleClick;
            dgvDaPurchaseContract.CellClick += dgvDaPurchaseContract_CellClick;
        }

        private void InitCmbUser()
        {
            cmbUserName.DataSource = mydb.T_Users.ToList(); //new T_UsersTableAdapter().GetData();
            ((List<T_Users>)cmbUserName.DataSource).Insert(0, new T_Users() { UserName = "查询所有" });
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "Id";

            if (PubClass.UserRight == "领导" || PubClass.UserRight == "超级管理员" || PubClass.UserRight == "商务经理" || PubClass.UserRight == "采购经理")
            {
                cmbUserName.SelectedIndex = 0;
            }
            else
            {
                cmbUserName.SelectedValue = PubClass.UserId;
                cmbUserName.Enabled = false;
            }
        }

        private void InitCmb()
        {
            cmbHasAudit.DisplayMember = "VcDesc";
            cmbHasAudit.ValueMember = "IntID";
            cmbHasAudit.DataSource = new[] { new { IntID = 3, VcDesc = "未审核" }, new { IntID = 4, VcDesc = "审核未通过" }, new { IntID = 5, VcDesc = "审核已通过" } };
            cmbHasAudit.SelectedIndex = 0;

        }

        private void InitPurchaseContract()
        {
            if ((int)cmbHasAudit.SelectedValue == 1)
            {
                IQueryable<DaPurchaseContract> mDaPurchaseContracts = mydb.DaPurchaseContracts.Where(a => a.IntStatus == (int)cmbHasAudit.SelectedValue);
                if (string.IsNullOrWhiteSpace(txtNum.Text.Trim()) == false)
                {
                    mDaPurchaseContracts = mDaPurchaseContracts.Where(d => d.VcNum.Contains(txtNum.Text.Trim()));
                }
                if (cmbUserName.SelectedIndex > 0)
                {
                    mDaPurchaseContracts =
                        mDaPurchaseContracts.Where(d => d.IntEmpNum == (long)cmbUserName.SelectedValue);
                }
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

                }) ;
                tsb审核不通过.Enabled = true;
                tsb审核通过.Enabled = true;
            }
            else
            {
                var pcal =
                    mydb.DaPurchaseContractAuditLogs.Where(a => a.IntOperationID == (int)cmbHasAudit.SelectedValue);
                if (string.IsNullOrWhiteSpace(txtNum.Text) == false)
                {
                    pcal = pcal.Where(a => a.DaPurchaseContract.VcNum.Contains(txtNum.Text.Trim()));
                }
                if (cmbUserName.SelectedIndex > 0)
                {
                    pcal = pcal.Where(a => a.DaPurchaseContract.IntEmpNum == (long)cmbUserName.SelectedValue);
                }
                dgvNav1.DataSource = pcal.Select(a => new
                {
                    编号 = a.DaPurchaseContract.IntID,
                    合同编号 = a.DaPurchaseContract.VcNum,
                    供货方 = a.DaPurchaseContract.DaSupplier.VcName,
                    总价 = a.DaPurchaseContract.MonSum,
                    联系人 = a.DaPurchaseContract.VcLinkMan,
                    联系电话 = a.DaPurchaseContract.VcTel,
                    传真 = a.DaPurchaseContract.VcFax,
                    手机 = a.DaPurchaseContract.VcMobile,
                    采购类型 = a.DaPurchaseContract.ZdPurchaseContractType.VcDesc,
                    合同存放柜 = a.DaPurchaseContract.VcCabinet,
                    合同存档卷宗 = a.DaPurchaseContract.VcFolder,
                    备注 = a.DaPurchaseContract.VcRemark,
                    申请人 = a.DaPurchaseContract.VcApplicant,
                    申请部门 = a.DaPurchaseContract.VcApplicantDep,
                    申请公司 = a.DaPurchaseContract.DaCompany.VcName,
                    状态 = a.DaPurchaseContract.ZdContractStatu.VcDesc,
                    录入人 = a.DaPurchaseContract.T_Users.UserName,
                    录入时间 = a.DaPurchaseContract.DtCreate

                });
                tsb审核不通过.Enabled = false;
                tsb审核通过.Enabled = false;
            }

        }

        private void tsb审核通过_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("是否确认审核通过？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;
                SaveApproved(5);


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void tsb审核不通过_Click(object sender, EventArgs e)
        {
            try
            {
                //确认
                if (MessageBox.Show("是否确认审核不通过？", "提示", MessageBoxButtons.YesNo) != DialogResult.Yes)
                    return;

                SaveApproved(4);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void SaveApproved(int mType)
        {
            try
            {
                dgvDaPurchaseContract.EndEdit();//结束dgv的编辑状态，防止选择状态为改变
                int count = 0;
                foreach (DataGridViewRow mRow in dgvDaPurchaseContract.Rows)
                {
                    if (Convert.ToBoolean(mRow.Cells[dpc选择.Index].Value) == true)
                    {
                        //获取合同ID
                        var obj = mRow.Cells["编号"].Value;
                        if (obj == null)
                            return;
                        int mContractId = Convert.ToInt32(obj);

                        var mDaPurchaseContract = mydb.DaPurchaseContracts.SingleOrDefault(a => a.IntID == mContractId);
                        if (mDaPurchaseContract != null)
                        {
                            mDaPurchaseContract.IntStatus = mType;
                            mydb.DaPurchaseContractAuditLogs.Add(new DaPurchaseContractAuditLog()
                            {
                                IntOperationID = mType,
                                IntPurchaseContractID = mContractId,
                                IntUserID = Classes.PubClass.UserId
                            });
                            count++;
                        }
                    }
                }

                if (count < 1)
                {
                    MessageBox.Show("没有选择行");
                    return;
                }

                int ret = mydb.SaveChanges();

                if (ret > 0)
                {
                    MessageBox.Show("审批完成");
                    //刷新 数据
                    InitPurchaseContract();
                    return;
                }
                else
                {
                    MessageBox.Show("审批失败");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            InitPurchaseContract();
        }

        private void dgvDaPurchaseContract_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            //获取合同ID
            var obj = dgvDaPurchaseContract["编号", e.RowIndex].Value;
            if (obj == null)
                return;
            int mContractId = Convert.ToInt32(obj);
            using (var mForm = new 采购合同编辑())
            {
                mForm.mDaPurchaseContractID = mContractId;
                mForm.ShowDialog();
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
                using (var mForm = new 采购物品审核())
                {
                    mForm.MPurchaseContractId = mContractId;
                    if (mForm.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
        }

    }
}
