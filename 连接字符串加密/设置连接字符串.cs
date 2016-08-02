using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace 配置连接字符串
{
    public partial class 设置连接字符串 : Form
    {
        public 设置连接字符串()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            string DbStr = "";
            string SqlStr = "";
            string EfStr = "";

            FormatStr(out DbStr, out SqlStr, out EfStr);


            if (ConnectDB(Soft.Common.Utils.DecryptRc2(DbStr)) == false)
                MessageBox.Show("连接成功");
            else
                MessageBox.Show("连接失败");

        }

        private void FormatStr(out string dbStr, out string sqlStr, out string efStr)
        {
            dbStr = string.Format("Provider=SQLOLEDB.1;Password={4};Persist Security Info=True;User ID={3};Initial Catalog={2};Data Source={0},{1}", txtIP.Text.Trim(), txtPort.Text.Trim(), txtDbName.Text.Trim(), txtUser.Text.Trim(), txtPwd.Text.Trim());
            sqlStr = string.Format("Data Source={0},{1};Initial Catalog={2};User ID={3};Password={4}", txtIP.Text.Trim(), txtPort.Text.Trim(), txtDbName.Text.Trim(), txtUser.Text.Trim(), txtPwd.Text.Trim());
            efStr = string.Format("metadata=res://*/DAL.ModelDa.csdl|res://*/DAL.ModelDa.ssdl|res://*/DAL.ModelDa.msl;provider=System.Data.SqlClient;provider connection string=\"data source={0},{1};initial catalog={2};user id={3};password={4};MultipleActiveResultSets=True;App=EntityFramework\"", txtIP.Text.Trim(), txtPort.Text.Trim(), txtDbName.Text.Trim(), txtUser.Text.Trim(), txtPwd.Text.Trim());

            dbStr = Soft.Common.Utils.EncryptRc2(dbStr);
            sqlStr = Soft.Common.Utils.EncryptRc2(sqlStr);
            efStr = Soft.Common.Utils.EncryptRc2(efStr);
        }

        public static bool ConnectDB(string connStr)
        {
            try
            {
                using (OleDbConnection mConn = new OleDbConnection(connStr))
                {
                    mConn.Open();

                    mConn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string DbStr = "";
            string SqlStr = "";
            string EfStr = "";

            FormatStr(out DbStr, out SqlStr, out EfStr);

            if (MessageBox.Show("是否验证数据正确性?", "提示", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (ConnectDB(Soft.Common.Utils.DecryptRc2(DbStr)) == false)
                    MessageBox.Show("连接成功");
                else
                {
                    MessageBox.Show("连接失败");
                    return;
                }
            }

            SaveFileDialog sf = new SaveFileDialog();
            sf.DefaultExt = ".xml";
            sf.FileName = "DBInfo.xml";
            sf.InitialDirectory = Application.StartupPath;
          
            if (sf.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    string xmlPath = sf.FileName;
                    XmlDocument xmlDoc = new XmlDocument();
                    if (File.Exists(xmlPath) == false)
                    {
                        //文件不存在则新建文件
                        xmlDoc.AppendChild(xmlDoc.CreateXmlDeclaration("1.0", null, null));

                        //根节点
                        xmlDoc.AppendChild(xmlDoc.CreateElement("DBInfo"));
                        xmlDoc.Save(xmlPath);

                        //应用程序所在目录下级目录用“/”，上级目录用“../”
                        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBType", "", "0");
                        //XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", "Provider=SQLOLEDB;Data Source=192.168.111.115,1433;Persist Security Info=True;Password=sa;User ID=sa;Initial Catalog=DBMeter");
                        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", DbStr);
                        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "EFConnStr", "", EfStr);
                        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "SqlConnStr", "", SqlStr);
                    }
                    else
                    {
                        Common.XmlHelper.Delete(xmlPath, "/DBInfo/DBConnStr", "");
                        Common.XmlHelper.Delete(xmlPath, "/DBInfo/EFConnStr", "");
                        Common.XmlHelper.Delete(xmlPath, "/DBInfo/SqlConnStr", "");

                        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", DbStr);
                        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "EFConnStr", "", EfStr);
                        Common.XmlHelper.Insert(xmlPath, "/DBInfo", "SqlConnStr", "", SqlStr);

                        MessageBox.Show("保存成功");
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show(string.Format("异常：\n{0}", ex.Message));
                    Application.Exit();
                }
            }
        }
    }
}
