using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Drawing;
using OfficeOpenXml.Style;

namespace Soft.Common
{
    public class Excel
    {
        /// <summary>
        /// DataGridView中数据带标题导入xls文件
        /// </summary>
        /// <param name="_DGV">导出数据所在的DataGridView</param>
        public static void ExportToExcelFileNPOI(DataGridView _DGV)
        {
            try
            {
                IWorkbook mWorkbook = new HSSFWorkbook();
                ISheet mSheet = mWorkbook.CreateSheet("sheet1");
                ICellStyle styleRight = mWorkbook.CreateCellStyle();
                styleRight.Alignment = NPOI.SS.UserModel.HorizontalAlignment.Center;
                styleRight.VerticalAlignment = NPOI.SS.UserModel.VerticalAlignment.Center;
                styleRight.WrapText = true;
                styleRight.IsLocked = true;
                ICell mCell = default(ICell);
                int i = 0;
                int j = 0;
                //添加标头
                IRow mRow = mSheet.CreateRow(0);
                for (i = 0; i <= _DGV.Columns.Count - 1; i++)
                {
                    mCell = mRow.CreateCell(i);
                    mCell.SetCellValue(_DGV.Columns[i].HeaderText);
                    mCell.CellStyle = styleRight;
                }

                //添加内容
                for (i = 1; i <= _DGV.RowCount; i++)
                {
                    mRow = mSheet.CreateRow(i);
                    for (j = 0; j <= _DGV.Columns.Count - 1; j++)
                    {
                        mCell = mRow.CreateCell(j);
                        mCell.SetCellValue(_DGV.Rows[i - 1].Cells[j].Value.ToString());
                        mCell.CellStyle = styleRight;
                    }
                }
                mSheet.ProtectSheet("verybull");

                //创建文件
                SaveFileDialog SaveDlg = new SaveFileDialog();
                SaveDlg.AddExtension = true;
                SaveDlg.DefaultExt = "xls";
                SaveDlg.Filter = "Excel Worksheets(*.xls)|*.xls";
                SaveDlg.InitialDirectory = System.Environment.CurrentDirectory;
                SaveDlg.ShowDialog();
                if (!SaveDlg.FileName.Equals(""))
                {
                    System.IO.Stream mFile = SaveDlg.OpenFile();
                    mWorkbook.Write(mFile);
                    mFile.Close();
                    Dlg.ShowOKInfo("导出Excel文件成功！");
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(string.Format("导出异常：{0}", ex.Message));
            }
        }

        public static void ExportToExcelFileEPPlus(string _sTitle,DataGridView _DGV)
        {
            int iColCount = _DGV.Columns.Count;
            int iRowCount = _DGV.Rows.Count;
            using (ExcelPackage ExcelPkg = new ExcelPackage())
            {
                try
                {
                    ExcelWorksheet Sheet = ExcelPkg.Workbook.Worksheets.Add("sheet1");
                    //Title Row
                    Sheet.Cells["A1"].Value = _sTitle;
                    ExcelRange Range = Sheet.Cells[1, 1, 1, iColCount];
                    Range.Merge = true;
                    Range.Style.Font.Size = 14;
                    Range.Style.Font.Bold = true;
                    Range.Style.Font.Color.SetColor(System.Drawing.Color.FromArgb(79, 129, 189));
                    Range.Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    Range.Style.Border.Bottom.Style = ExcelBorderStyle.Medium;

                    //Name Row
                    for (int i = 0; i < iColCount; i++)
                    {
                        Sheet.Cells[2, i + 1].Value = _DGV.Columns[i].HeaderText;
                        Sheet.Cells[2, i + 1].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }                    
                    Range = Sheet.Cells[2, 1, 2, iColCount];
                    Range.Style.Font.Size = 12;
                    Range.Style.Font.Bold = true;
                    Range.Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                    //Value Row
                    for (int i = 0; i < iRowCount; i++)
                    {
                        for (int j = 0; j < iColCount; j++)
                        {
                            Sheet.Cells[i + 3, j + 1].Value = _DGV.Rows[i].Cells[j].Value.ToString();
                        }
                        Sheet.Cells[i + 3, 1, i + 3, iColCount].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                        Sheet.Cells[i + 3, 1, i + 3, iColCount].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                    }                    

                    //Column Line
                    for (int i = 0; i < iColCount; i++)
                    {
                        Sheet.Column(i + 1).AutoFit(5);
                        Sheet.Cells[1, i + 1, iRowCount + 2, iColCount].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                    }
                    Sheet.Cells.Style.WrapText = true;

                    //BorderAround Line
                    Range = Sheet.Cells[1, 1, iRowCount + 2, iColCount];
                    Range.Style.Border.BorderAround(ExcelBorderStyle.Medium);

                    //Encrypt
                    Sheet.Protection.IsProtected = true;
                    Sheet.Protection.SetPassword("verybull");

                    Sheet.Protection.AllowAutoFilter = true;
                    Sheet.Protection.AllowSort = true;
                    Sheet.Protection.AllowFormatCells = true;
                    Sheet.Protection.AllowFormatColumns = true;
                    Sheet.Protection.AllowFormatRows = true;
                    Sheet.Protection.AllowSelectUnlockedCells = true;

                    Sheet.Protection.AllowSelectLockedCells = true;
                    Sheet.Protection.AllowDeleteColumns = false;
                    Sheet.Protection.AllowDeleteRows = false;
                    Sheet.Protection.AllowEditObject = false;
                    Sheet.Protection.AllowEditScenarios = false;
                    Sheet.Protection.AllowInsertColumns = false;
                    Sheet.Protection.AllowInsertHyperlinks = false;
                    Sheet.Protection.AllowInsertRows = false;
                    Sheet.Protection.AllowPivotTables = false;

                    //Save
                    SaveFileDialog SaveDlg = new SaveFileDialog();
                    SaveDlg.AddExtension = true;
                    SaveDlg.DefaultExt = "xlsx";
                    SaveDlg.Filter = "Excel Worksheets(*.xlsx)|*.xlsx";
                    SaveDlg.InitialDirectory = System.Environment.CurrentDirectory;
                    SaveDlg.ShowDialog();
                    if (!SaveDlg.FileName.Equals(""))
                    {
                        System.IO.Stream stream = SaveDlg.OpenFile();
                        ExcelPkg.SaveAs(stream);
                        stream.Close();
                        Dlg.ShowOKInfo("导出报表文件成功！");
                    }
                }
                catch (Exception Ex)
                {
                    Dlg.ShowErrorInfo(string.Format("异常:{0}", Ex.Message));
                }
            }
        }
    }
}
