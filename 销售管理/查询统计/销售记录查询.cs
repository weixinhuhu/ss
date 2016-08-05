using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Owc11;
using Microsoft.Reporting.WinForms;
using 销售管理.DAL.DataSetProductsTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using System.Data.SqlClient;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.IO;
using 销售管理.DAL.DataSetPromaryTableAdapters;
using 销售管理.DAL.DataSetCustomersTableAdapters;
using Common;

namespace 销售管理.查询统计
{
    public partial class 销售记录查询 : 销售管理.UserControlBase
    {
        Int64 mProductId = 0;
        public 销售记录查询()
        {
            InitializeComponent();
        }

        private void 销售记录查询_Load(object sender, EventArgs e)
        {
            cmbProducts1.Items.Add("查询所有");
            var mTable = new T_ProductsTableAdapter().GetDataByLevel(1); //获取level1的产品
            foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
            {
                cmbProducts1.Items.Add(new Classes.PubClass.MyCmbList(mRow.Id, mRow.Name));
            }
            cmbProducts1.SelectedIndex = 0;
            //获取销售列表
            var mTable1 = new T_UsersTableAdapter().GetSalers();
            foreach (销售管理.DAL.DataSetUsers.T_UsersRow mRow in mTable1.Rows)
            {
                cmbUsername.Items.Add(new Classes.PubClass.MyCmbList(mRow.id, mRow.UserName));
            }
            cmbUsername.Items.Insert(0, "查询所有");
            cmbUsername.SelectedIndex = 0;
            //获取省 不用数据绑定是因为要添加 查询所有
            cmbPromary.Items.Add("查询所有");
            var mTable2 = new T_PromaryTableAdapter().GetData();
            foreach (销售管理.DAL.DataSetPromary.T_PromaryRow mRow in mTable2.Rows)
            {
                cmbPromary.Items.Add(new Classes.PubClass.MyCmbList(mRow.proID, mRow.proName));
            }

            cmbPromary.SelectedIndex = 0;

            rbDetails.Checked = true;
            //是否开票选项
            lbInvoiceFlag.Visible = true; 
            CmbInvoiceFlag.Visible = true;

            //MakeLineChart();

            if (!Common.AuthenticateRight.AuthOperation(140101) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUsername.SelectedIndex = cmbUsername.FindStringExact(Classes.PubClass.UserName);
                cmbUsername.Enabled = false;
                rbSalerSum.Visible = false;

            }

            //是否开票
            CmbInvoiceFlag.SelectedIndex = 0;



        }
        private void MakeLineChart(DataTable mDataTable)//string[] DataName,string[] Data,string[] Data1, string[] Data2)
        {

            //Y坐标轴

            //string[] DataName = { "星期一", "星期二", "星期三", "星期四", "星期五", "星期六", "星期日" };
            //string[] DataName = { "一", "二", "三", "四", "五", "六", "日" };
            //第一条曲线的数据

            //int[] Data = { 0, 10, 20, 100, 40, 50, 60 };

            //第二条曲线的数据

            //int[] Data1 = { 100, 50, 41, 86 };

            //第三条曲线的数据

            // int[] Data2 = { 10, 50, 100, 30, 50, 60, 200 };

            string strValue1 = "";

            string strValue = "";

            string strValue2 = "";

            string strCateory = "";

            //循环取得数据并格式化为OWC10需要的格式,(加'\t')
            foreach (DataRow mRow in mDataTable.Rows)
            {
                strCateory += mRow[0].ToString() + '\t';
                strValue += mRow[1].ToString() + '\t';
                strValue1 += mRow[2].ToString() + '\t';
            }



            //for (int i = 0; i < DataName.Length; i++)
            //{

            //    strCateory += DataName[i] + '\t';

            //}


            //for (int i = 0; i < Data.Length; i++)
            //{

            //    strValue += Data[i] + '\t';

            //}

            //for (int i = 0; i < Data1.Length; i++)
            //{

            //    strValue1 += Data1[i] + '\t';

            //}

            //for (int i = 0; i < Data2.Length; i++)
            //{

            //    strValue2 += Data2[i] + '\t';

            //}


            ChartSpace mySpace = new ChartSpace();
            ChChart myChart = mySpace.Charts.Add(0);
            myChart.Type = ChartChartTypeEnum.chChartTypeColumnClustered;

            myChart.HasLegend = true;
            myChart.HasTitle = true;
            myChart.Title.Caption = "交易曲线图";

            myChart.Axes[0].HasTitle = true;
            myChart.Axes[0].Title.Caption = mDataTable.Columns[0].Caption;
            myChart.Axes[1].HasTitle = true;
            myChart.Axes[1].Title.Caption = "总额";


            myChart.SeriesCollection.Add(0);
            //myChart.
            myChart.SeriesCollection[0].SetData(ChartDimensionsEnum.chDimSeriesNames, (int)ChartSpecialDataSourcesEnum.chDataLiteral, mDataTable.Columns[1].Caption);
            myChart.SeriesCollection[0].SetData(ChartDimensionsEnum.chDimCategories, (int)ChartSpecialDataSourcesEnum.chDataLiteral, strCateory);
            ChDataLabels myLabels1 = myChart.SeriesCollection[0].DataLabelsCollection.Add();
            myLabels1.NumberFormat = "0.00";
            myLabels1.HasValue = true;

            myChart.SeriesCollection[0].SetData(ChartDimensionsEnum.chDimValues, (int)ChartSpecialDataSourcesEnum.chDataLiteral, strValue);
            if (strValue1 != "")
            {
                myChart.SeriesCollection.Add(1);
                myChart.SeriesCollection[1].SetData(ChartDimensionsEnum.chDimSeriesNames, (int)ChartSpecialDataSourcesEnum.chDataLiteral, mDataTable.Columns[2].Caption);
                myChart.SeriesCollection[1].SetData(ChartDimensionsEnum.chDimValues, (int)ChartSpecialDataSourcesEnum.chDataLiteral, strValue1);
                ChDataLabels myLabels2 = myChart.SeriesCollection[1].DataLabelsCollection.Add();
                myLabels2.NumberFormat = "0.00";
                myLabels2.HasValue = true;
            }
            //if (strValue2 !="")
            //{
            //    myChart.SeriesCollection.Add(2);
            //    myChart.SeriesCollection[2].SetData(ChartDimensionsEnum.chDimValues, (int)ChartSpecialDataSourcesEnum.chDataLiteral, strValue2);
            //    ChDataLabels myLabels3 = myChart.SeriesCollection[2].DataLabelsCollection.Add();
            //    myLabels3.NumberFormat = "0.00";
            //    myLabels3.HasValue = true;
            //}

            System.IO.File.Delete(@"C:\temp.gif");
            mySpace.ExportPicture(@"C:\temp.gif", "GIF", this.Width, this.Height);

            Image image = Image.FromFile(@"C:\temp.gif");
            pictureBox1.Image = image;
            pictureBox1.Size = image.Size;
            pictureBox1.Visible = true;
        }

