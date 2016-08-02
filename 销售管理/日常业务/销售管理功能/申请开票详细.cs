using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using 销售管理.DAL.DataSetInvoiceTableAdapters;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetInvoiceOutStockTableAdapters;
using ExcelApplication = Microsoft.Office.Interop.Excel.Application;
using ExcelBook = Microsoft.Office.Interop.Excel.Workbook;
using ExcelSheet = Microsoft.Office.Interop.Excel.Worksheet;
using 销售管理.DAL.DataSetSaleDetailsTableAdapters;
using Common;

namespace 销售管理.日常业务
{
    public partial class 申请开票详细 : Form
    {
        public 申请开票详细()
        {
            InitializeComponent();
        }
        public long mId = -1;
        public bool isModify = false;
        public DataTable[] mInvoiceDatails = new DataTable[9];

        private void 申请开票_Load(object sender, EventArgs e)
        {
            //获取销售名单
            cmbUserName.DisplayMember = "UserName";
            cmbUserName.ValueMember = "id";
            cmbUserName.DataSource = new T_UsersTableAdapter().GetSalers();

            if (!Common.AuthenticateRight.AuthOperation(110402) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUserName.SelectedValue = Classes.PubClass.UserId;//cmbUserName.fin (Classes.PubClass.UserName);
                cmbUserName.Enabled = false;
            }

            if (mId > -1)
            {
                var table = new T_InvoiceQTableAdapter().GetDataById(mId);
                if (table.Rows.Count > 0)
                {
                    var row = (销售管理.DAL.DataSetInvoice.T_InvoiceQRow)table.Rows[0];
                    cmbUserName.SelectedIndex = cmbUserName.FindStringExact(row.UserName);
                    cmbCustomerName.SelectedIndex = cmbCustomerName.FindStringExact(row.CustomerName);
                    string InvoiceContent = row.InvoiceContent;
                    //string[] contents = InvoiceContent.Split(new string[]{"!#!"},StringSplitOptions.None);
                    string[] contents = System.Text.RegularExpressions.Regex.Split(InvoiceContent, "!#!");
                    for (int i = 0; i < contents.Length - 3; i += 4)
                    {
                        Control control;
                        control = groupBox1.Controls.Find("txtName" + (mCount).ToString(), false)[0];
                        control.Text = contents[i];
                        control = groupBox1.Controls.Find("txtPrice" + (mCount).ToString(), false)[0];
                        control.Text = contents[i + 1];
                        control = groupBox1.Controls.Find("txtNum" + (mCount).ToString(), false)[0];
                        control.Text = contents[i + 2];
                        control = groupBox1.Controls.Find("txtSum" + (mCount).ToString(), false)[0];
                        control.Text = contents[i + 3];
                        //加载mInvoiceDetails
                        DataTable mSelected = new DataTable();
                        //添加标头
                        mSelected.Columns.Add("SaleDetailsId");
                        mSelected.Columns.Add("ProductName");
                        mSelected.Columns.Add("Price");
                        mSelected.Columns.Add("Amount");
                        mSelected.Columns.Add("SumMoney");
                        mSelected.Columns.Add("StockOutNo");
                        mSelected.Columns.Add("SaleDate");
                        //添加数据
                        var mdtInvoiceDetails = new T_InvoiceOutStockTableAdapter().GetDataByInvoiceIdAndSubId(mId, mCount);
                        if (mdtInvoiceDetails.Rows.Count > 0)
                        {
                            foreach (销售管理.DAL.DataSetInvoiceOutStock.T_InvoiceOutStockRow mRow in mdtInvoiceDetails.Rows)
                            {
                                mSelected.Rows.Add(mRow.SaleDetailsId,"",mRow.Price,mRow.Amount,mRow.SumMoney,"","");
                            }
                        }
                        mInvoiceDatails[mCount] = mSelected;

                        if (i < contents.Length - 7) linkLabel1_LinkClicked(sender, new LinkLabelLinkClickedEventArgs(new LinkLabel.Link(), MouseButtons.Left));
                    }
                    if (isModify == false)
                    {
                        foreach (Control control in groupBox1.Controls)
                        {
                            if (control.GetType() == typeof(LinkLabel))
                            {
                                control.Enabled = false;
                            }
                        }
                    }
                    dtpInvioceDate.Value = row.InvoiceDate;
                    cmbInvoiceType.Text = row.InvoiceType;
                    txtInvoiceNo.Text = row.InvoiceNo;
                    txtMoney.Text = row.InvoiceMoney.ToString("0.00");
                    txtStatus.Text = row.Status;
                    labStatus.Visible = true;
                    txtStatus.Visible = true;
                    
                    btnPrint.Visible = true;
                    if (txtStatus.Text.Contains("不通过") == true && isModify == true)
                    {
                        btnSave.Enabled = true;
                        btnDetails1.Text = "选择";
                    }
                    else
                    {
                        btnSave.Enabled = false;
                        btnDetails1.Text = "查看";
                    }

                }

            }

        }




