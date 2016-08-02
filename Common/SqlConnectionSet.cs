using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace Common
{
    public class SqlConnectionSet
    {

        public static void SetConnStr()
        {
            try
            {
                string xmlPath = "DBInfo.xml";
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
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "DBConnStr", "", "");
                    Common.XmlHelper.Insert(xmlPath, "/DBInfo", "EFConnStr", "", "");
                }

                string sConnStr = Common.XmlHelper.Read(xmlPath, "/DBInfo/DBConnStr", "");
                string efConnStr = Common.XmlHelper.Read(xmlPath, "/DBInfo/EFConnStr", "");
                string sqlConnStr = Common.XmlHelper.Read(xmlPath, "/DBInfo/SqlConnStr", "");
                if (efConnStr == "")
                {
                    efConnStr = @"2krNpdaokzDBV4brToQPRip6KDoTxVeVFUUfX+EiudTMQ6U+TsSODJeo5CyiGloZ/nxDOTK03dmiWr9mCTafLNzUvpVtGAYrElhbPnTkt+7wuEg7g0hL5hZahzpuYC8D4r8gLEN7DK0Q2q1i9qUE4L1GKrz6oYGoY+fiqCi+QITBvf499Z6aXkhEsExeeDph426NFvUwB4KZER28aTt36z1nLeeg91AjRBVstR+3Y/cfYgChZkOqS7AVvloeyz6CAnQDbx7y72aYr3O0oT9c0VcEA81V1wovAv2vHwVIcKBSTMt0G8DJM8QirQz+zIl2ZtGtZBNOnYxBDHXFME4pcANLp0bmfdNI";
                }
                //解密数据库连接参数
                sConnStr = Soft.Common.Utils.DecryptRc2(sConnStr);
                efConnStr = Soft.Common.Utils.DecryptRc2(efConnStr);
                sqlConnStr = Soft.Common.Utils.DecryptRc2(sqlConnStr);
                //公共类的连接字符串赋值，包括类属性 和 项目属性两处
                //Common.Properties.Settings.Default.ConnectionString = Common.ConnStr;
                Common.CommonClass.SetConnStr(sConnStr,sqlConnStr,efConnStr);
                //Classes.PubClass.EFConnStr = efConnStr;
                if (Common.SqlHelper.TestDB() == 0)
                {
                    //PubClasses.SqlHelper.mConnStr = mConnStr;
                }
                else
                {
                    MessageBox.Show("连接数据库失败,请运行“数据库连接参数配置工具.exe”进行配置！");
                    Application.Exit();
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
