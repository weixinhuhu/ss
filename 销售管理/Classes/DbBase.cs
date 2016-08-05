using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Collections;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace 销售管理.Classes
{
    abstract class DbBase
    {
        public OleDbDataReader mDr;
        public string mError;
        public  OleDbConnection mConn;

        private OleDbCommand mComm;
        private string mSQL;
        private ArrayList mSQLs;

        public string SQL
        {
            get { return mSQL; }
            set { mSQL = value; }
        }

        public ArrayList SQLs
        {
            get { return mSQLs; }
            set { mSQLs = value; }
        }

        public string ErrorInfo
        {
            get { return mError; }
        }

        public DbBase()
        {
            mConn = new OleDbConnection();
            mComm = new OleDbCommand();
            mSQLs = new ArrayList();
        }

        //public void Dispose(bool disposing = true)
        //{
        //    mSQLs = null;
        //    mComm.Dispose();
        //    mConn.Close();
        //    Finalize();
        //}

        //连接数据库 access
        public bool Connect(string dbName)
        {
            dbName = System.Windows.Forms.Application.StartupPath + @"\DBMeter.mdb";//路径最后带\
            string sConn = null;
            sConn = "Provider=Microsoft.Jet.OLEDB.4.0;";
            sConn += "Data Source = " + dbName + ";";
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
                MessageBox.Show(ex.Message);
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
                mError = ex.ToString();
                //mError = "错误号：" + LogClass.AddErrorInfo(sConn) + Constants.vbCrLf + mError;
                return true;
            }
        }

        //执行SQL语句（mSQL）
        public bool ExecCommand()
        {
            int k = 0;
            try
            {
                mComm.CommandText = mSQL;
                k = mComm.ExecuteNonQuery();
                return false;
            }
            catch (Exception e)
            {
                mError = e.ToString();
                //mError = "错误号：" + LogClass.AddErrorInfo(mSQL) + Constants.vbCrLf + mError;
                return true;
            }
        }

        //执行SQL语句（mSQLs）
        public bool ExecCommands()
        {
            OleDbTransaction myTrans = default(OleDbTransaction);
            int i = 0;
            int k = 0;

            myTrans = mConn.BeginTransaction();
            mComm.Transaction = myTrans;

            try
            {
                for (i = 0; i <= mSQLs.Count - 1; i++)
                {
                    mComm.CommandText = mSQLs[i].ToString();
                    k = mComm.ExecuteNonQuery();
                }
                myTrans.Commit();
                return false;
            }
            catch (Exception e)
            {
                mError = e.ToString();
                return true;
                try
                {
                    myTrans.Rollback();
                }
                catch (OleDbException ex)
                {
                    if ((myTrans.Connection != null))
                    {
                        mError = ex.ToString();
                        //mError = "错误号：" + LogClass.AddErrorInfo(mSQLs[i]) + Constants.vbCrLf + mError;
                        //Console.WriteLine("An exception of type " & ex.GetType().ToString() & _
                        //    " was encountered while attempting to roll back the transaction.")
                    }
                }
            }
        }

        //取得DataSet记录集。'此为最佳，应该统一只用一个取值的方法
        public bool GetDataSet(ref DataSet PDs)
        {
            OleDbDataAdapter da = default(OleDbDataAdapter);
            try
            {
                da = new OleDbDataAdapter(mSQL, mConn);
                da.Fill(PDs, "Table1");
                da.Dispose();
                return false;
                //异常处理
            }
            catch (Exception ex)
            {
                mError = ex.ToString();
                //mError = "错误号：" + LogClass.AddErrorInfo(mSQL) + Constants.vbCrLf + mError;
                return true;
            }
        }

        //取得DataSet记录集
        //取得记录集,添加时间：2012.09.20
        public bool GetRecord(ref ArrayList PData)
        {
            int i = 0;
            try
            {
                mComm.CommandText = mSQL;
                mDr = mComm.ExecuteReader();
                while (mDr.Read())
                {
                    for (i = 0; i <= mDr.FieldCount - 1; i++)
                    {
                        PData.Add(mDr.GetValue(i));
                    }
                }
                mDr.Close();
                return false;
            }
            catch (Exception ex)
            {
                mError = ex.ToString();
                //mError = "错误号：" + LogClass.AddErrorInfo(mSQL) + Constants.vbCrLf + mError;
                return true;
            }
        }

        //取得记录集的第一行第一列,添加时间：
        public Int32 GetOneValue()
        {
            mComm.CommandText = mSQL;
            // mComm.CommandText = TempSql
            dynamic obj = mComm.ExecuteScalar();
            //If IsDBNull(obj) Then
            //    Return -1
            //Else
            //    Return obj
            //End If
            return (Convert.IsDBNull(obj) ? -1 : obj);
        }
    }
}
