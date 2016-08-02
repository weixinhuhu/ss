using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Configuration;
using Common;
using Soft.Common;

namespace Common
{
    public static class SqlHelper
    {
        public static void RefreshSection(string mConnStr)
        {
            try
            {
                Configuration config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

                config.ConnectionStrings.ConnectionStrings.Remove("PubClasses.Properties.Settings.Setting_ConnStr");
                config.ConnectionStrings.ConnectionStrings.Add(new ConnectionStringSettings("PubClasses.Properties.Settings.Setting_ConnStr", mConnStr, "System.Data.OleDb"));
                config.Save(ConfigurationSaveMode.Modified);
                ConfigurationManager.RefreshSection("ConnectionStrings");

                Dlg.ShowOKInfo("保存成功,程序将重新启动");
                Application.Restart();

            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message.ToString());
            }
        }

        /// <summary>
        /// 测试是否能连接数据库
        /// </summary>
        /// <returns>0--成功,1--失败</returns>
        public static int TestDB()
        {
            try
            {
                //if (Common.mDatabaseClass.ConnectDB(PubClasses.Properties.Settings.Default.Setting_ConnStr) == false)
                if (ConnectDB(CommonClass.ConnStr) == false)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message);
                return 1;
            }
        }

        public static bool ConnectDB(string connStr)
        {
            try
            {
                using (OleDbConnection mConn = new OleDbConnection(connStr))
                {
                    mConn.Open();
                    if (mConn.Provider.IndexOf("SQLOLEDB")!=-1)
                    {
                        CommonClass.SttDb.iDBType = 1;
                    }
                    else if (mConn.Provider.IndexOf("Jet")!=-1)
                    {
                        CommonClass.SttDb.iDBType = 0;
                    }
                    else
                    {
                        CommonClass.SttDb.iDBType = -2;
                    }
                    CommonClass.SttDb.sDbInfo = string.Format("{0}({1})", mConn.DataSource, mConn.Database);
                    CommonClass.SttDb.sDataSource = mConn.DataSource;
                    mConn.Close();
                    return false;
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message);
                return true;
            }
        }

        #region +static int ExecuteNonQuery(string mSql) //执行Sql语句返回受影响的行数
        /// <summary>
        /// 执行Sql语句返回受影响的行数
        /// </summary>
        /// <param name="mSql">要执行Sql的语句</param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string mSql)
        {
            int ret = 0;

            try
            {
                using (OleDbConnection mConn = new OleDbConnection(CommonClass.ConnStr))
                {
                    mConn.Open();
                    using (OleDbCommand mComm = new OleDbCommand(mSql, mConn))
                    {
                        ret = mComm.ExecuteNonQuery();                        
                    }
                    mConn.Close();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message);
                return -1;
            }

        }
        #endregion

        #region  +static DataTable GetData(string mSql) //执行SQL语句返回DataTable
        /// <summary>
        /// 执行SQL语句返回DataTable
        /// </summary>
        /// <param name="mSql">要执行Sql的语句</param>
        /// <returns></returns>
        public static DataTable GetData(string mSql,bool _blFlag=true)
        {
            DataTable mTable = new DataTable();
            try
            {

                using (OleDbConnection mConn = new OleDbConnection(CommonClass.ConnStr))
                {
                    mConn.Open();
                    using (OleDbDataAdapter adapter = new OleDbDataAdapter(mSql, mConn))
                    {
                        adapter.Fill(mTable);
                    }
                    mConn.Close();
                }
            }
            catch (Exception ex)
            {
                if (_blFlag)
                {
                    Dlg.ShowErrorInfo(ex.Message);
                }
                else
                {
                    throw ex;
                }
            }
            return mTable;
        }
        #endregion

        #region  +static int ExecuteSqls(string[] mSqls) //执行所有Sql语句
        /// <summary>
        /// 执行所有Sql语句
        /// </summary>
        /// <param name="mSqls">要执行所有Sql语句</param>
        /// <returns></returns>
        public static int ExecuteSqls(string[] mSqls)
        {
            try
            {
                using (OleDbConnection mConn = new OleDbConnection(CommonClass.ConnStr))
                {
                    mConn.Open();
                    using (OleDbTransaction mTrans = mConn.BeginTransaction())
                    {
                        try
                        {
                            using (OleDbCommand mComm = new OleDbCommand())
                            {
                                mComm.Connection = mConn;
                                mComm.Transaction = mTrans;
                                int ret = 0;
                                foreach (string mSql in mSqls)
                                {
                                    mComm.CommandText = mSql;
                                    ret = mComm.ExecuteNonQuery();
                                    if (ret < 1 && mSql.ToUpper().Contains("insert".ToUpper()) == true)
                                    {
                                        mTrans.Rollback();
                                        return 1;
                                    }
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            mTrans.Rollback();
                            Dlg.ShowErrorInfo(ex.Message);
                            return 1;
                        }
                        mTrans.Commit();
                    }
                    mConn.Close();
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message);
                return 1;
            }
            return 0;
        }
        #endregion

        #region +static object ExecuteScalar(string mSql) //执行Sql语句返回第一行第一列
        /// <summary>
        /// 执行Sql语句返回第一行第一列
        /// </summary>
        /// <param name="mSql">要执行Sql的语句</param>
        /// <returns></returns>
        public static object ExecuteScalar(string mSql)
        {
            object ret;
            try
            {
                using (OleDbConnection mConn = new OleDbConnection(CommonClass.ConnStr))
                {
                    mConn.Open();
                    using (OleDbCommand mComm = new OleDbCommand(mSql, mConn))
                    {
                        ret = mComm.ExecuteScalar();
                    }
                    mConn.Close();
                    return ret;
                }
            }
            catch (Exception ex)
            {
                Dlg.ShowErrorInfo(ex.Message);
                return -1;
            }
        }
        #endregion

    }

}
