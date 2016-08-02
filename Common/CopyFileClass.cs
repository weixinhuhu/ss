using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Soft.Common;

namespace Common
{
    //数据库备份参数有两个：
    //1、备份模式  0：退出系统时备份并提示 1：退出系统时备份不提示 2：退出系统时不备份，默认为0
    //2、备份路径
    //设置的参数存储语句 update SysParam set IntCode={0},VcParam1={1} where IntID=1    //IntCode写入备份模式，VcParam1写入备份路径

    //如果用户选择了不备份功能，系统启动强制备份模式，即自动备份数据到系统盘windows目录下建立Data目录并备份，采用循环覆盖备份，只保留最后三次备份即可；

    public class CopyFileClass
    {
        /// <summary>
        /// 复制文件
        /// </summary>
        /// <param name="fromFile">要复制的文件</param>
        /// <param name="toFolder">要复制到的文件夹</param>
        /// <returns></returns>
        public static void Backup(int backupMode, string fromFile, string toDirectory)
        {
            try
            {
                if (backupMode == 2)
                {
                    //toDirectory = @"C:\Windows\Data";
                    toDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\一卡通数据备份";
                }
                if (Directory.Exists(toDirectory) == false)
                {
                    Directory.CreateDirectory(toDirectory);
                }

                string toFile;
                FileInfo fileInfo1;

                switch (backupMode)
                {
                    case 0://提示
                        SaveFileDialog SaveFileDialog1 = new SaveFileDialog();
                        SaveFileDialog1.Title = "数据库备份";
                        SaveFileDialog1.InitialDirectory = toDirectory;
                        SaveFileDialog1.FileName = string.Format("DBMeter_{0}", DateTime.Now.ToString("yyyyMMdd_HHmmss"));  //备份文件名
                        SaveFileDialog1.Filter = "备份文件(*.mdb)|*.mdb";

                        if (SaveFileDialog1.ShowDialog() == DialogResult.OK)
                        {
                            toFile = SaveFileDialog1.FileName;

                            if (toFile == fromFile)
                            {
                                return;
                            }
                            fileInfo1 = new FileInfo(fromFile);
                            fileInfo1.CopyTo(toFile, false);
                            Dlg.ShowOKInfo("数据库备份成功！");
                        }
                        break;
                    case 1://不提示
                        toFile = string.Format(toDirectory + @"\DBMeter_{0}.mdb", DateTime.Now.ToString("yyyyMMdd_HHmmss"));

                        if (toFile == fromFile)
                        {
                            return;
                        }
                        fileInfo1 = new FileInfo(fromFile);
                        fileInfo1.CopyTo(toFile, true);
                        //Dlg.ShowOKInfo("数据库备份成功！");
                        break;
                    case 2://自动备份到C盘
                        DirectoryInfo directoryInfo1 = new DirectoryInfo(toDirectory);
                        FileInfo[] fileArr = directoryInfo1.GetFiles("DBMeter_Auto_*.mdb");

                        //排序，按创建时间从大到小
                        for (int i = 0; i < fileArr.Length; i++)
                        {
                            for (int j = i; j < fileArr.Length; j++)
                            {
                                if (fileArr[i].CreationTime < fileArr[j].CreationTime)
                                {
                                    FileInfo temp = fileArr[i];
                                    fileArr[i] = fileArr[j];
                                    fileArr[j] = temp;
                                }
                            }
                        }
                        //只留创建时间最大的2个
                        for (int i = 2; i < fileArr.Length; i++)
                        {
                            File.Delete(fileArr[i].FullName);
                        }

                        //备份文件名
                        toFile = string.Format(toDirectory + @"\DBMeter_Auto_{0}.mdb", DateTime.Now.ToString("yyyyMMdd_HHmmss"));

                        if (toFile == fromFile)
                        {
                            return;
                        }
                        fileInfo1 = new FileInfo(fromFile);
                        fileInfo1.CopyTo(toFile, true);
                        //Dlg.ShowOKInfo("数据库备份成功！");
                        break;
                    default:
                        return;
                }
            }
            catch
            {
                throw;
            }
        }

        public static void Restore(string PFileName)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.Title = "数据库恢复";
            openFileDialog1.InitialDirectory = Application.StartupPath;
            openFileDialog1.Filter = "备份文件(*.mdb)|*.mdb";
            openFileDialog1.ShowDialog();

            string strOldFile = openFileDialog1.FileName;

            if (strOldFile == PFileName)
            {
                Dlg.ShowErrorInfo("文件已存在！");
                return;
            }

            try
            {
                FileInfo fileInfo1 = new FileInfo(strOldFile);
                fileInfo1.CopyTo(PFileName, true);
                Dlg.ShowOKInfo("数据库恢复成功！");
                return;
            }
            catch
            {
                throw;
            }
        }



    }
}
