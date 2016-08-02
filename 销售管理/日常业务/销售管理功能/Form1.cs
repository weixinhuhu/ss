using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetExpenseAllocationTableAdapters;
using 销售管理.DAL.DataSetSaleDetailsTableAdapters;
using 销售管理.DAL.DataSetProductsTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
namespace 销售管理.日常业务
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public DataGridViewRow mRow;  //销售明细行
        public long ExId = -1; //费用分配ID
        public bool isModify =false;  //修改
        public string type;   //订单类型
        public long SalerId;  //销售ID
        public string FailTableNo;//审核不通过表号
        public string oldType; //原订单类型
        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable mTable1 = new T_ExpenseAllocationTableAdapter().GetDataById(ExId);
             var mDataRow = (销售管理.DAL.DataSetExpenseAllocation.T_ExpenseAllocationRow)mTable1.Rows[0];
                    //cmbMonth.SelectedItem = mDataRow.Month;
                    //txtTableNo.Text = mDataRow.TableNo;
                    //txtCustomerName.Text = mDataRow.CustomerName;
                    txtProjectName.Text = mDataRow.ProjectName;
                    var mProductTable = new T_ProductsTableAdapter().GetDataByID(mDataRow.ProductName);
                    if (mProductTable.Rows.Count > 0)
                    {
                        txtProductName.Text = mProductTable[0].Name;
                    }
                    var mCustomerTable = new T_CustomersTableAdapter().GetDataById(Convert.ToInt64(mDataRow.CustomerName));
                    if (mProductTable.Rows.Count > 0)
                    {
                        txtCustomerName.Text = mCustomerTable[0].CompanyName;
                    }
                    txtProductName.Tag = mDataRow.ProductName;
                    txtCustomerName.Tag = mDataRow.CustomerName;
                    txtType.Text = mDataRow.ProductType;
                    txtAmount.Text = mDataRow.Amount.ToString();
                    txtDeliverPrice.Text = mDataRow.DeliverPrice.ToString();
                    txtDeliverSum.Text = mDataRow.DeliverSum.ToString();
                    txtSalePrice.Text = mDataRow.SalePrice.ToString();
                    txtSaleSum.Text = mDataRow.SaleSum.ToString();
                    txtSaleWages.Text = mDataRow.SaleWages.ToString();
                    txtCommissionPrice.Text = mDataRow.CommissionPrice.ToString();
                    txtCommissionSum.Text = mDataRow.CommissionSum.ToString();
                    txtSaleCommission.Text = mDataRow.SaleComission.ToString();
                    txtAgentPrice.Text = mDataRow.AgentPrice.ToString();
                    txtAgentSum.Text = mDataRow.AgentSum.ToString();
                    txtAgentCommission.Text = mDataRow.AgentCommission.ToString();
                    
                    SalerId = mDataRow.UserName;
                    DataTable mTable = new T_UsersTableAdapter().GetDataById(SalerId);
                    if (mTable.Rows.Count > 0)
                    {
                        var mDataRow1 = (销售管理.DAL.DataSetUsers.T_UsersRow)mTable.Rows[0];
                        txtUserName.Text = mDataRow1.UserName;
                    }

                    if (mDataRow.type == "个人订单")
                    {
                        rbPersonal.Checked = true;
                    }
                    else if (mDataRow.type == "部门订单")
                    {
                        rbDepart.Checked = true;
                    }
                    else if (mDataRow.type == "公司跟单")
                    {
                        rbCompany.Checked = true;
                    }
                    else
                    {
                        rbCity.Checked = true;
                    }
                    if (mDataRow.IsCitySalerNull() == false)
                    {
                        if (mDataRow.CitySaler != "0")
                        {
                            cmbUserName.SelectedValue = Convert.ToInt64(mDataRow.CitySaler);
                        }
                    }
                    oldType = mDataRow.type;
                    FailTableNo = mDataRow.TableNo;
                    txtTableNo.Text = mDataRow.TableNo;

                    if (mDataRow.IsPaid == "已付款")
                    {
                        cbIsPaid.Checked = true;
                    }
                    else
                    {
                        cbIsPaid.Checked = false;
                    }
                    if (mDataRow.IsPaidDateNull() == false)
                    {
                        dtpPaidDate.Value = mDataRow.PaidDate;
                    }

                    txtStatus.Text = mDataRow.Status;//+"。" + mDataRow.BusinessRemark;

                    labStatus.Visible = true;
                    txtStatus.Visible = true;
                    btnApply.Enabled = true;

                    if (mDataRow.Status.Contains("不通过") == true && isModify ==true)
                    {
                        btnApply.Enabled = true;
                        btnApply.Text = "重新申请";
                    }
                    else
                    {
                        btnApply.Enabled = true;
                    }
                    //groupBox1.Enabled = false;
                }
                
        

public void SetTableNo()
        {
            if (type == "个人订单" || type == "部门订单" || type == "跨区域订单")
            {
                if (oldType == "个人订单" || oldType == "部门订单" || oldType == "跨区域订单")
                {
                    txtTableNo.Text = FailTableNo;
                    return;
                }
            }
            else
            {
                if (oldType == "公司跟单")
                {
                    txtTableNo.Text = FailTableNo;
                    return;
                }
            }

            if (SalerId > 0)
            {
                string mTableNo = DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00");
                var mTable = new T_UsersTableAdapter().GetDataById(SalerId);
                if (mTable.Rows.Count > 0)
                {
                    销售管理.DAL.DataSetUsers.T_UsersRow mRow = mTable[0];
                    string mSalerChar = mRow.UserChar;
                    if (type == "个人订单" || type == "部门订单" || type == "跨区域订单")
                    {
                        mTableNo = "RT-" + mSalerChar + mTableNo;
                        if (mSalerChar == "")
                        {
                            MessageBox.Show("请设置个人区域代码");
                            btnApply.Enabled = true;
                        }
                    }
                    else
                    {
                        mTableNo = "RT-" + mTableNo;
                    }
                    string mTable1 = new T_ExpenseAllocationTableAdapter().GetMaxTableNo(mTableNo).ToString();
                    txtTableNo.Text = mTableNo + (Convert.ToInt32(mTable1.Substring(mTable1.Length - 3, 3)) + 1).ToString("000");
                }
            }

        }
        private void btnApply_Click(object sender, EventArgs e)
        {
            string isPaid="";

            if (cbIsPaid.Checked==true)
            {
                isPaid="已付款";
            }
            else
            {
                isPaid="未付款";
            }
            try {

               // new T_ExpenseAllocationTableAdapter().UpdateIsPaid(isPaid, dtpPaidDate.Value, txtTableNo.Text.Trim());
                    MessageBox.Show("已提交");
                    btnApply.Enabled =true;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
