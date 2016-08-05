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
    public partial class 申请费用分配 : Form
    {
        public 申请费用分配()
        {
            InitializeComponent();
        }
        public DataGridViewRow mRow;  //销售明细行
        public long ExId = -1; //费用分配ID
        public bool isModify = false;  //修改
        public string type;   //订单类型
        public long SalerId;  //销售ID
        public string FailTableNo;//审核不通过表号
        public string oldType; //原订单类型
        public bool isLoading;//判断是否窗口加载中
        public DateTime DeliverDate;//发货日期

        private void 申请费用分配_Load(object sender, EventArgs e)
        {
            rbPersonal.Checked = true;
            isLoading = true;
            
            
            if (ExId > -1)   //如果费用分配ID大于-1,查看费用分配信息
            {
                DataTable mTable1 = new T_ExpenseAllocationTableAdapter().GetDataById(ExId);
                if (mTable1.Rows.Count > 0)
                {
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

                    var mSaleDetailsTable = new T_SaleDetailsTableAdapter().GetDataByExId(ExId);
                    if (mSaleDetailsTable.Rows.Count > 0)
                    {
                        DeliverDate = mSaleDetailsTable[0].SaleDate;
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
                    txtCitySum.Text = mDataRow.CitySum;
                    txtCityWages.Text = mDataRow.CityWages;
                    if(mDataRow.IsCitySalePriceNull() == false)
                    txtCitySalePrice.Text = mDataRow.CitySalePrice.ToString();
                    if(mDataRow.IsCitySaleSumNull() == false)
                    txtCitySaleSum.Text = mDataRow.CitySaleSum.ToString();
                    if(mDataRow.IsCitySaleCommissionNull()==false)
                    txtCitySaleCommission.Text = mDataRow.CitySaleCommission.ToString();
                    oldType = mDataRow.type;
                    FailTableNo = mDataRow.TableNo;
                    txtTableNo.Text = mDataRow.TableNo;

                    if (mDataRow.IsPaid == "已付款")
                    {
                        cbIsPaid.Checked = true;
                        if (mDataRow.IsPaidDateNull() == false)
                        {
                            dtpPaidDate.Value = mDataRow.PaidDate;
                        }
                    }
                    else
                    {
                        cbIsPaid.Checked = false;
                    }
                    
                    if (mDataRow.IsHasTaxNull() == false)
                    {

                        if (mDataRow.HasTax == "含税") cbTax.Checked = true;
                        else cbTax.Checked = false;
                    }
                    else
                    {
                        cbTax.Checked = false;
                      
                    }
                    txtStatus.Text = mDataRow.Status;//+"。" + mDataRow.BusinessRemark;

                    labStatus.Visible = true;
                    txtStatus.Visible = true;
                    btnApply.Enabled = false;
                    //label12.Visible = true;
                    //dtpPaidDate.Visible = true;
                    cbIsPaid.Visible = true;

                    if (mDataRow.Status.Contains("不通过") == true && isModify == true)
                    {
                        btnApply.Enabled = true;
                        btnApply.Text = "重新申请";
                        cbIsPaid.Visible = false;
                    }
                    else
                    {
                        btnApply.Enabled = false;
                    }
                    //groupBox1.Enabled = false;
                }
                else
                {
                    MessageBox.Show("该费用分配表号不存在");
                    this.Close();
                    return;
                }

                if (Classes.PubClass.UserRight == "领导" || Classes.PubClass.UserRight == "超级管理员" || Classes.PubClass.UserRight == "商务经理")
                {
                    btnModifyPaid.Visible = true;
                }
                else
                {
                    btnModifyPaid.Visible = false;
                }
            }
            else  //申请费用分配
                if (mRow != null)
                {
                    DeliverDate = Convert.ToDateTime(mRow.Cells["saleDateDataGridViewTextBoxColumn"].Value);
                    txtCustomerName.Text = mRow.Cells["customerNameDataGridViewTextBoxColumn"].Value.ToString();
                    txtProductName.Text = mRow.Cells["productNameDataGridViewTextBoxColumn"].Value.ToString();
                    txtAmount.Text = mRow.Cells["amountDataGridViewTextBoxColumn"].Value.ToString();
                    //cmbMonth.SelectedItem = mRow.Cells["saleMonthDataGridViewTextBoxColumn"].Value.ToString();
                    txtDeliverPrice.Text = mRow.Cells["priceDataGridViewTextBoxColumn"].Value.ToString();
                    long SaleDetailsId = Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value);
                    var SaleDetailsTable = new T_SaleDetailsTableAdapter().GetDataById(SaleDetailsId);
                    if (SaleDetailsTable.Rows.Count > 0)
                    {
                        txtProductName.Tag = SaleDetailsTable[0].ProductName;
                        txtCustomerName.Tag = SaleDetailsTable[0].CustomerName;
                        SalerId = SaleDetailsTable[0].UserName;
                        var mUserTable = new T_UsersTableAdapter().GetDataById(SalerId);
                        if (mUserTable.Rows.Count > 0)
                        {
                            txtUserName.Text = mUserTable[0].UserName;
                        }
                        SetTableNo();
                    }
                    btnModifyPaid.Visible = false;

                }
            
            isLoading = false;
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
                string mTableNo ;
                if (DeliverDate.Year.ToString() =="1" )
                {
                    mTableNo = DateTime.Now.Year.ToString("0000") + DateTime.Now.Month.ToString("00");
                }
                else
                {
                    mTableNo = DeliverDate.Year.ToString("0000") + DeliverDate.Month.ToString("00");
                }
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
                            btnApply.Enabled = false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    decimal deliverPrice=0, salePrice=0, commissionPrice=0, agentPrice=0, deliverSum=0, SaleSum=0, saleWages=0, commissionSum=0, saleCommission=0, agentSum=0, agentCommission=0;
            //    long Amount;
            //    Amount = Convert.ToInt64(txtAmount.Text);
            //    deliverPrice = Convert.ToDecimal(txtDeliverPrice.Text); //发货单价
            //    deliverSum = deliverPrice * Amount;                    //发货额
            //    txtDeliverSum.Text = deliverSum.ToString("0.00");
            //    salePrice = Convert.ToDecimal(txtSalePrice.Text);       //销售单价
            //    SaleSum = salePrice * Amount;                           //销售额
            //    txtSaleSum.Text = SaleSum.ToString("0.00");
            //    saleWages = SaleSum / 100;                              //销售工资
            //    txtSaleWages.Text = saleWages.ToString("0.00");
            //    commissionPrice = Convert.ToDecimal(txtCommissionPrice.Text);//提成单价
            //    commissionSum = commissionPrice * Amount;               //提成销售额
            //    txtCommissionSum.Text = commissionSum.ToString();
            //    saleCommission = (commissionSum / (decimal)1.17) / 5;   //销售提成
            //    txtSaleCommission.Text = saleCommission.ToString("0.00");
            //    //agentPrice = Convert.ToDecimal(txtAgentPrice.Text);     //代理商单价
            //    //agentSum = agentPrice * Amount;                         //代理商额度
            //    //txtAgentSum.Text = agentSum.ToString("0.00");
            //    //agentCommission = agentSum / (decimal)1.25;             //代理商税后佣金
            //    //txtAgentCommission.Text = agentCommission.ToString("0.00");

            //    if (string.IsNullOrEmpty(txtAgentPrice.Text) == true) txtAgentPrice.Text = "0"; //代理商单价为空则置0
            //    agentPrice = Convert.ToDecimal(txtAgentPrice.Text);     //代理商单价
            //    agentSum = agentPrice * Amount;                         //代理商额度
            //    txtAgentSum.Text = agentSum.ToString("0.00");
            //    if (rbCompany.Checked == true)
            //    {
            //        //公司跟单
            //        if (cbTax.Checked == true)
            //        {
            //            //销售含税
            //            agentCommission = agentSum * (decimal)0.75;             //代理商税后佣金
            //            txtAgentCommission.Text = agentCommission.ToString("0.00");
            //        }
            //        else
            //        {
            //            //销售不含税
            //            txtAgentCommission.Text = txtAgentSum.Text;
            //        }
            //    }
            //    else
            //    {
            //        //个人订单\部门订单\跨区域订单
            //        agentCommission = agentSum / (decimal)1.25;             //代理商税后佣金
            //        txtAgentCommission.Text = agentCommission.ToString("0.00");
            //    }


            //    if (deliverPrice < salePrice + commissionPrice + agentPrice)
            //    {
            //        MessageBox.Show("销售单价、提成单价、代理商单价之和不能大于发货单价");
            //        return;
            //    }
            //    string isPaid,hasTax;
            //    object ret;
            //    if (cbTax.Checked == true)
            //    {
            //        hasTax = "含税";
            //    }
            //    else
            //    {
            //        hasTax = "不含税";
            //    }

            //    if (cbIsPaid.Checked == true)
            //    {
            //        isPaid = "已付款";
            //        //ret = new T_ExpenseAllocationTableAdapter().MyInsert("", SalerId, txtTableNo.Text, Convert.ToInt64(txtCustomerName.Tag), txtProjectName.Text, Convert.ToInt64(txtProductName.Tag), txtType.Text, Amount, deliverPrice, Math.Round(deliverSum, 2), salePrice, Math.Round(SaleSum, 2), 0, Math.Round(saleWages, 2), commissionPrice, Math.Round(commissionSum, 2), Math.Round(saleCommission, 2), agentPrice, Math.Round(agentSum, 2), Math.Round(agentCommission, 2), isPaid, dtpPaidDate.Value, "已提交等待商务审核", null, null, null, null, null, null, null, null, null, Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value), type, Convert.ToInt64(cmbUserName.SelectedValue), Convert.ToDecimal(txtCitySum.Text == "" ? "0" : txtCitySum.Text), Convert.ToDecimal(txtCityWages.Text == "" ? "0" : txtCityWages.Text),hasTax);
            //    }
            //    else
            //    {
            //        isPaid = "未付款";
            //        //ret = new T_ExpenseAllocationTableAdapter().MyInsert("", SalerId, txtTableNo.Text, Convert.ToInt64(txtCustomerName.Tag), txtProjectName.Text, Convert.ToInt64(txtProductName.Tag), txtType.Text, Amount, deliverPrice, Math.Round(deliverSum, 2), salePrice, Math.Round(SaleSum, 2), 0, Math.Round(saleWages, 2), commissionPrice, Math.Round(commissionSum, 2), Math.Round(saleCommission, 2), agentPrice, Math.Round(agentSum, 2), Math.Round(agentCommission, 2), isPaid, null, "已提交等待商务审核", null, null, null, null, null, null, null, null, null, Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value), type, Convert.ToInt64(cmbUserName.SelectedValue), Convert.ToDecimal(txtCitySum.Text == "" ? "0" : txtCitySum.Text), Convert.ToDecimal(txtCityWages.Text == "" ? "0" : txtCityWages.Text),hasTax);
            //    }
            //    ret = new T_ExpenseAllocationTableAdapter().MyInsert("", SalerId, txtTableNo.Text, Convert.ToInt64(txtCustomerName.Tag), txtProjectName.Text, Convert.ToInt64(txtProductName.Tag), txtType.Text, Amount, deliverPrice, Math.Round(deliverSum, 2), salePrice, Math.Round(SaleSum, 2), 0, Math.Round(saleWages, 2), commissionPrice, Math.Round(commissionSum, 2), Math.Round(saleCommission, 2), agentPrice, Math.Round(agentSum, 2), Math.Round(agentCommission, 2), isPaid, null, "已提交等待商务审核", null, null, null, null, null, null, null, null, null, Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value), type, Convert.ToInt64(cmbUserName.SelectedValue), Convert.ToDecimal(txtCitySum.Text == "" ? "0" : txtCitySum.Text), Convert.ToDecimal(txtCityWages.Text == "" ? "0" : txtCityWages.Text), hasTax);

            //    if ((long)ret > 0)
            //    {
            //        ret = new T_SaleDetailsTableAdapter().UpdateExById(ret.ToString(), Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value));
            //        MessageBox.Show("已提交");
            //        btnApply.Enabled = false;
            //    }
            //    else
            //    {
            //        MessageBox.Show("提交失败");
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //this.DialogResult = System.Windows.Forms.DialogResult.OK;

            try
            {
                decimal deliverPrice = 0, salePrice = 0, commissionPrice = 0, agentPrice = 0, deliverSum = 0, SaleSum = 0, DepartSum = 0, saleWages = 0, commissionSum = 0, saleCommission = 0, agentSum = 0, agentCommission = 0,citySalePrice=0,citySaleSum=0,citySaleCommission=0;
                long Amount;
                if (string.IsNullOrEmpty(txtAgentPrice.Text) == true) txtAgentPrice.Text = "0"; //代理商单价为空则置0

                if (ComputeNums() == 1) return;//计算 异常则退出
                Amount = Convert.ToInt64(txtAmount.Text);
                deliverPrice = Convert.ToDecimal(txtDeliverPrice.Text); //发货单价
                deliverSum = Convert.ToDecimal(txtDeliverSum.Text);     //发货额
                salePrice = Convert.ToDecimal(txtSalePrice.Text);       //销售单价
                SaleSum = Convert.ToDecimal(txtSaleSum.Text);           //销售额
                DepartSum = Convert.ToDecimal(txtDepartSum.Text);       //部门销售额
                saleWages = Convert.ToDecimal(txtSaleWages.Text);       //销售工资
                commissionPrice = Convert.ToDecimal(txtCommissionPrice.Text);//提成单价
                commissionSum = Convert.ToDecimal(txtCommissionSum.Text);    //提成销售额
                saleCommission = Convert.ToDecimal(txtSaleCommission.Text);   //销售提成
                agentPrice = Convert.ToDecimal(txtAgentPrice.Text);     //代理商单价
                agentSum = Convert.ToDecimal(txtAgentSum.Text);         //代理商额度
                agentCommission = Convert.ToDecimal(txtAgentCommission.Text);//代理商提成
                citySalePrice = Convert.ToDecimal(txtCitySalePrice.Text); //跨区域单价
                citySaleSum = Convert.ToDecimal(txtCitySaleSum.Text);  //跨区域销售额
                citySaleCommission = Convert.ToDecimal(txtCitySaleCommission.Text); //跨区域提成

                if (deliverPrice < salePrice + commissionPrice + agentPrice + citySalePrice)
                {
                    MessageBox.Show("销售单价、提成单价、代理商单价、跨区销售单价之和不能大于发货单价");
                    return;
                }

                if (cmbUserName.Visible == true && cmbUserName.SelectedIndex == -1 && Convert.ToInt32(txtPercent.Text) !=0)
                {
                    //如果跨区销售下拉框为可见 且未选择 且 分成不为0
                    MessageBox.Show("请选择跨区域销售");
                    return;
                }
                string isPaid, hasTax;
                object ret;
                if (cbTax.Checked == true)
                {
                    hasTax = "含税";
                }
                else
                {
                    hasTax = "不含税";
                }

                if (cbIsPaid.Checked == true)
                {
                    isPaid = "已付款";
                }
                else
                {
                    isPaid = "未付款";
                }
                ret = new T_ExpenseAllocationTableAdapter().MyInsert("", SalerId, txtTableNo.Text, Convert.ToInt64(txtCustomerName.Tag), txtProjectName.Text, Convert.ToInt64(txtProductName.Tag), txtType.Text, Amount, deliverPrice, Math.Round(deliverSum, 2), salePrice, Math.Round(SaleSum, 2), Math.Round(DepartSum, 2), Math.Round(saleWages, 2), commissionPrice, Math.Round(commissionSum, 2), Math.Round(saleCommission, 2), agentPrice, Math.Round(agentSum, 2), Math.Round(agentCommission, 2), isPaid, null, "已提交等待商务审核", null, null, null, null, null, null, null, null, null, Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value), type, Convert.ToInt64(cmbUserName.SelectedValue), Convert.ToDecimal(txtCitySum.Text == "" ? "0" : txtCitySum.Text), Convert.ToDecimal(txtCityWages.Text == "" ? "0" : txtCityWages.Text), hasTax, Math.Round(citySalePrice, 2), Math.Round(citySaleSum, 2), Math.Round(citySaleCommission, 2));

                if ((long)ret > 0)
                {
                    ret = new T_SaleDetailsTableAdapter().UpdateExById(ret.ToString(), Convert.ToInt64(mRow.Cells["idDataGridViewTextBoxColumn"].Value));
                    MessageBox.Show("已提交");
                    btnApply.Enabled = false;
                }
                else
                {
                    MessageBox.Show("提交失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            this.DialogResult = System.Windows.Forms.DialogResult.OK; 
            
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {
            if (isLoading ==true) return ; //窗口加载时不引发事件
            ComputeNums();
        }

        private int ComputeNums() //自动计算界面数值
        {
            if (string.IsNullOrEmpty(txtAmount.Text) == false)
            {
                try
                {
                    decimal deliverPrice, salePrice, commissionPrice, agentPrice, CitySalePrice, deliverSum, SaleSum, saleWages, commissionSum, citySaleSum, citySaleCommission, saleCommission, agentSum, agentCommission;
                    long Amount;
                    Amount = Convert.ToInt64(txtAmount.Text);
                    if (string.IsNullOrEmpty(txtDeliverPrice.Text) == false)
                    {
                        deliverPrice = Convert.ToDecimal(txtDeliverPrice.Text); //发货单价
                        deliverSum = deliverPrice * Amount;                    //发货额
                        txtDeliverSum.Text = deliverSum.ToString("0.00");
                    }
                    txtCitySum.Text = "0";
                    txtCityWages.Text = "0";
                    txtCitySaleSum.Text = "0";
                    txtCitySaleCommission.Text = "0";

                    if (txtSalePrice.Text == "") //销售单价
                    {
                        txtSalePrice.Text = "0";
                        txtSalePrice.SelectionStart = 0;
                        txtSalePrice.SelectionLength = 1;
                    }

                    if (txtCommissionPrice.Text == "") //提成单价
                    {
                        txtCommissionPrice.Text = "0";
                        txtCommissionPrice.SelectionStart = 0;
                        txtCommissionPrice.SelectionLength = 1;
                    }

                    if (txtAgentPrice.Text == "") //代理商单价
                    {
                        txtAgentPrice.Text = "0";
                        txtAgentPrice.SelectionStart = 0;
                        txtAgentPrice.SelectionLength = 1;
                    }

                    if (txtCitySalePrice.Text == "")//跨区销售单价
                    {
                        txtCitySalePrice.Text = "0";
                        txtCitySalePrice.SelectionStart = 0;
                        txtCitySalePrice.SelectionLength = 1;
                    }

                    if (txtPercent.Text == "") //跨区分成
                    {
                        txtPercent.Text = "0";
                        txtPercent.SelectionStart = 0;
                        txtPercent.SelectionLength = 1;
                    }

                    if (type == "个人订单" || type == "部门订单" || type == "跨区域订单")
                    {
                        if (string.IsNullOrEmpty(txtSalePrice.Text) == false)
                        {
                            salePrice = Convert.ToDecimal(txtSalePrice.Text);       //销售单价
                            if (rbPersonal.Checked == true) //个人订单
                            {
                                SaleSum = salePrice * Amount;                           //销售额
                                txtSaleSum.Text = SaleSum.ToString();
                                saleWages = SaleSum / 100;                              //销售工资
                                txtSaleWages.Text = saleWages.ToString("0.00");
                            }
                            else if (rbDepart.Checked == true) //部门订单
                            {

                                //
                                agentSum = 0;
                                if (string.IsNullOrEmpty(txtAgentPrice.Text) == false)
                                {
                                    //代理商单价不为空
                                    agentPrice = Convert.ToDecimal(txtAgentPrice.Text);     //代理商单价
                                    agentSum = agentPrice * Amount;
                                }
                                //
                                SaleSum = (Convert.ToDecimal(txtDeliverPrice.Text) * Amount) - agentSum;                           //销售额
                                //SaleSum = SaleSum / 5;
                                //txtSaleSum.Text = (SaleSum / 5).ToString();               //个人销售额
                                //saleWages = SaleSum / 500;                              //销售工资

                                txtSaleSum.Text = (SaleSum / 5 / 100 * (100 - Convert.ToDecimal(txtPercent.Text))).ToString("0.00");
                                txtCitySum.Text = (SaleSum / 5 / 100 * Convert.ToDecimal(txtPercent.Text)).ToString("0.00");
                                saleWages = SaleSum / 500;                              //销售工资
                                txtSaleWages.Text = (saleWages / 100 * (100 - Convert.ToDecimal(txtPercent.Text))).ToString("0.00");
                                txtCityWages.Text = (saleWages / 100 * Convert.ToDecimal(txtPercent.Text)).ToString("0.00");
                                //跨区域提成
                                CitySalePrice = Convert.ToDecimal(txtCitySalePrice.Text);
                                citySaleSum = CitySalePrice * Amount;
                                txtCitySaleSum.Text = citySaleSum.ToString("0.00");
                                citySaleCommission = (citySaleSum / (decimal)1.17) / 5;
                                txtCitySaleCommission.Text = citySaleCommission.ToString("0.00");

                                //txtSaleWages.Text = saleWages.ToString("0.00");
                                txtDepartSum.Text = (SaleSum * 4 / 5).ToString("0.00"); //部门销售额
                            }
                            else //跨区域订单
                            {
                                SaleSum = salePrice * Amount;                           //销售额
                                txtSaleSum.Text = (SaleSum / 100 * (100 - Convert.ToDecimal(txtPercent.Text))).ToString("0.00");
                                txtCitySum.Text = (SaleSum / 100 * Convert.ToDecimal(txtPercent.Text)).ToString("0.00");
                                saleWages = SaleSum / 100;                              //销售工资
                                txtSaleWages.Text = (saleWages / 100 * (100 - Convert.ToDecimal(txtPercent.Text))).ToString("0.00");
                                txtCityWages.Text = (saleWages / 100 * Convert.ToDecimal(txtPercent.Text)).ToString("0.00");
                                //跨区域提成
                                CitySalePrice = Convert.ToDecimal(txtCitySalePrice.Text);
                                citySaleSum = CitySalePrice * Amount;
                                txtCitySaleSum.Text = citySaleSum.ToString("0.00");
                                citySaleCommission = (citySaleSum / (decimal)1.17) / 5;
                                txtCitySaleCommission.Text = citySaleCommission.ToString("0.00");
                            }
                        }
                        if (string.IsNullOrEmpty(txtCommissionPrice.Text) == false)
                        {
                            commissionPrice = Convert.ToDecimal(txtCommissionPrice.Text);//提成单价
                            commissionSum = commissionPrice * Amount;               //提成销售额
                            txtCommissionSum.Text = commissionSum.ToString();
                            saleCommission = (commissionSum / (decimal)1.17) / 5;   //销售提成
                            txtSaleCommission.Text = saleCommission.ToString("0.00");
                        }
                    }
                    else if (type == "公司跟单")
                    {
                        txtSalePrice.Text = "0";
                        txtSaleSum.Text = "0";
                        txtSaleWages.Text = "0";
                        txtDepartSum.Text = "0";
                    }
                    if (string.IsNullOrEmpty(txtAgentPrice.Text) == false)
                    {
                        //代理商单价不为空
                        agentPrice = Convert.ToDecimal(txtAgentPrice.Text);     //代理商单价
                        agentSum = agentPrice * Amount;                         //代理商额度
                        txtAgentSum.Text = agentSum.ToString("0.00");
                        if (rbCompany.Checked == true)
                        {
                            //公司跟单
                            if (cbTax.Checked == true)
                            {
                                //销售含税
                                agentCommission = agentSum * (decimal)0.75;             //代理商税后佣金
                                txtAgentCommission.Text = agentCommission.ToString("0.00");
                            }
                            else
                            {
                                //销售不含税
                                txtAgentCommission.Text = txtAgentSum.Text;
                            }
                        }
                        else
                        {
                            //个人订单\部门订单\跨区域订单
                            agentCommission = agentSum / (decimal)1.25;             //代理商税后佣金
                            txtAgentCommission.Text = agentCommission.ToString("0.00");
                        }
                    }
                    return 0;
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return 1;
                }
            }
            return 1;
        }

        private void rbPersonal_CheckedChanged(object sender, EventArgs e)
        {
            type = rbPersonal.Text;
            //label2.Visible = false;
            //txtDepartSum.Visible = false;
            //txtSalePrice.ReadOnly = false;
            //txtCommissionPrice.ReadOnly = false;
            txtAmount_Leave(sender, e);

            SetTableNo();

        }

        private void rbDepart_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDepart.Checked == true)
            {
                type = rbDepart.Text;
                label2.Visible = true;
                txtDepartSum.Visible = true;
                //txtSalePrice.ReadOnly = false;
                //txtCommissionPrice.ReadOnly = false;
                txtAmount_Leave(sender, e);
                labSalePrice.Visible = false;
                txtSalePrice.Visible = false;
                labCommissionPrice.Visible = false;
                txtCommissionPrice.Visible = false;
                labCommissionSum.Visible = false;
                txtCommissionSum.Visible = false;
                labSaleCommission.Visible = false;
                txtSaleCommission.Visible = false;

                labCity.Visible = true;
                cmbUserName.Visible = true;
                //if (ExId == -1)
                //{
                    labPercent.Visible = true;
                    txtPercent.Visible = true;
                    labChar.Visible = true;
                //}

                labCitySum.Visible = true;
                txtCitySum.Visible = true;
                labCityWages.Visible = true;
                txtCityWages.Visible = true;
                labCitySalePrice.Visible = true;
                txtCitySalePrice.Visible = true;
                labCitySaleSum.Visible = true;
                txtCitySaleSum.Visible = true;
                labCitySaleCommission.Visible = true;
                txtCitySaleCommission.Visible = true;
                cmbUserName.ValueMember = "id";
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
                cmbUserName.SelectedIndex = -1;
                txtPercent.Text = "0";
                SetTableNo();
            }
            else
            {
                label2.Visible = false;
                txtDepartSum.Visible = false;
                labSalePrice.Visible = true;
                txtSalePrice.Visible = true;
                labCommissionPrice.Visible = true;
                txtCommissionPrice.Visible = true;
                labCommissionSum.Visible = true;
                txtCommissionSum.Visible = true;
                labSaleCommission.Visible = true;
                txtSaleCommission.Visible = true;

                labCity.Visible = false;
                cmbUserName.Visible = false;
                labPercent.Visible = false;
                txtPercent.Visible = false;
                labChar.Visible = false;
                labCitySum.Visible = false;
                txtCitySum.Visible = false;
                labCityWages.Visible = false;
                txtCityWages.Visible = false;
                labCitySalePrice.Visible = false;
                txtCitySalePrice.Visible = false;
                labCitySaleSum.Visible = false;
                txtCitySaleSum.Visible = false;
                labCitySaleCommission.Visible = false;
                txtCitySaleCommission.Visible = false;
                txtCitySalePrice.Text = "0";
            }

        }

        private void rbCompany_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCompany.Checked == true)
            {
                type = rbCompany.Text;
                //label2.Visible = false;
                //txtDepartSum.Visible = false;
                txtSalePrice.Text = "0";
                txtCommissionPrice.Text = "0";
                txtSalePrice.ReadOnly = true;
                txtCommissionPrice.ReadOnly = true;
                txtAmount_Leave(sender, e);
                //label12.Visible = true;
                //dtpPaidDate.Visible = true;
                //cbIsPaid.Visible = true;
                cbTax.Visible = true;
                SetTableNo();
            }
            else
            {
                txtSalePrice.ReadOnly = false;
                txtCommissionPrice.ReadOnly = false;
                //label12.Visible = false;
                //dtpPaidDate.Visible = false;
                //cbIsPaid.Visible = false;
                cbTax.Visible = false;
            }

        }

        private void rbCity_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCity.Checked == true)
            {
                type = rbCity.Text;
                labCity.Visible = true;
                cmbUserName.Visible = true;
                //if (ExId == -1)
                //{
                    labPercent.Visible = true;
                    txtPercent.Visible = true;
                    labChar.Visible = true;
                //}

                labCitySum.Visible = true;
                txtCitySum.Visible = true;
                labCityWages.Visible = true;
                txtCityWages.Visible = true;
                labCitySalePrice.Visible = true;
                txtCitySalePrice.Visible = true;
                labCitySaleSum.Visible = true;
                txtCitySaleSum.Visible = true;
                labCitySaleCommission.Visible = true;
                txtCitySaleCommission.Visible = true;
                cmbUserName.ValueMember = "id";
                cmbUserName.DisplayMember = "UserName";
                cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();
                cmbUserName.SelectedIndex = -1;
                txtPercent.Text = "70";
                SetTableNo();
            }
            else
            {
                labCity.Visible = false;
                cmbUserName.Visible = false;
                labPercent.Visible = false;
                txtPercent.Visible = false;
                labChar.Visible = false;
                labCitySum.Visible = false;
                txtCitySum.Visible = false;
                labCityWages.Visible = false;
                txtCityWages.Visible = false;
                labCitySalePrice.Visible = false;
                txtCitySalePrice.Visible = false;
                labCitySaleSum.Visible = false;
                txtCitySaleSum.Visible = false;
                labCitySaleCommission.Visible = false;
                txtCitySaleCommission.Visible = false;
                txtCitySalePrice.Text = "0";

            }
        }

        private void btnModifyPaid_Click(object sender, EventArgs e)
        {
            try
            {
                int ret = 0;
                string isPaid = "";
                if (cbIsPaid.Checked == true)
                {
                    isPaid = "已付款";
                    ret = new T_ExpenseAllocationTableAdapter().UpdateIsPaid(isPaid, dtpPaidDate.Value, ExId);
                }
                else
                {
                    isPaid = "未付款";
                    ret = new T_ExpenseAllocationTableAdapter().UpdateIsPaid(isPaid, null, ExId);
                }
                if (ret > 0)
                {
                    MessageBox.Show("付款信息修改成功");
                }
                else
                {
                    MessageBox.Show("付款信息修改失败");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbIsPaid_CheckedChanged(object sender, EventArgs e)
        {
            if (cbIsPaid.Checked == true)
            {
                label12.Visible = true;
                dtpPaidDate.Visible = true;
            }
            else
            {
                label12.Visible = false;
                dtpPaidDate.Visible = false;
            }
        }


    }
}
