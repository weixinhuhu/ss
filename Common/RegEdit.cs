using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32;

namespace Common
{
    /// <summary>
    /// 操作注册表
    /// </summary>
    public class RegEdit
    {
        /// <summary>
        /// 实例构造函数
        /// </summary>
        public RegEdit()
        {
            //在此处添加构造函数逻辑
        }

        #region 公共方法
        /// <summary>
        /// 写入注册表,如果指定项已经存在,则修改指定项的值
        /// </summary>
        /// <param name="keytype">注册表基项枚举</param>
        /// <param name="key">注册表项,不包括基项</param>
        /// <param name="name">值名称</param>
        /// <param name="values">值</param>
        /// <returns>返回布尔值,指定操作是否成功</returns>
        public bool setValue(KeyType keytype, string key, string name, string values)
        {
            try
            {
                RegistryKey rk = (RegistryKey)getRegistryKey(keytype);

                RegistryKey rkt = rk.CreateSubKey(key);

                if (rkt != null)
                    rkt.SetValue(name, values);
                else
                {
                    throw (new Exception("要写入的项不存在"));
                }

                return true;
            }
            catch
            {
                return false;
            }
        }
        /// <summary>
        /// lisi，写入注册表 HKEY_LOCAL_MACHINE\SOFTWEAR\keyCompany\name，name是项名
        /// </summary>
        /// <param name="keyCompany"></param>
        /// <param name="name"></param>
        /// <param name="values"></param>
        /// <returns></returns>
        public int SaveSetting(string keyCompany, string keyProduct, string name, string values)
        {
            try
            {
                //一级
                RegistryKey rk = getRegistryKey(KeyType.HKEY_LOCAL_MACHINE);

                //二级
                RegistryKey rk1 = rk.OpenSubKey("SOFTWARE", true);

                //三级，公司名
                if (rk1.OpenSubKey(keyCompany) == null)
                {
                    rk1.CreateSubKey(keyCompany);
                }
                RegistryKey rk2 = rk1.OpenSubKey(keyCompany, true);

                //四级，产品名
                if (rk2.OpenSubKey(keyProduct) == null)
                {
                    rk2.CreateSubKey(keyProduct);
                }
                RegistryKey rk3 = rk2.OpenSubKey(keyProduct, true);

                //项名
                rk3.SetValue(name, values);

                return 0;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        /// <summary>
        /// 读取注册表
        /// </summary>
        /// <param name="keytype">注册表基项枚举</param>
        /// <param name="key">注册表项,不包括基项</param>
        /// <param name="name">值名称</param>
        /// <returns>返回字符串</returns>
        public string getValue(KeyType keytype, string key, string name)
        {
            try
            {
                RegistryKey rk = (RegistryKey)getRegistryKey(keytype);

                RegistryKey rkt = rk.OpenSubKey(key);

                if (rkt != null)
                    return rkt.GetValue(name).ToString();
                else
                    throw (new Exception("无法找到指定项"));
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
        /// <summary>
        /// lisi，读取注册表 HKEY_LOCAL_MACHINE\SOFTWEAR\keyCompany\name，name是项名
        /// </summary>
        /// <param name="keyCompany">一级</param>
        /// <param name="keyProduct">二级</param>
        /// <param name="name">项名</param>
        /// <returns>项的值，项不存在则为0</returns>
        public string GetSetting(string keyCompany, string keyProduct, string name)
        {
            try
            {
                RegistryKey rk = (RegistryKey)getRegistryKey(KeyType.HKEY_LOCAL_MACHINE);
                RegistryKey rk1 = rk.OpenSubKey("SOFTWARE");

                RegistryKey rk2 = rk1.OpenSubKey(keyCompany);
                if (rk2 == null)
                    return string.Empty;

                RegistryKey rk3 = rk2.OpenSubKey(keyProduct);
                if (rk3 == null)
                    return string.Empty;
                else
                    return rk3.GetValue(name).ToString();
            }
            catch
            {
                return string.Empty;
            }
        }

        /// <summary>
        /// 删除注册表中的值
        /// </summary>
        /// <param name="keytype">注册表基项枚举</param>
        /// <param name="key">注册表项名称,不包括基项</param>
        /// <param name="name">值名称</param>
        /// <returns>返回布尔值,指定操作是否成功</returns>
        public bool deleteValue(KeyType keytype, string key, string name)
        {
            try
            {
                RegistryKey rk = (RegistryKey)getRegistryKey(keytype);

                RegistryKey rkt = rk.OpenSubKey(key, true);

                if (rkt != null)
                    rkt.DeleteValue(name, true);
                else
                    throw (new Exception("无法找到指定项"));

                return true;

            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 删除注册表中的指定项
        /// </summary>
        /// <param name="keytype">注册表基项枚举</param>
        /// <param name="key">注册表中的项,不包括基项</param>
        /// <returns>返回布尔值,指定操作是否成功</returns>
        public bool deleteSubKey(KeyType keytype, string key)
        {
            try
            {
                RegistryKey rk = (RegistryKey)getRegistryKey(keytype);

                rk.DeleteSubKeyTree(key);

                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// 判断指定项是否存在
        /// </summary>
        /// <param name="keytype">基项枚举</param>
        /// <param name="key">指定项字符串</param>
        /// <returns>返回布尔值,说明指定项是否存在</returns>
        public bool isExist(KeyType keytype, string key)
        {
            RegistryKey rk = (RegistryKey)getRegistryKey(keytype);

            if (rk.OpenSubKey(key) == null)
                return false;
            else
                return true;
        }

        /// <summary>
        /// 检索指定项关联的所有值
        /// </summary>
        /// <param name="keytype">基项枚举</param>
        /// <param name="key">指定项字符串</param>
        /// <returns>返回指定项关联的所有值的字符串数组</returns>
        public string[] getValues(KeyType keytype, string key)
        {
            RegistryKey rk = (RegistryKey)getRegistryKey(keytype);

            RegistryKey rkt = rk.OpenSubKey(key);

            if (rkt != null)
            {
                string[] names = rkt.GetValueNames();

                if (names.Length == 0)
                    return names;
                else
                {
                    string[] values = new string[names.Length];

                    int i = 0;

                    foreach (string name in names)
                    {
                        values[i] = rkt.GetValue(name).ToString();

                        i++;
                    }
                    return values;
                }
            }
            else
            {
                throw (new Exception("指定项不存在"));
            }
        }
        #endregion

        #region 私有方法
        /// <summary>
        /// 返回RegistryKey对象
        /// </summary>
        /// <param name="keytype">注册表基项枚举</param>
        /// <returns></returns>
        private RegistryKey getRegistryKey(KeyType keytype)
        {
            RegistryKey rk = null;

            switch (keytype)
            {
                case KeyType.HKEY_CLASS_ROOT:
                    rk = Registry.ClassesRoot;
                    break;
                case KeyType.HKEY_CURRENT_USER:
                    rk = Registry.CurrentUser;
                    break;
                case KeyType.HKEY_LOCAL_MACHINE:
                    rk = Registry.LocalMachine;
                    break;
                case KeyType.HKEY_USERS:
                    rk = Registry.Users;
                    break;
                case KeyType.HKEY_CURRENT_CONFIG:
                    rk = Registry.CurrentConfig;
                    break;
            }
            return rk;
        }
        #endregion

        #region 枚举
        /// <summary>
        /// 注册表基项枚举
        /// </summary>
        public enum KeyType : int
        {
            /// <summary>
            /// 注册表基项 HKEY_CLASSES_ROOT
            /// </summary>
            HKEY_CLASS_ROOT,
            /// <summary>
            /// 注册表基项 HKEY_CURRENT_USER
            /// </summary>
            HKEY_CURRENT_USER,
            /// <summary>
            /// 注册表基项 HKEY_LOCAL_MACHINE
            /// </summary>
            HKEY_LOCAL_MACHINE,
            /// <summary>
            /// 注册表基项 HKEY_USERS
            /// </summary>
            HKEY_USERS,
            /// <summary>
            /// 注册表基项 HKEY_CURRENT_CONFIG
            /// </summary>
            HKEY_CURRENT_CONFIG
        }
        #endregion

        #region 直接操作注册表的示例
        //以下从‘读’‘写’‘删除’‘判断’四个事例实现对注册表的简单操作 
        //1.读取指定名称的注册表的值

        // 程序代码
        //private string GetRegistData(string name) 
        //{ 
        //string registData; 
        //RegistryKey hkml = Registry.LocalMachine; 
        //RegistryKey software = hkml.OpenSubKey("SOFTWARE",true); 
        //RegistryKey aimdir = software.OpenSubKey("XXX",true); 
        //registData = aimdir.GetValue(name).ToString(); 
        //return registData; 
        //}

        //以上是读取的注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下的XXX目录中名称为name的注册表值；

        //2.向注册表中写数据

        // 程序代码
        //private void WTRegedit(string name,string tovalue) 
        //{ 
        //RegistryKey hklm = Registry.LocalMachine; 
        //RegistryKey software = hklm.OpenSubKey("SOFTWARE",true); 
        //RegistryKey aimdir = software.CreateSubKey("XXX"); 
        //aimdir.SetValue(name,tovalue); 
        //} 
        //以上是在注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下新建XXX目录并在此目录下创建名称为name值为tovalue的注册表项；

        //3.删除注册表中指定的注册表项

        // 程序代码
        //private void DeleteRegist(string name) 
        //{ 
        //string[] aimnames; 
        //RegistryKey hkml = Registry.LocalMachine; 
        //RegistryKey software = hkml.OpenSubKey("SOFTWARE",true); 
        //RegistryKey aimdir = software.OpenSubKey("XXX",true); 
        //aimnames = aimdir.GetSubKeyNames(); 
        //foreach(string aimKey in aimnames) 
        //{ 
        //if(aimKey == name) 
        //aimdir.DeleteSubKeyTree(name); 
        //} 
        //} 
        //以上是在注册表中HKEY_LOCAL_MACHINE\SOFTWARE目录下XXX目录中删除名称为name注册表项；

        //4.判断指定注册表项是否存在

        // 程序代码
        //private bool IsRegeditExit(string name) 
        //{ 
        //bool _exit = false; 
        //string[] subkeyNames; 
        //RegistryKey hkml = Registry.LocalMachine; 
        //RegistryKey software = hkml.OpenSubKey("SOFTWARE",true); 
        //RegistryKey aimdir = software.OpenSubKey("XXX",true); 
        //subkeyNames = aimdir.GetSubKeyNames(); 
        //foreach(string keyName in subkeyNames) 
        //{ 
        //if(keyName == name) 
        //{ 
        //_exit = true; 
        //return _exit; 
        //} 
        //} 
        //return _exit; 
        //} 
        #endregion


    }
}
