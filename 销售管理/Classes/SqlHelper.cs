using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

namespace 销售管理.Classes
{
    class SqlHelper
    {
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
                using (SqlConnection mConn = new SqlConnection(销售管理.Properties.Settings.Default.mydbConnectionString))
                {
                    mConn.Open();
                    using (SqlCommand mComm = new SqlCommand(mSql, mConn))
                    {
                        ret = mComm.ExecuteNonQuery();
                        return ret;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
        public static DataTable GetData(string mSql)
        {
            DataTable mTable = new DataTable();
            try
            {

                using (SqlConnection mConn = new SqlConnection(销售管理.Properties.Settings.Default.mydbConnectionString))
                {
                    mConn.Open();
                    using (SqlDataAdapter adapter = new SqlDataAdapter(mSql, mConn))
                    {
                        adapter.Fill(mTable);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                using (SqlConnection mConn = new SqlConnection(销售管理.Properties.Settings.Default.mydbConnectionString))
                {
                    mConn.Open();
                    using (SqlTransaction mTrans = mConn.BeginTransaction())
                    {
                        try
                        {
                            using (SqlCommand mComm = new SqlCommand())
                            {
                                mComm.Connection = mConn;
                                mComm.Transaction = mTrans;
                                int ret = 0;
                                foreach (string mSql in mSqls)
                                {
                                    mComm.CommandText = mSql;
                                    ret = mComm.ExecuteNonQuery();
                                    if (ret < 1)
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
                            MessageBox.Show(ex.Message);
                            return 1;
                        }
                        mTrans.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                using (SqlConnection mConn = new SqlConnection(销售管理.Properties.Settings.Default.mydbConnectionString))
                {
                    mConn.Open();
                    using (SqlCommand mComm = new SqlCommand(mSql, mConn))
                    {
                        ret = mComm.ExecuteScalar();
                        return ret;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return -1;
            }
        }
        #endregion
    } 
        
}
