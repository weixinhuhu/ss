using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using NPOI.SS.UserModel;

namespace 销售管理.Classes
{
    static class ExcelDeport
    {
        static public int Deport(System.Windows.Forms.DataGridView mView,string outName)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;

                //DataGridView mView = dgvReport;

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

                        mCell.SetCellValue(Convert.ToString(mView.Rows[i - 1].Cells[j].Value));
                        mCell.CellStyle = styleRight;

                    }
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = outName+ "-" + DateTime.Now.ToString("yyyyMMddhhmmss");
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
            return 0;
        }

        static public int Deport(System.Windows.Forms.DataGridView mView, int startIndex)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                //NumberStyle.DataFormat = format.GetFormat("0.00");
                ICell mCell;
                int i, j;
                int x = 0;
                //DataGridView mView = dgvReport;

                //添加标头
                IRow mRow = mSheet.CreateRow(0);
                for (i = startIndex; i <= mView.Columns.Count - 1; i++)
                {
                    if (mView.Columns[i].Visible == true)
                    {
                        mCell = mRow.CreateCell(x);
                        x++;
                        mCell.SetCellValue(mView.Columns[i].HeaderText);
                        mCell.CellStyle = styleRight;
                    }
                }
                //添加内容

                for (i = 1; i <= mView.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i);
                    x = 0;
                    for (j = startIndex; j <= mView.Columns.Count - 1; j++)
                    {
                        if (mView.Columns[j].Visible == true)
                        {
                            mCell = mRow.CreateCell(x);
                            x++;
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
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = "导出数据-" + DateTime.Now.ToString("yyyyMMddhhmmss");
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
            return 0;
        }

        static public int InvoiceDeport(System.Windows.Forms.DataGridView mView)
        {
            try
            {
                IWorkbook mWorkbook = new NPOI.HSSF.UserModel.HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("Sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                //ICellStyle NumberStyle = mWorkbook.CreateCellStyle();
                //IDataFormat format = mWorkbook.CreateDataFormat();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                styleRight.WrapText = true;
                ICell mCell;
                int i;


                //添加标头
                IRow mRow = mSheet.CreateRow(0);

                int m = 0;
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("公司名称");
                mSheet.SetDefaultColumnStyle(m, styleRight);//设置样式
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("总金额");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("发票类型");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("开票日期");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("商品名称");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("单价");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("数量");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                mCell = mRow.CreateCell(m++);
                mCell.SetCellValue("金额");
                mSheet.SetDefaultColumnStyle(m, styleRight);
                //添加内容
                int mExcelRowCount = 1;
                for (i = 0; i <= mView.RowCount - 1; i++)
                {
                    if (Convert.ToBoolean(mView.Rows[i].Cells["ColCombine"].Value) == true)
                    {
                        mRow = mSheet.CreateRow(mExcelRowCount++);
                        string InvoiceContent = string.Empty;
                        //公司名称
                        mCell = mRow.CreateCell(0);
                        mCell.SetCellValue(Convert.ToString(mView.Rows[i].Cells["customerNameDataGridViewTextBoxColumn"].Value));
                        //总金额
                        mCell = mRow.CreateCell(1);
                        mCell.SetCellValue(Convert.ToString(mView.Rows[i].Cells["invoiceMoneyDataGridViewTextBoxColumn"].Value));
                        //发票类型
                        mCell = mRow.CreateCell(2);
                        mCell.SetCellValue(Convert.ToString(mView.Rows[i].Cells["invoiceTypeDataGridViewTextBoxColumn"].Value));
                        //开票日期
                        mCell = mRow.CreateCell(3);
                        mCell.SetCellValue(Convert.ToString(mView.Rows[i].Cells["invoiceDateDataGridViewTextBoxColumn"].Value));
                        //开票内容
                        InvoiceContent = Convert.ToString(mView.Rows[i].Cells["invoiceContentDataGridViewTextBoxColumn"].Value);
                        string[] contents = System.Text.RegularExpressions.Regex.Split(InvoiceContent, "!#!");
                        for (int n = 0; n < contents.Length - 3; n += 4)
                        {
                            mCell = mRow.CreateCell(4);
                            mCell.SetCellValue(contents[n]);
                            mCell = mRow.CreateCell(5);
                            mCell.SetCellValue(contents[n + 1]);
                            mCell = mRow.CreateCell(6);
                            mCell.SetCellValue(contents[n + 2]);
                            mCell = mRow.CreateCell(7);
                            mCell.SetCellValue(contents[n + 3]);

                            if (n < contents.Length - 7) mRow = mSheet.CreateRow(mExcelRowCount++);
                        }
                        mSheet.CreateRow(mExcelRowCount++);
                    }
                }



                //创建文件
                SaveFileDialog mDialog = new SaveFileDialog();
                mDialog.AddExtension = true;
                mDialog.DefaultExt = "xls";
                mDialog.Filter = "Excel Worksheets(*.xls)|*.xls";
                mDialog.InitialDirectory = System.Environment.CurrentDirectory;
                mDialog.FileName = "开票-" + DateTime.Now.ToString("yyyyMMddhhmmss");
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
            return 0;
        }

    }


}
