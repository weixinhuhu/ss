using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Common;
using 销售管理.DAL.DataSetUsersTableAdapters;
using 销售管理.DAL.DataSetLoginLogTableAdapters;
using 销售管理.DAL;
using System.Xml;
using System.IO;

namespace 销售管理
{
    public partial class LoginForm1 : Form
    {
        public LoginForm1()
        {
            InitializeComponent();
        }
        public bool isLogined = false;

        private void OK_Click(object sender, EventArgs e)
        {
            try
            {
                MYDBEntities2 myEntity = new MYDBEntities2();

                this.DialogResult = System.Windows.Forms.DialogResult.OK;
                string LoginName, Password;

                LoginName = txtLoginName.Text.Trim();
                Password = txtPassword.Text.Trim();
                List<T_Users> Users = myEntity.T_Users.Where(d => d.LoginName == LoginName).ToList();

                if (Users.Count < 1)
                {
                    MessageBox.Show("登录名输入错误");
                    return;
                }
                else
                {
                    var User = Users.FirstOrDefault();
                    Password = Classes.MD5.Md5Encrypt(Password);
                    if (string.Compare(Password, User.PassWord) != 0)
                    {
                        MessageBox.Show("密码输入错误");
                        txtPassword.Text = "";
                        return;
                    }
                    if (User.UserStatus != "正常")
                    {
                        MessageBox.Show("该账户已停用");
                        return;
                    }
                    if (LoginName.ToLower() == "admin")
                    {
                        CommonClass.SttUser.blSuperUser = true;
                    }
                    else
                    {
                        CommonClass.SttUser.blSuperUser = false;
                    }

                    Classes.PubClass.LoginName = LoginName;
                    Classes.PubClass.UserId = User.id;
                    Classes.PubClass.UserName = User.UserName;
                    Classes.PubClass.UserRight = User.OperRight;
                    Classes.PubClass.UserStatus = User.UserStatus;
                    Classes.PubClass.UserRoleId = User.IntRoleID ?? -1;

                    //添加权限
                    CommonClass.UserRightList.Clear();
                    销售管理.BLL.Da.GetUserRight(Classes.PubClass.UserRoleId);

                    CommonClass.SttDb.iDBType = 1;
                    isLogined = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //var mTable = new T_UsersTableAdapter().GetDataByLoginName(LoginName);
            //if (mTable.Rows.Count < 1)
            //{
            //    MessageBox.Show("登录名输入错误");
            //    return;
            //}
            //else
            //{
            //    var mRow = (销售管理.DAL.DataSetUsers.T_UsersRow)mTable.Rows[0];
            //    Password = Classes.MD5.Md5Encrypt(Password);
            //    if (string.Compare(Password, mRow.PassWord) != 0)
            //    {
            //        MessageBox.Show("密码输入错误");
            //        txtPassword.Text = "";
            //        return;
            //    }
            //    Classes.PubClass.LoginName = LoginName;
            //    Classes.PubClass.UserId = mRow.id;
            //    Classes.PubClass.UserName = mRow.UserName;
            //    Classes.PubClass.UserRight = mRow.OperRight;
            //    Classes.PubClass.UserStatus = mRow.UserStatus;
            //    isLogined = true;
            //}
            System.Net.IPAddress[] IPs = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName());
            for (int c = 0; c < IPs.Length; c++)
            {
                if (IPs[c].AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {
                    new T_LoginLogTableAdapter().Insert(Classes.PubClass.UserId, IPs[c].ToString());
                }
            }

            MainForm mForm = new MainForm(this);
            // mForm.tssb用户名.Text = "登录用户名:"+  Classes.PubClass.UserName +"  | 权限:" + Classes.PubClass.UserRight;
            mForm.LoadModuleListFromDb(Classes.PubClass.UserRoleId);
            mForm.Show();
            //this.DialogResult = DialogResult.OK;
            this.Hide();

        }

        private void LoginForm1_Load(object sender, EventArgs e)
        {

            //SetConnStr();
            isLogined = false;
        }

        private void SetConnStr()
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

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void LoginForm1_Activated(object sender, EventArgs e)
        {
            txtLoginName.Focus();
            txtLoginName.SelectionStart = 0;
            txtLoginName.SelectionLength = txtLoginName.Text.Length;
        }
    }
}