        private void btnSave_Click(object sender, EventArgs e)
        {
            Decimal Money, MaxMoney;
            try
            {


                if (cmbUserName.SelectedIndex == -1)
                {
                    toolTip1.Show("请选择销售人员", cmbUserName, 0, cmbUserName.Height, 2000);
                    return;
                }
                if (cmbCustomerName.SelectedIndex == -1)
                {
                    toolTip1.Show("请选择客户名称", cmbCustomerName, 0, cmbCustomerName.Height, 2000);
                    return;
                }
                if (Decimal.TryParse(txtMoney.Text, out Money) == false)
                {
                    toolTip1.Show("金额必须输入数字", txtMoney, 0, txtMoney.Height, 2000);
                    return;
                }
                //组InvoiceContent
                string InvoiceContent = string.Empty;
                for (int i = 1; i <= mCount; i++)
                {
                    Control control;
                    //名称
                    control = groupBox1.Controls.Find("txtName" + i.ToString(), false)[0];
                    if (control.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("请输入开票名称" + i.ToString());
                        return;
                    }
                    InvoiceContent += control.Text.Trim() + "!#!";

                    //单价
                    control = groupBox1.Controls.Find("txtPrice" + i.ToString(), false)[0];
                    if (control.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("请选择出库单" + i.ToString());
                        return;
                    }
                    InvoiceContent += control.Text.Trim() + "!#!";

                    //数量
                    control = groupBox1.Controls.Find("txtNum" + i.ToString(), false)[0];
                    if (control.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("请选择出库单" + i.ToString());
                        return;
                    }
                    InvoiceContent += control.Text.Trim() + "!#!";

                    //金额
                    control = groupBox1.Controls.Find("txtSum" + i.ToString(), false)[0];
                    if (control.Text.Trim() == string.Empty)
                    {
                        MessageBox.Show("请选择出库单" + i.ToString());
                        return;
                    }
                    InvoiceContent += control.Text.Trim() + "!#!";
                }
                InvoiceContent = InvoiceContent.TrimEnd("!#!".ToCharArray()); //去除最后的分隔符

                //MaxMoney = Decimal.Parse(txtMaxMoney.Text);//最大可开金额
                //if (MaxMoney < Money)
                //{
                //    toolTip1.Show("金额不能大于最大可开金额", txtMoney, 0, txtMoney.Height, 2000);
                //    return;
                //}

                T_InvoiceTableAdapter adapter = new T_InvoiceTableAdapter();
                int ret = 0;
                long InvoiceId = 0;
                //if (mId == -1)
                //{

                using (var mConn = new SqlConnection(Common.CommonClass.SqlConnStr))
                {
                    mConn.Open();
                    using (var mTrans = mConn.BeginTransaction())
                    {
                        try
                        {
                            adapter.Connection = mConn;
                            adapter.Transaction = mTrans;
                            InvoiceId = (long)adapter.MyInsert(Convert.ToInt64(cmbUserName.SelectedValue), Convert.ToInt64(cmbCustomerName.SelectedValue), InvoiceContent, dtpInvioceDate.Value.Date, cmbInvoiceType.Text, Money, null, null, null, null, "已提交等待商务审核");
                            if (InvoiceId > 0)
                            {
                                T_InvoiceOutStockTableAdapter adInvoiceOutStock = new T_InvoiceOutStockTableAdapter();
                                adInvoiceOutStock.Connection = mConn;
                                adInvoiceOutStock.Transaction = mTrans;
                                decimal canInvoice = 0;
                                T_InvoiceNumTableAdapter inAdapter =new T_InvoiceNumTableAdapter();
                                inAdapter.Connection = mConn;
                                inAdapter.Transaction = mTrans;
                                for (int i = 1; i <= mCount; i++) //开票条目
                                {
                                    for (int m = 0; m < mInvoiceDatails[i].Rows.Count; m++) // 每个条目下的开票出库详细
                                    {
                                        //获取销售销售记录的当前最大可开票数量
                                        canInvoice = 0;
                                        canInvoice = Convert.ToDecimal(inAdapter.GetCanInvoiceNum(Convert.ToInt64(mInvoiceDatails[i].Rows[m]["SaleDetailsId"])));
                                        if (canInvoice < Convert.ToDecimal(mInvoiceDatails[i].Rows[m]["Amount"]))
                                        {
                                            mTrans.Rollback();
                                            MessageBox.Show("开票内容"+ i.ToString() +"中的第"+(m+1).ToString() +"条记录超过可开票数量");
                                            return;
                                        }
                                        ret = adInvoiceOutStock.Insert(InvoiceId, i, Convert.ToInt64(mInvoiceDatails[i].Rows[m]["SaleDetailsId"]), Convert.ToDecimal(mInvoiceDatails[i].Rows[m]["Price"]), Convert.ToDecimal(mInvoiceDatails[i].Rows[m]["Amount"]), Convert.ToDecimal(mInvoiceDatails[i].Rows[m]["SumMoney"]));
                                        if (ret < 1)
                                        {
                                            mTrans.Rollback();
                                            MessageBox.Show("提交失败");
                                        }
                                    }
                                }
                                mTrans.Commit();
                                MessageBox.Show("提交成功");
                                btnSave.Enabled = false;
                            }
                            else
                            {
                                mTrans.Rollback();
                                MessageBox.Show("提交失败");
                            }
                        }

                        catch (Exception ex)
                        {
                            mTrans.Rollback();
                            MessageBox.Show(ex.Message);
                        }
                    }
                }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void cmbUserName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbCustomerName.DisplayMember = "CompanyName";
            cmbCustomerName.ValueMember = "Id";
            cmbCustomerName.DataSource = new T_CustomersTableAdapter().GetDataByUserId(Convert.ToInt64(cmbUserName.SelectedValue));
            cmbCustomerName.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCustomerName.AutoCompleteSource = AutoCompleteSource.ListItems;
            cmbCustomerName.SelectedIndex = -1;
        }

        private void cmbCustomerName_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            //查询最大可开金额
            //txtMaxMoney.Text = "1000";
            try
            {
                //                string mSql = string.Format(@"SELECT a.SumMoney - b.SumMoney AS Expr1
                //FROM (SELECT isnull(SUM(SumMoney),0) AS SumMoney FROM T_SaleDetails
                //        WHERE (CustomerName = '{0}')) AS a CROSS JOIN
                //          (SELECT isnull(SUM(InvoiceMoney),0) AS SumMoney FROM T_Invoice
                //         WHERE (CustomerName = '{1}') and status not like '%不通过%') AS b", Convert.ToInt64(cmbCustomerName.SelectedValue), Convert.ToInt64(cmbCustomerName.SelectedValue));
                //                SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
                //                SqlCommand comm = new SqlCommand(mSql, conn);
                //                conn.Open();
                //                txtMaxMoney.Text = comm.ExecuteScalar().ToString();
                //                conn.Close();
                for (int i = 0; i < mInvoiceDatails.Length; i++)
                {
                    mInvoiceDatails[i] = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                txtMaxMoney.Text = "0";
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int mCount = 1;
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (mCount >= 8)
            {
                MessageBox.Show("最多只能8条记录");
                return;
            }
            mCount++;
            labContent.Text = "开票内容" + "\r\n" + mCount.ToString() + "条";
            //名称
            TextBox txtbox = new TextBox();
            txtbox.Name = "txtName" + (mCount).ToString();
            txtbox.Size = txtName1.Size;
            txtbox.Location = new Point(txtName1.Location.X, txtName1.Location.Y + 25 * (mCount - 1));
            txtbox.Parent = groupBox1;

            //单价
            TextBox txtbox1 = new TextBox();
            txtbox1.Name = "txtPrice" + (mCount).ToString();
            txtbox1.Size = txtPrice1.Size;
            txtbox1.Location = new Point(txtPrice1.Location.X, txtPrice1.Location.Y + 25 * (mCount - 1));
            txtbox1.TextChanged += new EventHandler(this.txtPrice1_TextChanged);
            txtbox1.KeyPress += new KeyPressEventHandler(this.txtPrice1_KeyPress);
            txtbox1.Parent = groupBox1;
            txtbox1.ReadOnly = true;

            //数量
            TextBox txtbox2 = new TextBox();
            txtbox2.Name = "txtNum" + (mCount).ToString();
            txtbox2.Size = txtNum1.Size;
            txtbox2.Location = new Point(txtNum1.Location.X, txtNum1.Location.Y + 25 * (mCount - 1));
            txtbox2.TextChanged += new EventHandler(this.txtPrice1_TextChanged);
            txtbox2.KeyPress += new KeyPressEventHandler(this.txtPrice1_KeyPress);
            txtbox2.Parent = groupBox1;
            txtbox2.ReadOnly = true;

            //金额
            TextBox txtbox3 = new TextBox();
            txtbox3.Name = "txtSum" + (mCount).ToString();
            txtbox3.Size = txtSum1.Size;
            txtbox3.Location = new Point(txtSum1.Location.X, txtSum1.Location.Y + 25 * (mCount - 1));
            txtbox3.TextChanged += new EventHandler(this.txtSum1_TextChanged);
            txtbox3.ReadOnly = true;
            txtbox3.Parent = groupBox1;
            txtbox3.ReadOnly = true;

            //选择
            Button btn1 = new Button();
            btn1.Name = "btnDetails" + (mCount).ToString();
            if (mId > 0 && isModify == false)
            {
                btn1.Text = "查看";
            }
            else
            {
                btn1.Text = "选择";
            }
            btn1.Tag = mCount.ToString();
            btn1.Size = btnDetails1.Size;
            btn1.Location = new Point(btnDetails1.Location.X, btnDetails1.Location.Y + 25 * (mCount - 1));
            btn1.Click += new EventHandler(this.btnDetails1_Click);
            btn1.Parent = groupBox1;

            //修改新增为删除
            //Control[] controls = groupBox1.Controls.Find("llAdd" + (mCount - 1).ToString(), false);
            //foreach (Control control in controls)
            //{
            //    if (control.Text.ToString() == "新增")
            //    {
            //        control.Text = "删除";
            //        ((LinkLabel)control).LinkClicked -= new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            //        ((LinkLabel)control).LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            //    }
            //}

            //新增
            LinkLabel button = new LinkLabel();
            button.Size = llAdd1.Size;
            button.Name = "llAdd" + mCount.ToString();
            button.Text = "删除";
            button.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            button.Location = new Point(llAdd1.Location.X, llAdd1.Location.Y + 25 * (mCount - 1));
            button.Parent = groupBox1;

            this.Height += 25;

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //MessageBox.Show("删除了");
            LinkLabel ll = (LinkLabel)sender;
            int index = Convert.ToInt32(ll.Name.ToString().Replace("llAdd", ""));
            for (int i = index; i < mCount; i++)
            {
                Control control, control1;
                //名称
                control = groupBox1.Controls.Find("txtName" + i.ToString(), false)[0];
                control1 = groupBox1.Controls.Find("txtName" + (i + 1).ToString(), false)[0];
                control.Text = control1.Text;

                //单价
                control = groupBox1.Controls.Find("txtPrice" + i.ToString(), false)[0];
                control1 = groupBox1.Controls.Find("txtPrice" + (i + 1).ToString(), false)[0];
                control.Text = control1.Text;

                //数量
                control = groupBox1.Controls.Find("txtNum" + i.ToString(), false)[0];
                control1 = groupBox1.Controls.Find("txtNum" + (i + 1).ToString(), false)[0];
                control.Text = control1.Text;

                //金额
                control = groupBox1.Controls.Find("txtSum" + i.ToString(), false)[0];
                control1 = groupBox1.Controls.Find("txtSum" + (i + 1).ToString(), false)[0];
                control.Text = control1.Text;

                //出库单详细
                mInvoiceDatails[i] = mInvoiceDatails[i + 1];

            }
            //删除
            groupBox1.Controls.RemoveByKey("txtName" + mCount.ToString()); //名称
            groupBox1.Controls.RemoveByKey("txtPrice" + mCount.ToString());//单价
            groupBox1.Controls.RemoveByKey("txtNum" + mCount.ToString());//数量
            groupBox1.Controls.RemoveByKey("txtSum" + mCount.ToString());//金额
            groupBox1.Controls.RemoveByKey("llAdd" + mCount.ToString());//按钮
            mInvoiceDatails[mCount] = null;

            mCount--;
            //修改最后一个linklab的时间
            //ll = (LinkLabel)groupBox1.Controls.Find("llAdd" + mCount.ToString(), false)[0];
            //if (ll.Text == "删除")
            //{
            //    ll.LinkClicked += new LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            //    ll.LinkClicked -= new LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            //    ll.Text = "新增";
            //}
            this.Height -= 25;
            labContent.Text = "开票内容" + "\r\n" + mCount.ToString() + "条";
            //调用 计算金额
            txtSum1_TextChanged(sender, e);
        }

        private void txtSum1_TextChanged(object sender, EventArgs e)
        {
            Decimal sum = 0, sum1 = 0;
            for (int i = 1; i <= mCount; i++)
            {
                Control control;
                //金额
                control = groupBox1.Controls.Find("txtSum" + i.ToString(), false)[0];
                if (Decimal.TryParse(control.Text, out sum1) == true)
                {
                    sum += sum1;
                }

            }
            txtMoney.Text = sum.ToString();
        }

        private void txtPrice1_TextChanged(object sender, EventArgs e)
        {
            Decimal price = 0, num = 0;
            for (int i = 1; i <= mCount; i++)
            {
                Control cPrice, cNum, cSum;
                cPrice = groupBox1.Controls.Find("txtPrice" + i.ToString(), false)[0]; //单价
                cNum = groupBox1.Controls.Find("txtNum" + i.ToString(), false)[0];//数量
                cSum = groupBox1.Controls.Find("txtSum" + i.ToString(), false)[0];//金额
                if (Decimal.TryParse(cPrice.Text, out price) == true && Decimal.TryParse(cNum.Text, out num) == true)
                {
                    cSum.Text = (price * num).ToString();
                }
            }

        }

        private void txtPrice1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ("0123456789.".IndexOf(e.KeyChar) < 0 && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void btnDetails1_Click(object sender, EventArgs e)
        {
            if (cmbCustomerName.SelectedIndex == -1)
            {
                MessageBox.Show("请先选择客户");
                return;
            }
            int currentIndex = Convert.ToInt32((sender as Button).Tag);
            if ((sender as Button).Text == "选择")
            {
                using (var m_form = new 开票选择销售明细())
                {
                    string tempCant = "";
                    for (int i = 1; i < mInvoiceDatails.Length; i++)
                    {
                        if (mInvoiceDatails[i] != null)
                        {
                            if (i == currentIndex) continue;

                            foreach (DataRow tempRow in mInvoiceDatails[i].Rows)
                            {
                                tempCant += tempRow["SaleDetailsId"].ToString() + ",";
                            }
                        }
                    }
                    m_form.cantSelect = tempCant.TrimEnd(',');


                    m_form.m_CustomerId = (long)cmbCustomerName.SelectedValue;
                    if (mInvoiceDatails[currentIndex] != null)
                        m_form.mSelected = mInvoiceDatails[currentIndex];
                    if (m_form.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {

                        mInvoiceDatails[currentIndex] = m_form.mSelected;
                        if (m_form.mSelected != null)
                        {
                            //获取单价,数量
                            Control cPrice, cNum, cSum;
                            cPrice = groupBox1.Controls.Find("txtPrice" + currentIndex.ToString(), false)[0]; //单价
                            cNum = groupBox1.Controls.Find("txtNum" + currentIndex.ToString(), false)[0];//数量
                            cSum = groupBox1.Controls.Find("txtSum" + currentIndex.ToString(), false)[0];//金额

                            cPrice.Text = mInvoiceDatails[currentIndex].Rows[0]["Price"].ToString();

                            int totalAmount = 0;
                            foreach (DataRow mRow in mInvoiceDatails[currentIndex].Rows)
                            {
                                totalAmount += Convert.ToInt32(mRow["Amount"]);
                            }
                            cNum.Text = totalAmount.ToString();
                            cSum.Text = (Convert.ToDecimal(cPrice.Text) * totalAmount).ToString();
                            cmbCustomerName.Enabled = false;
                        }
                        else
                        {
                            //获取单价,数量
                            Control cPrice, cNum, cSum;
                            cPrice = groupBox1.Controls.Find("txtPrice" + currentIndex.ToString(), false)[0]; //单价
                            cNum = groupBox1.Controls.Find("txtNum" + currentIndex.ToString(), false)[0];//数量
                            cSum = groupBox1.Controls.Find("txtSum" + currentIndex.ToString(), false)[0];//金额

                            cPrice.Text = "";
                            cNum.Text = "";
                            cSum.Text = "";
                        }
                    }

                }
            }
            else
            {
                //开票查看销售明细
                using (var m_form = new 开票查看销售明细())
                {
                    m_form.mInvoiceId = mId;
                    m_form.mSubId = currentIndex;
                    //获取单价,数量
                    Control cPrice, cNum, cSum, cName;
                    cName = groupBox1.Controls.Find("txtName" + currentIndex.ToString(), false)[0]; //名称
                    cPrice = groupBox1.Controls.Find("txtPrice" + currentIndex.ToString(), false)[0]; //单价
                    cNum = groupBox1.Controls.Find("txtNum" + currentIndex.ToString(), false)[0];//数量
                    cSum = groupBox1.Controls.Find("txtSum" + currentIndex.ToString(), false)[0];//金额

                    m_form.txtName.Text = cName.Text;
                    m_form.txtPrice.Text = cPrice.Text;
                    m_form.txtNum.Text = cNum.Text;
                    m_form.txtSum.Text = cSum.Text;
                    m_form.label1.Text = "第" + currentIndex.ToString() + "项";
                    m_form.ShowDialog();
                }
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                //获取开票销售记录详细
                string mSql = string.Format("select ios.*,p.name,sd.stockoutno,sd.saledate,sd.Unit from t_invoiceoutstock ios left join t_saledetails sd on sd.id = ios.saledetailsid left join t_products p on p.id = sd.productname where ios.invoiceid = {0}", mId);

                SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
                SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
                DataTable mTable = new DataTable();
                try
                {
                    adapter.Fill(mTable);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                int mCount = 15;
                int n = 0;
                for (int m = 0; m < mTable.Rows.Count; m += mCount)
                {
                    //打开EXCEL
                    

                    ExcelApplication mExcel = new ExcelApplication();
                    ExcelBook mBook = mExcel.Workbooks.Open(Application.StartupPath + "\\office\\出库单.xlt");
                    ExcelSheet mSheet = mBook.Sheets[1];
                    mExcel.DisplayAlerts = false;
                    mSheet.Cells[3, 2] = cmbCustomerName.Text;
                    for (int i = 0; i < ((mTable.Rows.Count - m) > mCount ? mCount : mTable.Rows.Count - m); i++)
                    {
                        mSheet.Cells[5 + i, 1] = mTable.Rows[n]["name"];  //产品名称
                        mSheet.Cells[5 + i, 2] = mTable.Rows[n]["Unit"];//单位
                        mSheet.Cells[5 + i, 3] = mTable.Rows[n]["Amount"];//数量
                        mSheet.Cells[5 + i, 4] = mTable.Rows[n]["Price"];//单价
                        mSheet.Cells[5 + i, 5] = mTable.Rows[n]["SumMoney"];//金额
                        mSheet.Cells[5 + i, 6] = mTable.Rows[n]["saledate"];//出库时间
                        mSheet.Cells[5 + i, 7] = mTable.Rows[n]["stockoutno"];//原出库单编号
                        n++;
                    }
                    mSheet.Cells[20, 1] = "打印时间:" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");

                    mExcel.Visible = true;
                    mSheet = null;
                    //mBook.Close();
                    mBook = null;
                    //mExcel.Quit();
                    mExcel = null;
                }



            }
            catch (Exception ex)
            {

            }
            finally
            {
                GC.Collect();
            }
        }


    }
}
