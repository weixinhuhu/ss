using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;

namespace 一卡通.Classes
{
    class DbConect
    {
        private OleDbConnection mConn;
        private OleDbCommand mComm;

        //连接数据库 access
        public bool Connect(string PName)
        {
            string sConn = null;
            sConn = "Provider=Microsoft.Jet.OLEDB.4.0;";
            sConn += "Data Source = " + PName + ";";
            sConn += "Jet OLEDB:Database Password = meiyoumima2011";
            try
            {
                mConn.ConnectionString = sConn;
                mConn.Open();
                mComm.Connection = mConn;
                return false;
            }
            catch (Exception ex)
            {
                //mError = ex.ToString();
                //mError = "错误号：" + LogClass.AddErrorInfo(sConn) + Constants.vbCrLf + mError;
                return true;
            }
        }
        public bool ConnectSql(string DbAddress, string DbName, string DbUserName, string DbPwd)
        {
            string sConn = null;

            sConn = "Provider=SQLOLEDB;";
            sConn += "Data Source = " + DbAddress + ";";
            sConn += "Initial Catalog= " + DbName + ";";
            sConn += "User ID=" + DbUserName + ";";
            sConn += "Password =" + DbPwd + ";";
            sConn += "Persist Security Info=false;";
            try
            {
                mConn = new OleDbConnection(sConn);
                mConn.Open();
                mComm.Connection = mConn;
                return false;
            }
            catch (Exception ex)
            {
                throw;
                //mError = ex.ToString();
                //mError = "错误号：" + LogClass.AddErrorInfo(sConn) + Constants.vbCrLf + mError;
                return true;
            }

            try
            {
                mConn = new OleDbConnection(sConn);
                mConn.Open();
                mComm.Connection = mConn;
                return false;
            }
            catch(Exception e)
            {
                throw e.Message;
            }
        }
    }
}