        private void cmbProducts2_SelectedIndexChanged(object sender, EventArgs e)
        {
            mProductId = ((Classes.PubClass.MyCmbList)cmbProducts2.SelectedItem).Id;
            cmbProducts3.Items.Clear();
            var mTable = new T_ProductsTableAdapter().GetDataByParentId(mProductId); //获取level1的产品
            foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
            {
                cmbProducts3.Items.Add(new Classes.PubClass.MyCmbList(mRow.Id, mRow.Name));
            }
        }

        private void cmbProducts1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbProducts1.SelectedItem.ToString() == "查询所有")
            {
                mProductId = -1;
            }
            else
            {
                mProductId = ((Classes.PubClass.MyCmbList)cmbProducts1.SelectedItem).Id;
                cmbProducts2.Items.Clear();
                cmbProducts3.Items.Clear();
                var mTable = new T_ProductsTableAdapter().GetDataByParentId(mProductId); //获取level1的产品
                foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
                {
                    cmbProducts2.Items.Add(new Classes.PubClass.MyCmbList(mRow.Id, mRow.Name));
                }
            }
        }

        private void cmbProducts3_SelectedIndexChanged(object sender, EventArgs e)
        {
            mProductId = ((Classes.PubClass.MyCmbList)cmbProducts3.SelectedItem).Id;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string mSql = "";
            string mSql1 = "";

            if (rbDetails.Checked == true) //查询详细
            {
                mSql = "SELECT c.UserName 销售员, cu.companyname 客户名称, a.SaleDate 日期, d.name as 产品名称, a.Amount 数量, Convert(decimal(18,2),a.Price) 单价, Convert(decimal(18,2),a.SumMoney) 金额, a.SettlementModes 结款方式, b.TableNo 费用分配表号, a.InvoiceFlag 是否开票, a.SubmitDate 提交日期, a.InvoiceContent 开票内容,  a.InvoiceDate 开票日期, a.InvoiceType 发票类型, a.InvoiceNo 发票号 FROM dbo.T_SaleDetails a left join T_Users c on a.UserName = c.Id left join T_ExpenseAllocation b on a.ExpenseAllocation=b.Id left join T_Products d on a.productName = d.id left join t_Customers cu on a.customername = cu.id where 1=1 ";
                mSql1 = " union all select '总计',null,null,null,isnull(sum(a.Amount),0),null,Convert(decimal(18,2),isnull(sum(a.summoney),0)),null,null,null,null,null,null,null,null from t_saledetails a left join t_customers cu on a.customername = cu.id where 1=1";

               //是否开票
                
                if (CmbInvoiceFlag.SelectedIndex == 1)
                {
                    mSql += " and a.InvoiceFlag ='不开票' ";
                    mSql1 += " and a.InvoiceFlag ='不开票' ";
                }
                if (CmbInvoiceFlag.SelectedIndex == 2)
                {
                    mSql += " and a.InvoiceFlag ='开票' ";
                    mSql1 += " and a.InvoiceFlag ='开票' ";
                }
              
              
                if (cmbUsername.Text != "查询所有") //选择销售
                {
                    mSql += " and a.username='" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "'";
                    mSql1 += " and a.username='" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "'";
                }
                if (mProductId > 0) //选择产品
                {
                    mSql = @" WITH subQur(id, name, parentid) AS (SELECT   Id, Name, ParentId
                                                            FROM      T_Products
                                                            WHERE   (Id = '" + mProductId + @"')
                                                            UNION ALL
                                                            SELECT   T_Products_1.Id, T_Products_1.Name, T_Products_1.ParentId
                                                            FROM      T_Products AS T_Products_1 CROSS JOIN
                                                                            subQur AS subQur_2
                                                            WHERE   (T_Products_1.ParentId = subQur_2.id)) " + mSql + @" and a.ProductName in (  SELECT   id  FROM      subQur AS subQur_1)";
                    mSql1 += " and a.ProductName in (  SELECT   id  FROM      subQur AS subQur_1)";
                }


            }
            else if (rbSum.Checked == true) //汇总
            {

                if (mProductId > 0) //选择产品
                {
                    if (cmbUsername.Text != "查询所有") //选择指定产品和销售员
                    {
                        mSql = "SELECT  (select username from t_users where id = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "') 销售员,(select name from t_products where id='" + mProductId + "') 产品名称,isnull(sum(a.Amount),0) 数量, isnull(sum(a.SumMoney),0) 总计 FROM dbo.T_SaleDetails a left join T_Users c on a.UserName = c.Id left join T_Products d on a.productName = d.id where 1=1 and a.username = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "'";
                       
                    }
                    else //查询指定产品不指定销售员
                    {
                        mSql = "SELECT  (select name from t_products where id='" + mProductId + "') 产品名称,min(c.username) 销售员,isnull(sum(a.Amount),0) 数量,isnull(sum(a.SumMoney),0) 总计 FROM dbo.T_SaleDetails a left join t_users c on a.username=c.id left join T_Products d on a.productName = d.id where a.username <> '19'";
                        mSql1 = " group by a.username union all select '','总计',isnull(sum(amount),0),isnull(sum(summoney),0) from t_saledetails a where username <> '19' and productname in (select  id  FROM subQur AS subQur_1)";

                    }

                    mSql = @" WITH subQur(id, name, parentid) AS (SELECT   Id, Name, ParentId
                                                            FROM      T_Products
                                                            WHERE   (Id = '" + mProductId + @"')
                                                            UNION ALL
                                                            SELECT   T_Products_1.Id, T_Products_1.Name, T_Products_1.ParentId
                                                            FROM      T_Products AS T_Products_1 CROSS JOIN
                                                                            subQur AS subQur_2
                                                            WHERE   (T_Products_1.ParentId = subQur_2.id)) " + mSql + @" and a.ProductName in (  SELECT   id  FROM      subQur AS subQur_1)";

                }
                else//不选产品
                {

                    if (cmbUsername.Text != "查询所有") //指定销售员
                    {
                        mSql += "SELECT  (select username from t_users where id = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "') 销售员,min(c.name) 产品名称,isnull(sum(a.Amount),0) 数量,  isnull(sum(a.SumMoney),0) 总计 FROM dbo.T_SaleDetails a left join t_products c on a.productname = c.Id  where 1=1 and a.username = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "'";
                        mSql1 = " group by a.productname union all select '','总计',isnull(sum(a.Amount),0),isnull(sum(a.summoney),0) from T_SaleDetails a where a.username = '" + ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id + "'";
                       
                    }
                    else //统计所有销售额
                    {
                        mSql = "SELECT  isnull(sum(a.SumMoney),0) 总计 FROM dbo.T_SaleDetails a where username <> '19' ";
                    }

                }



            }
            else if (rbSalerSum.Checked == true) //按销售汇总
            {
                mSql = @"SELECT MIN(d.UserName) 销售员, ISNULL(SUM(a.SumMoney), 0) AS 总计
FROM T_Users AS d LEFT OUTER JOIN
      T_SaleDetails AS a ON a.UserName = d.id WHERE (a.username <> '19') AND (d.OperRight = '销售')";
                mSql1 = " GROUP BY d.id union all select '总计',isnull(sum(summoney),0) from t_saledetails a where username <> '19' AND (username in (select id from t_users where operright='销售'))";

            

            }
            else //所有产品汇总
            {
                mSql = "SELECT  min(d.name) 产品名称,isnull(sum(a.Amount),0) 数量, isnull(sum(a.SumMoney),0) 总计 FROM dbo.T_SaleDetails a left join t_products d on a.productname = d.id where 1=1";
                mSql1 = " group by a.productname union all select '总计',isnull(sum(Amount),0),isnull(sum(summoney),0) from t_SaleDetails a where 1=1";
            }

            if (cbDate.Checked == true)
            {
                mSql += @" and a.saledate between '" + dtpStart.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                if (mSql1 != "")
                {
                    mSql1 += @" and a.saledate between '" + dtpStart.Value.ToString("yyyy-MM-dd") + "' and '" + dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59'";
                }
            }
            //加客户名称
            if (string.IsNullOrEmpty(txtCustomer.Text) == false)
            {
                mSql += " and cu.CompanyName like '%" + txtCustomer.Text.Trim() + "%'";
                mSql1 += " and cu.CompanyName like '%" + txtCustomer.Text.Trim() + "%'";
            }
            //+地域
            if (cmbPromary.Text != "查询所有")
            {
                if (cmbCity.SelectedIndex == -1)
                {
                    mSql += " AND a.CityID in (select id from t_city where proid=" + ((Classes.PubClass.MyCmbList)cmbPromary.SelectedItem).Id + @")";
                    mSql1 += " and a.cityid in (select id from t_city where proid=" + ((Classes.PubClass.MyCmbList)cmbPromary.SelectedItem).Id + ")";
                }
                else
                {
                    mSql += " AND a.CityID = " + (long)cmbCity.SelectedValue;
                    mSql1 += " and a.cityid =" + (long)cmbCity.SelectedValue;
                }
            }

            if (!Common.AuthenticateRight.AuthOperation(140101) && !CommonClass.SttUser.blSuperUser)
            {
                mSql += " and a.username = " + Classes.PubClass.UserId;
                mSql1 += " and a.username = " + Classes.PubClass.UserId;
            }


         
            mSql += mSql1;

            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                dgvReport.DataSource = null;
                dgvReport.DataSource = mTable;
                if (mTable.Rows.Count < 1)
                {
                    MessageBox.Show("没有记录");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                IWorkbook mWorkbook = new HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;

                DataGridView mView = dgvReport;

                //添加标头
                IRow mRow = mSheet.CreateRow(0);
                for (i = 0; i <= mView.Columns.Count - 1; i++)
                {
                    mCell = mRow.CreateCell(i);
                    mCell.SetCellValue(mView.Columns[i].HeaderText);
                    mCell.CellStyle = styleRight;
                }
                //添加内容

                for (i = 1; i <= mView.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i);
                    for (j = 0; j <= mView.Columns.Count - 1; j++)
                    {
                        mCell = mRow.CreateCell(j);
                        if (Classes.PubFunc.IsNumber(Convert.ToString(mView.Rows[i - 1].Cells[j].Value)) == true)
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
                //mDialog.FileName = "1";
                mDialog.FileName = "销售记录-" + DateTime.Now.ToString("yyyyMMddhhmmss");
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

        private void rbProductSum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbProductSum.Checked == true)
            {
                cmbUsername.Enabled = false;
                cmbProducts1.Enabled = false;
                cmbProducts2.Enabled = false;
                cmbProducts3.Enabled = false;
                //是否开票选项
                lbInvoiceFlag.Visible = false; ;
                CmbInvoiceFlag.Visible = false;
            }
        }

        private void rbSalerSum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSalerSum.Checked == true)
            {
                cmbUsername.Enabled = false;
                cmbProducts1.Enabled = false;
                cmbProducts2.Enabled = false;
                cmbProducts3.Enabled = false;
                //是否开票选项
                lbInvoiceFlag.Visible = false; ;
                CmbInvoiceFlag.Visible = false;
            }
        }

        private void rbSum_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSum.Checked == true)
            {
                if (!Common.AuthenticateRight.AuthOperation(140201) && !CommonClass.SttUser.blSuperUser)
                {
                }
                else
                {

                    cmbUsername.Enabled = true;

                }
                cmbProducts1.Enabled = true;
                cmbProducts2.Enabled = true;
                cmbProducts3.Enabled = true;

                //是否开票选项
                lbInvoiceFlag.Visible = false; ;
                CmbInvoiceFlag.Visible = false;
            }
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDetails.Checked == true)
            {
                if (!Common.AuthenticateRight.AuthOperation(140201) && !CommonClass.SttUser.blSuperUser)
                { }
                else
                {
                    cmbUsername.Enabled = true;

                }
                cmbProducts1.Enabled = true;
                cmbProducts2.Enabled = true;
                cmbProducts3.Enabled = true;

                //是否开票选项
                lbInvoiceFlag.Visible = true;
                CmbInvoiceFlag.Visible = true;
            }
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string mSql = "";
            if (rbSalerSum.Checked == true)
            {
                mSql = @" select d.username 销售员,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from T_Users d
 left join (select a.username,sum(a.summoney) summoney from T_SaleDetails a where (DATEDIFF(m, a.SaleDate, '2013/6/1') = 0) group by all username) b on d.id = b.UserName
 left join (select a.username,sum(a.summoney) lssummoney from T_SaleDetails a where (DATEDIFF(m, a.SaleDate, '2013/6/1') = 1) group by all username) c on b.username=c.username ";
            }
            else if (rbProductSum.Checked == true)
            {
                mSql = @"select a.Name 产品名称,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from t_products a
left join (select b.ProductName,sum(b.summoney) summoney from t_saleDetails b where (DATEDIFF(m, b.SaleDate, '2013/6/1') = 0) group by all productname) c on a.id = c.productname
left join (select b.ProductName,sum(b.summoney) lssummoney from t_saleDetails b where (DATEDIFF(m, b.SaleDate, '2013/6/1') = 1) group by all productname) d on a.id = d.productname    ";
            }
            else if (rbDetails.Checked == true)
            {
                mSql = @"select a.Name 产品名称,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from t_products a
left join (select b.ProductName,sum(b.summoney) summoney from t_saleDetails b where (DATEDIFF(m, b.SaleDate, '2013/6/1') = 0) and username={0} and product group by all productname) c on a.id = c.productname
left join (select b.ProductName,sum(b.summoney) lssummoney from t_saleDetails b where (DATEDIFF(m, b.SaleDate, '2013/6/1') = 1) group by all productname) d on a.id = d.productname    ";
            }


            SqlConnection conn = new SqlConnection(global::Common.CommonClass.SqlConnStr);
            SqlDataAdapter adapter = new SqlDataAdapter(mSql, conn);
            DataTable mTable = new DataTable();
            try
            {
                adapter.Fill(mTable);
                //string[] Data = new string[mTable.Rows.Count], Data1 = new string[mTable.Rows.Count], Data2 = new string[mTable.Rows.Count], DataName = new string[mTable.Rows.Count];
                //for (int i=0;i<mTable.Rows.Count;i++)
                //{
                //    DataName[i] = mTable.Rows[i][0].ToString();
                //    Data[i] = mTable.Rows[i][2].ToString();
                //    Data1[i] = mTable.Rows[i][1].ToString();
                //}
                //MakeLineChart(DataName, Data, Data1, Data2);
                MakeLineChart(mTable);
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = false;
            if (this.pictureBox1.Image != null)
            {
                this.pictureBox1.Image.Dispose();
            }
        }

        private void cmbPromary_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPromary.Text == "查询所有")
            {
                cmbCity.DataSource = null;
            }
            else
            {
                var mTable = new T_CityTableAdapter().GetDataByProID(((Classes.PubClass.MyCmbList)cmbPromary.SelectedItem).Id);
                cmbCity.DisplayMember = "cityName";
                cmbCity.ValueMember = "ID";
                cmbCity.DataSource = mTable;
                cmbCity.SelectedIndex = -1;
            }

        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable mTable = null;
            if (cmbUsername.SelectedIndex > 0)
            {
                long saleId = ((销售管理.Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id;
                mTable = new T_CustomersTableAdapter().GetDataByUserId(saleId);
            }
            else
            {
                mTable = new T_CustomersTableAdapter().GetData();
            }
            txtCustomer.DataSource = mTable;
            txtCustomer.SelectedIndex = -1;
        }

        private void CmbInvoiceFlag_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }


    }
}
