using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using 销售管理.DAL.DataSetT_UpdateTableAdapters;
using System.IO;
using System.Diagnostics;

namespace 销售管理.系统设置
{
    public partial class 上传新版本 : 销售管理.UserControlBase
    {
        public 上传新版本()
        {
            InitializeComponent();
        }

        private DataTable mTable = new DataTable();

        private void 上传新版本_Load(object sender, EventArgs e)
        {
            var CurrentVer = new T_UpdateTableAdapter().GetMaxVer();
            txtVer.Text = Convert.ToString(CurrentVer);
            InitTable();
            dgvFiles.DataSource = mTable;
        }

        private void InitTable()
        {
            mTable.Columns.Add("文件名");
            mTable.Columns.Add("相对路径");
            mTable.Columns.Add("文件目录");
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog mDlg = new OpenFileDialog();
                mDlg.InitialDirectory = AppDomain.CurrentDomain.BaseDirectory;
                mDlg.Multiselect = true;
                if (mDlg.ShowDialog() == DialogResult.OK)//点击打开
                {
                    //txtFilePath.Text = mDlg.FileName;
                    //FileVersionInfo FileInfo = FileVersionInfo.GetVersionInfo(txtFilePath.Text); //获取文件版本信息
                    //txtVer.Text = FileInfo.FileVersion;
                    //txtFilePath.Text = mDlg.FileName;
                    //string[] FileName = txtFilePath.Text.Split('\\');
                    //txtFileName.Text = FileName[FileName.Length - 1];

                    //将选中的文件添加到表格中
                    foreach (string fileName in mDlg.FileNames)
                    {
                        
                        string[] FileFullName = fileName.Split('\\');
                        DataRow mRow = mTable.NewRow();
                        if (FileFullName[FileFullName.Length - 1] == "销售管理.exe")
                        {
                            FileVersionInfo FileInfo = FileVersionInfo.GetVersionInfo(fileName); //获取文件版本信息
                            txtVer.Text = FileInfo.FileVersion;
                        }
                        mRow["文件名"] = FileFullName[FileFullName.Length - 1];
                        mRow["相对路径"] = txtUpPath.Text;
                        mRow["文件目录"] = fileName;
                        mTable.Rows.Add(mRow);
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                int count = 0;
                //把表格中的文件上传
                T_UpdateTableAdapter adapter = new T_UpdateTableAdapter();
                if (adapter.Connection.State == ConnectionState.Closed)
                {
                    adapter.Connection.Open();
                }
                //循环
                foreach (DataRow mRow in mTable.Rows)
                {
                    string fileName, fileUpPath, fileFullPath;
                    fileName = mRow["文件名"].ToString();
                    fileUpPath = mRow["相对路径"].ToString();
                    fileFullPath = mRow["文件目录"].ToString();


                    //
                    if (File.Exists(fileFullPath) == true) //检查文件是够存在
                    {
                        string filePath = "";

                        //如果上传文件是本身,复制文件并上传
                        filePath = fileFullPath.Insert(fileFullPath.LastIndexOf('\\'), "\\upload");
                        if (Directory.Exists(filePath.Substring(0, filePath.LastIndexOf('\\'))) == false)
                        {
                            Directory.CreateDirectory(filePath.Substring(0, filePath.LastIndexOf('\\')));
                        }
                        File.Copy(fileFullPath, filePath, true);

                        
                        using (FileStream fs = new FileStream(filePath, FileMode.Open)) //打开文件,将文件写入字节数组
                        {
                            byte[] bFile = new byte[fs.Length];
                            fs.Read(bFile, 0, (int)fs.Length);

                            adapter.Insert(fileName, txtVer.Text, fileUpPath, DateTime.Now, bFile, "");
                            fs.Close();
                            fs.Dispose();
                            count++;
                        }
                    }
                    else
                    {
                        MessageBox.Show("文件不存在");
                    }
                }

                if (adapter.Connection.State == ConnectionState.Open)
                {
                    adapter.Connection.Close();
                }

                if (count > 0)
                {
                    MessageBox.Show("文件上传成功");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvFiles_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex == Col删除.Index)
            {
                mTable.Rows.RemoveAt(e.RowIndex);
            }
        }
    }
}
