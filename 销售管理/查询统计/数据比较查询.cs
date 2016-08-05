using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Owc11;
using System.Data.SqlClient;
using 销售管理.DAL.DataSetProductsTableAdapters;
using 销售管理.DAL.DataSetUsersTableAdapters;
using System.IO;
using Common;

namespace 销售管理.查询统计
{
    public partial class 数据比较查询 : 销售管理.UserControlBase
    {
        public 数据比较查询()
        {
            InitializeComponent();
        }

        Int64 mProductId = 0;

        private void btnCompare_Click(object sender, EventArgs e)
        {
            string mSql = "";
            //if (rbSalerSum.Checked == true)
            //{

            //}
            //else if (rbProductSum.Checked == true)
            //{

            //}
            //else
            DateTime dtStart1,dtEnd1;
            if (cmbCompareType.Text =="去年同期")
            {
                dtStart1 = dtpStart.Value.AddYears(-1);
                dtEnd1 = dtpEnd.Value.AddYears(-1);
            } 
            else
            {
                dtStart1 = dtpStart.Value.AddMonths(-1);
                dtEnd1 = dtpEnd.Value.AddMonths(-1);
            }
            
            if (rbSaler.Checked == true)
            {
                if (cmbUsername.Text == "查询所有")
                {
                    if (cbDate.Checked ==true)
                    {
                        mSql = string.Format(@" select d.username 销售员,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from T_Users d
 left join (select a.username,sum(a.summoney) summoney from T_SaleDetails a where a.saledate between '{0}' and '{1}' group by all username) b on d.id = b.UserName
 left join (select a.username,sum(a.summoney) lssummoney from T_SaleDetails a where a.saledate between '{2}' and '{3}' group by all username) c on b.username=c.username ", dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59", dtStart1.ToString("yyyy-MM-dd"), dtEnd1.ToString("yyyy-MM-dd") + " 23:59:59");
                    }
                    else
                    {
                        mSql = @" select d.username 销售员,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from T_Users d
 left join (select a.username,sum(a.summoney) summoney from T_SaleDetails a  group by all username) b on d.id = b.UserName
 left join (select a.username,sum(a.summoney) lssummoney from T_SaleDetails a  group by all username) c on b.username=c.username ";
                    }
                    
                }
                else
                {
                    if (cbDate.Checked==true)
                    {
                        mSql = string.Format(@" select d.username 销售员,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from T_Users d
 left join (select a.username,sum(a.summoney) summoney from T_SaleDetails a where a.saledate between '{0}' and '{1}' group by all username) b on d.id = b.UserName
 left join (select a.username,sum(a.summoney) lssummoney from T_SaleDetails a where a.saledate between '{2}' and '{3}' group by all username) c on b.username=c.username where d.id={4}", dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59", dtStart1.ToString("yyyy-MM-dd"), dtEnd1.ToString("yyyy-MM-dd") + " 23:59:59", ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id);
                    }
                    else
                    {
                        mSql = string.Format(@" select d.username 销售员,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from T_Users d
 left join (select a.username,sum(a.summoney) summoney from T_SaleDetails a  group by all username) b on d.id = b.UserName
 left join (select a.username,sum(a.summoney) lssummoney from T_SaleDetails a group by all username) c on b.username=c.username where d.id={0}", ((Classes.PubClass.MyCmbList)cmbUsername.SelectedItem).Id);

                    }
                    
                }
            }
            else
            {
                if (mProductId <1)
                {
                    if (cbDate.Checked ==true)
                    {
                        mSql = string.Format(@"select a.Name 产品名称,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from t_products a
left join (select b.ProductName,sum(b.summoney) summoney from t_saleDetails b where b.saledate between '{0}' and '{1}' group by all productname) c on a.id = c.productname
left join (select b.ProductName,sum(b.summoney) lssummoney from t_saleDetails b where b.saledate between '{2}' and '{3}'  group by all productname) d on a.id = d.productname    ", dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59", dtStart1.ToString("yyyy-MM-dd"), dtEnd1.ToString("yyyy-MM-dd") + " 23:59:59");
                    } 
                    else
                    {
                        mSql = @"select a.Name 产品名称,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from t_products a
left join (select b.ProductName,sum(b.summoney) summoney from t_saleDetails b group by all productname) c on a.id = c.productname
left join (select b.ProductName,sum(b.summoney) lssummoney from t_saleDetails b  group by all productname) d on a.id = d.productname    ";
                    }
                }
                else
                {
                    if (cbDate.Checked==true)
                    {
                        mSql = string.Format(@"select a.Name 产品名称,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from t_products a
left join (select b.ProductName,sum(b.summoney) summoney from t_saleDetails b where b.saledate between '{0}' and '{1}'  group by all productname) c on a.id = c.productname
left join (select b.ProductName,sum(b.summoney) lssummoney from t_saleDetails b where b.saledate between '{2}' and '{3}'  group by all productname) d on a.id = d.productname where 1=1 ", dtpStart.Value.ToString("yyyy-MM-dd"), dtpEnd.Value.ToString("yyyy-MM-dd") + " 23:59:59", dtStart1.ToString("yyyy-MM-dd"), dtEnd1.ToString("yyyy-MM-dd") + " 23:59:59", mProductId.ToString());
                        
                    } 
                    else
                    {
                        mSql = @"select a.Name 产品名称,isnull(lssummoney,0) 上期,isnull(summoney,0) 本期 from t_products a
left join (select b.ProductName,sum(b.summoney) summoney from t_saleDetails b  group by all productname) c on a.id = c.productname
left join (select b.ProductName,sum(b.summoney) lssummoney from t_saleDetails b  group by all productname) d on a.id = d.productname where 1=1 ";
                    }

                    mSql = @" WITH subQur(id, name, parentid) AS (SELECT   Id, Name, ParentId
                                                            FROM      T_Products
                                                            WHERE   (Id = '" + mProductId + @"')
                                                            UNION ALL
                                                            SELECT   T_Products_1.Id, T_Products_1.Name, T_Products_1.ParentId
                                                            FROM      T_Products AS T_Products_1 CROSS JOIN
                                                                            subQur AS subQur_2
                                                            WHERE   (T_Products_1.ParentId = subQur_2.id)) " + mSql + @" and a.id in (  SELECT   id  FROM      subQur AS subQur_1)";
                }
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

        private void MakeLineChart(DataTable mDataTable)//string[] DataName,string[] Data,string[] Data1, string[] Data2)
        {

            

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



            ChartSpace mySpace = new ChartSpace();
            ChChart myChart = mySpace.Charts.Add(0);
            myChart.Type = ChartChartTypeEnum.chChartTypeColumnClustered;

            myChart.HasLegend = true;
            myChart.HasTitle = true;
            if (cbDate.Checked ==true)
            {
                myChart.Title.Caption = dtpStart.Value.ToString("yyyy年MM月dd日--") + dtpEnd.Value.ToString("yyyy年MM月dd日") + cmbCompareType.Text + "交易曲线图";
            } 
            else
            {
                myChart.Title.Caption = "交易曲线图";
            }
            

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
            //if (pictureBox1.Image != null)
            //{
            //    pictureBox1.Image.Dispose();
            //}
            string mPath = Application.StartupPath + @"temp.gif"; //临时图片保存地址
            System.IO.File.Delete(mPath);
            mySpace.ExportPicture(mPath, "GIF", pictureBox1.Width, pictureBox1.Height);

            //Image image = Image.FromFile(@"C:\temp.gif");
            
            //Image image1 = (Image)image.Clone();
            //image.Dispose();
            FileStream mFs = File.OpenRead(mPath);
            pictureBox1.Image = Image.FromStream(mFs);
            mFs.Close();
            //pictureBox1.Size = image.Size;
            //pictureBox1.Visible = true;
        }


        private void 数据比较查询_Load(object sender, EventArgs e)
        {
            cmbProducts1.Items.Add("查询所有");
            var mTable = new T_ProductsTableAdapter().GetDataByLevel(1); //获取level1的产品
            foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
            {
                cmbProducts1.Items.Add(new Classes.PubClass.MyCmbList(mRow.Id, mRow.Name));
            }
            cmbProducts1.SelectedIndex = 0;
            var mTable1 = new T_UsersTableAdapter().GetSalers(); //获取销售
            foreach (销售管理.DAL.DataSetUsers.T_UsersRow mRow in mTable1.Rows)
            {
                cmbUsername.Items.Add(new Classes.PubClass.MyCmbList(mRow.id, mRow.UserName));
            }
            cmbUsername.Items.Insert(0, "查询所有");
            cmbUsername.SelectedIndex = 0;
            cmbUsername.DisplayMember = "Name";
            cmbUsername.ValueMember = "Id";
            rbSaler.Checked = true;
            cmbCompareType.SelectedIndex = 0;
            dtpStart.Value = dtpStart.Value.AddMonths(-1);
            if (!Common.AuthenticateRight.AuthOperation(140301) && !CommonClass.SttUser.blSuperUser)
            {
                cmbUsername.SelectedIndex = cmbUsername.FindStringExact(Classes.PubClass.UserName.ToString());
                cmbUsername.Enabled = false;
            }
            
        }

        private void cmbProducts1_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbProduct.Checked = true;
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

        private void cmbProducts2_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbProduct.Checked = true;
            mProductId = ((Classes.PubClass.MyCmbList)cmbProducts2.SelectedItem).Id;
            cmbProducts3.Items.Clear();
            var mTable = new T_ProductsTableAdapter().GetDataByParentId(mProductId); //获取level1的产品
            foreach (销售管理.DAL.DataSetProducts.T_ProductsRow mRow in mTable.Rows)
            {
                cmbProducts3.Items.Add(new Classes.PubClass.MyCmbList(mRow.Id, mRow.Name));
            }
        }

        private void cmbProducts3_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbProduct.Checked = true;
            mProductId = ((Classes.PubClass.MyCmbList)cmbProducts3.SelectedItem).Id;
        }

        private void cmbUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            rbSaler.Checked = true;
        }
    }


}

