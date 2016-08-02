using System;
using System.Data;
using System.Data.OleDb;
using System.Collections;
using System.Windows.Forms;

namespace Soft.Common
{
    public class DbAccess
    {
        OleDbTransaction OleTrans;
        OleDbConnection OleConn;
        OleDbCommand OleCMD;
        string sConnString;
        public string m_sSQL;
        public string[] m_asSQL;

        public string getDataSource()
        {
            return OleConn.DataSource;
        }

        public string getDatabase()
        {
            return OleConn.Database;
        }

        public DbAccess(string _sConnString)
        {
            this.sConnString = _sConnString;
            //OpenDataLink();
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        /// <returns></returns>
        public int CloseDataLink()
        {
            if (OleConn != null)
            {
                OleConn.Close();
            }
            return 0;
        }

        /// <summary>
        /// 获取数据连接
        /// </summary>
        /// <returns>"0":Success;其它:Fail</returns>
        public string OpenDataLink()
        {
            if (OleConn == null)
            {
                OleConn = new OleDbConnection(sConnString);
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    OleConn.Open();
                }
                catch (Exception Ex)
                {
                    return string.Format("创建数据库连接异常：{0}", Ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                    OleConn.ResetState();
                    if (OleConn.State != ConnectionState.Open)
                    {
                        OleConn.Open();
                    }
                }
                catch (Exception Ex)
                {
                    return string.Format("打开数据库连接异常：{0}", Ex.Message);
                }
                finally
                {
                    Cursor.Current = Cursors.Default;
                }
            }
            return "0";
        }

        /// <summary>
        /// DataReader
        /// </summary>
        /// <param name="_sMySQL">查询语句</param>
        /// <returns>OleDbDataReader,失败为NULL </returns>
        public OleDbDataReader GetOleReader(string _sMySQL, out string _sOut)
        {
            _sOut = OpenDataLink();
            if (_sOut != "0")
            {
                return null;
            }
            try
            {
                OleCMD = OleConn.CreateCommand();
                OleCMD.CommandType = CommandType.Text;
                OleCMD.CommandText = _sMySQL;
                return OleCMD.ExecuteReader();
            }
            catch (Exception ex)
            {
                _sOut = string.Format("【数据库：{0}】", ex.Message);
                return null;
            }
            finally
            {
                //OleConn.Close();
            }
        }
        public OleDbDataReader GetOleReader(out string _sOut)
        {
            return GetOleReader(m_sSQL, out _sOut);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="_sMySQL">SQL语句</param>
        /// <param name="_DS">存放数据的DataSet</param>
        /// <returns>成功与否</returns>
        public DataSet GetDataSet(string _sMySQL, string sTableName = "")
        {
            string sRet = OpenDataLink();
            DataSet DS = new DataSet();
            if (sRet != "0")
            {
                DS.ExtendedProperties.Add("ReturnFlag", sRet);
                return DS;
            }
            try
            {
                OleCMD = OleConn.CreateCommand();
                OleCMD.CommandType = CommandType.Text;
                OleCMD.CommandText = _sMySQL;
                using (OleDbDataAdapter OleAdapter = new OleDbDataAdapter(OleCMD))
                {
                    if (string.IsNullOrEmpty(sTableName))
                    {
                        OleAdapter.Fill(DS);
                    }
                    else
                    {
                        OleAdapter.Fill(DS, sTableName);
                    }
                }
                DS.ExtendedProperties.Add("ReturnFlag", "0");
                return DS;
            }
            catch (Exception ex)
            {
                DS.ExtendedProperties.Add("ReturnFlag", string.Format("【数据库：{0}】", ex.Message)); 
                return DS;
            }
            finally
            {
                //OleConn.Close();
            }
        }
        public DataSet GetDataSet(string sTableName = "")
        {
            return GetDataSet(m_sSQL, sTableName);
        }

        /// <summary>
        /// Exec Procedure
        /// </summary>
        /// <param name="_sProcName">Procedure Name</param>
        /// <param name="_ALParams">Parameter Collection</param>
        /// <param name="_sOut"></param>
        /// <param name="iRetType">1:返回OleDbCommand;2：返回OleDbDataReader</param>
        /// <returns></returns>
        private Object ExecProc(string _sProcName, ArrayList _ALParams, out string _sOut, Int32 iRetType = 1)
        {
            _sOut = OpenDataLink();
            if (_sOut != "0")
            {
                return null;
            }

            try
            {
                OleCMD = OleConn.CreateCommand();
                OleCMD.CommandType = CommandType.StoredProcedure;
                OleCMD.CommandText = _sProcName;
                foreach (OleDbParameter Item in _ALParams)
                {
                    OleCMD.Parameters.Add(Item);
                }
                if (iRetType == 1)
                {
                    OleCMD.ExecuteNonQuery();
                    return OleCMD;
                }
                else
                {
                    return OleCMD.ExecuteReader();
                }
            }
            catch (Exception ex)
            {
                _sOut = string.Format("【数据库：{0}】", ex.Message);
                return null;
            }
            finally
            {
                //OleConn.Close();
            }
        }
        public OleDbCommand ExecProc_OleDbCMD(string _sProcName, ArrayList _ALParams, out string _sOut)
        {
            return (OleDbCommand)ExecProc(_sProcName, _ALParams, out _sOut, 1);
        }
        public OleDbDataReader ExecProc_OleDbReader(string _sProcName, ArrayList _ALParams, out string _sOut)
        {
            return (OleDbDataReader)ExecProc(_sProcName, _ALParams, out _sOut, 2);
        }        
        
        /// <summary>
        /// 事务执行批量语句
        /// </summary>
        /// <param name="_asSQL">批量语句</param>
        /// <param name="bFlag">True:影响记录数为0算执行失败；False:影响记录数为0算执行成功</param>
        /// <returns></returns>
        public string ExecTrans(string[] _asSQL,bool bFlag=true)
        {
            string sRet = OpenDataLink();
            if (sRet != "0")
            {
                return sRet;
            }

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                OleTrans = OleConn.BeginTransaction();
            }
            catch (Exception Ex)
            {
                sRet = string.Format("【数据库：{0}】", Ex.Message);
                OleConn.Close();
                Cursor.Current = Cursors.Default;
                return sRet;
            } 

            try
            {
                OleCMD = OleConn.CreateCommand();
                OleCMD.CommandType = CommandType.Text;
                OleCMD.Transaction = OleTrans;
                for (int i = 0; i < _asSQL.Length; i++)
                {
                    if ((string.IsNullOrEmpty(_asSQL[i])) || (_asSQL[i].Trim().Replace("\n", "") == ""))
                    {
                        continue;
                    }
                    OleCMD.CommandText = _asSQL[i];
                    if ((OleCMD.ExecuteNonQuery() == 0) && bFlag)
                    {
                        OleTrans.Rollback();
                        sRet = string.Format("语句：{0}执行结果影响为0！", OleCMD.CommandText);
                        return sRet;
                    }
                }
                OleTrans.Commit();
            }
            catch (Exception ex)
            {
                OleTrans.Rollback();
                sRet = string.Format("{0}={1}", ex.Message, OleCMD.CommandText);
                return sRet;
            }
            finally
            {
                OleConn.Close();
                Cursor.Current = Cursors.Default;
            }
            return "0";
        }
        public string ExecTrans(bool bFlag=true)
        {
            return ExecTrans(m_asSQL, bFlag);
        }
    }
}
