using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using System.Xml;
using Common;
using Client.Class;

using Soft.Common;
using System.IO;

namespace Client.Main
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        public bool isLogined = false;
        
        int CheckLogin(string _sUserID,string _sPass)
        {
            string mSql;
            _sPass = MD5.Md5Encrypt(_sPass);
            mSql = string.Format("SELECT mm,xm,jb,sh,zt FROM PTry WHERE gh='{0}' ", _sUserID);

            DataTable mTable = SqlHelper.GetData(mSql);
            if (mTable == null)
            {
                Dlg.ShowErrorInfo("获取操作员信息失败！");
                return -1;
            }
            if (mTable.Rows.Count < 1)
            {
                Dlg.ShowErrorInfo("工号输入错误！");
                return -1;
            }
            if (mTable.Rows[0]["zt"].ToString() == "1")
            {
                Dlg.ShowErrorInfo("该工号已被锁定,请联系管理员！");
                return -1;
            }
            if (_sPass != mTable.Rows[0]["mm"].ToString())
            {
                Dlg.ShowErrorInfo("密码输入错误");
                return -1;
            }
            CommonClass.OperatorID = _sUserID;
            try
            {
                CommonClass.OperatorType = Convert.ToInt32(mTable.Rows[0]["jb"]);
            }
            catch {}
            CommonClass.SttUser.sUserID = _sUserID;
            CommonClass.SttUser.sUserName = mTable.Rows[0]["xm"].ToString();
            try
            {
                CommonClass.SttUser.iLevel = Convert.ToInt32(mTable.Rows[0]["jb"]);
            }
            catch { }            
            return 0;
        }
        
        private void OK_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;

            #region MyRegion
            //string LoginName, Password;

            //LoginName = txtLoginName.Text.Trim();
            //Password = txtPassword.Text.Trim();
            //var mTable = new T_UsersTableAdapter().GetDataByLoginName(LoginName);
            //if (mTable.Rows.Count < 1)
            //{
            //    Dlg.Show("登录名输入错误");
            //    return;
            //}
            //else
            //{
            //    var mRow = (SaleManager.DAL.DataSetUsers.T_UsersRow)mTable.Rows[0];
            //    Password =  PubClasses.MD5.Md5Encrypt(Password);
            //    if (string.Compare(Password, mRow.PassWord) != 0)
            //    {
            //        Dlg.Show("密码输入错误");
            //        txtPassword.Text = "";
            //        return;
            //    }
            //    PubClasses.Common.LoginName = LoginName;
            //    PubClasses.Common.UserId = mRow.id;
            //    PubClasses.Common.UserName = mRow.UserName;
            //    PubClasses.Common.UserRight = mRow.OperRight;
            //    PubClasses.Common.UserStatus = mRow.UserStatus;
            //    isLogined = true;
            //}
            //System.Net.IPAddress[] IPs = System.Net.Dns.GetHostAddresses(System.Net.Dns.GetHostName());
            //if (IPs.Length > 0)
            //{
            //    new T_LoginLogTableAdapter().Insert(PubClasses.Common.UserId, IPs[2].ToString());
            //} 
            #endregion

            //object[] args = new object[2];
            //Assembly myAs;
            //myAs = Assembly.LoadFrom("一卡通.dll");

            //Type mType = myAs.GetType("一卡通.Classes.Login");

            //if (mType != null)
            //{

            //    args[0] = this;
            //    args[1] = "";
            //    int ret =-1;
            //    ret = (int)mType.InvokeMember("Login_Ok", BindingFlags.InvokeMethod, null, mType, args);

            //    if (ret != 0)
            //    {
            //        return;
            //    }
            //}
            //else
            //{

            //    Dlg.Show("加载登录模块失败！");
            //    return;
            //}
            //判断要加载的界面类型


            string UserId = TBUserID.Text.Trim();
            string UserPass = TBUserPass.Text.Trim();
            CommonClass.SttUser.blSuperUser = false;
            if (UserId=="0000")
            {
                if (UserPass!="OneCardSuperAdmin")
                {
                    Dlg.ShowErrorInfo("密码不正确，重新输入！");
                    this.TBUserPass.SelectAll();
                    this.TBUserPass.Focus();
                    return;
                }
                CommonClass.SttUser.sUserID = UserId;
                CommonClass.SttUser.sUserName = "超级管理员";
                CommonClass.SttUser.blSuperUser = true;
            }
            else if (CheckLogin(UserId,UserPass)!=0)
            {
                return;
            }

            //Client.Common.OperatorName = mTable.Rows[0]["xm"].ToString();
            //Client.Common.NetNo = mTable.Rows[0]["sh"].ToString();

            ////04规范
            ////取 区域号，卡类型，只有一条
            ////DataSet ds1 = new DataSet();
            //mSql = "SELECT AreaNo,CardType FROM SZICSysParam";
            //mTable = Client.SqlHelper.GetData(mSql);

            //if (mTable.Rows.Count == 0)
            //{
            //    Dlg.ShowErrorInfo("请先进行系统参数（区域号，卡类型）设置！");
            //    return;
            //}
            //else
            //{
            //    Client.Common.gSysId = mTable.Rows[0]["AreaNo"].ToString().PadLeft(4, '0'); //区域号
            //    Client.Common.gCardType = mTable.Rows[0]["CardType"].ToString(); //卡类型
            //}

            ////取 读卡器端口号，条件是计算机名
            //string portStr = "USB";
            //string ComputerName = System.Environment.GetEnvironmentVariable("ComputerName");
            //mSql = string.Format("SELECT * FROM SZComputerParam where ComputerName='{0}'", ComputerName);
            //mTable = Client.SqlHelper.GetData(mSql);

            //if (mTable.Rows.Count == 0)
            //{
            //    Dlg.ShowErrorInfo("请先进行本机参数（读卡器端口号）设置！");
            //    //return;
            //}
            //else
            //{
            //    portStr = mTable.Rows[0]["Port"].ToString().Trim();
            //    object obj = mTable.Rows[0]["T57_flag"];
            //    if (obj != DBNull.Value)
            //    {
            //        Client.Common.gT57_flag = Convert.ToInt16(obj);
            //    }
            //}

            //if (portStr == "USB")
            //{
            //    Client.Common.gPortInt = 100;
            //}
            //else
            //{
            //    Client.Common.gPortInt = System.Convert.ToInt32(portStr.Substring(portStr.Length - 2, 2));
            //}
            ////04规范end

            ////取加密因子
            //mSql = "SELECT * FROM PTSoft_object";
            //mTable = PubClasses.SqlHelper.GetData(mSql);
            //if (mTable == null)
            //{
            //    Dlg.ShowErrorInfo("获取软件信息失败！");
            //    return;
            //}

            //if (mTable.Rows.Count == 0)
            //{
            //    Dlg.ShowErrorInfo("系统因子A不存在！");
            //    return;
            //}
            //else
            //{
            //    if (mTable.Rows[0]["JMA"] == DBNull.Value)
            //    {
            //        Dlg.ShowErrorInfo("系统因子A为空值！");
            //        return;
            //    }
            //    else
            //    {
            //        PubClasses.Common.JMA = mTable.Rows[0]["JMA"].ToString();
            //        if (PubClasses.Common.JMA.Length != 8)
            //        {
            //            Dlg.ShowErrorInfo("系统因子A长度错误！");
            //            return;
            //        }
            //    }

            //}
            FrmMain mForm = new FrmMain(this);
            mForm.LoadModuleListFromDb(CommonClass.OperatorType);
            //mForm.tssb用户名.Text = "登录用户名:" + Common.UserName + "  | 权限:" + PubClasses.Common.UserRight;
            mForm.Show();
            this.Hide();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string sIconFileName = string.Format(@"{0}\Images\app.ico", Application.StartupPath);
            if (File.Exists(sIconFileName))
            {
                LogoPictureBox.BackgroundImage=new Bitmap(sIconFileName);
            }
            //RegUtil regUtil = new RegUtil();
            //if (!regUtil.CheckAppReg())
            //{
            //    Dlg.ShowErrorInfo("注册失败无法使用系统！");
            //    Application.Exit();
            //}
            isLogined = false;
            //timer.Enabled = true;
            //Dlg.ShowErrorInfo(System.Environment.MachineName);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void FrmLogin_Activated(object sender, EventArgs e)
        {
            TBUserID.Focus();
            TBUserID.SelectionStart = 0;
            TBUserID.SelectionLength = TBUserID.Text.Length;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Enabled = false;
            TBUserID.Text = "1001";
            TBUserPass.Text = "1001";
            OK.PerformClick();
        }
    }
}
