using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Management;

namespace PubClasses
{
   

    public class ComputerInfo
    {
        //获取HardDisk的序列号（两种方法）：
        public static string GetHardDiskID()
        {
            //Get the first Hard disk 14 bits ID  
            var strHardDiskID = string.Empty;
            try
            {
                var searcher = new ManagementObjectSearcher("SELECT * FROM Win32_PhysicalMedia");
                var moc = searcher.Get();
                foreach (var mo in moc)
                {
                    strHardDiskID = mo["SerialNumber"].ToString().Trim();
                    break;
                }
                return strHardDiskID;
            }
            catch
            {
                return string.Empty;
            }
        }

        public static string GetHardDiskID2()
        {
            var strHardDiskID = string.Empty;
            ManagementObjectSearcher wmiSearcher = new ManagementObjectSearcher();
            /* 
             1. 接口 
             2. 型号 
             3. 驱动版本号 
             4. 硬盘出厂序列号 
             */
            //signature 需要程序以管理员身份运行  
            try
            {
                wmiSearcher.Query = new SelectQuery("Win32_DiskDrive", "", new string[] { "PNPDeviceID", "signature" });
                ManagementObjectCollection myCollection = wmiSearcher.Get();
                ManagementObjectCollection.ManagementObjectEnumerator em = myCollection.GetEnumerator();
                myCollection.GetEnumerator();
                em.MoveNext();
                ManagementBaseObject mo = em.Current;
                strHardDiskID = mo.Properties["signature"].Value.ToString().Trim();
                return strHardDiskID;
            }
            catch
            {
                return string.Empty;
            }
        }

        //获取CPU的ID：
        public static string GetCpuID()
        {
            //Get the first CPU 16 bits ID  
            var strCpuID = string.Empty;
            try
            {
                var mc = new ManagementClass("Win32_Processor");
                var moc = mc.GetInstances();
                foreach (var mo in moc)
                {
                    strCpuID = mo.Properties["ProcessorId"].Value.ToString();
                    break;
                }
                return strCpuID;
            }
            catch
            {
                return string.Empty;
            }
        }

        //获取IP地址：
        public static string GetIPAddress()
        {
            var ipAddr = string.Empty;
            try
            {
                var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                var moc = mc.GetInstances();
                foreach (var mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        System.Array ar;
                        ar = (System.Array)(mo.Properties["IpAddress"].Value);
                        ipAddr = ar.GetValue(0).ToString();
                        break;
                    }
                }
                return ipAddr;
            }
            catch
            {
                return string.Empty;
            }
        }

        //获取Mac地址：
        public static string GetMacAddress()
        {
            var mac = string.Empty;
            try
            {
                var mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
                var moc = mc.GetInstances();
                foreach (var mo in moc)
                {
                    if ((bool)mo["IPEnabled"] == true)
                    {
                        mac = mo["MacAddress"].ToString();
                        break;
                    }
                }
                return mac;
            }
            catch
            {
                return string.Empty;
            }
        }

        //获取computer名字1：
        public static string GetComputerName()
        {
            //for example: lvsaint-pc  
            var cName = string.Empty;
            try
            {
                return System.Environment.GetEnvironmentVariable("ComputerName");
            }
            catch
            {
                return string.Empty;
            }
        }
        ////获取computer名字2：
        //public static string GetComputerName()
        //{
        //    //for example: lvsaint-pc  
        //    var cName = string.Empty;
        //    try
        //    {
        //        return System.Environment.MachineName;
        //    }
        //    catch
        //    {
        //        return string.Empty;
        //    }
        //}

        //获取电脑登录用户名信息：
        public static string GetLoginUserName()
        {
            var loginName = string.Empty;
            try
            {
                var mc = new ManagementClass("Win32_ComputerSystem");
                var moc = mc.GetInstances();
                foreach (var mo in moc)
                {
                    loginName = mo["UserName"].ToString();
                    break;
                }
                return loginName;
            }
            catch
            {
                return string.Empty;
            }
        }

        //获取系统类型：
        public static string GetSystemType()
        {
            //for example:X86-based PC  
            var sysType = string.Empty;
            try
            {
                var mc = new ManagementClass("Win32_ComputerSystem");
                var moc = mc.GetInstances();
                foreach (var mo in moc)
                {
                    sysType = mo["SystemType"].ToString();
                }
                return sysType;
            }
            catch
            {
                return string.Empty;
            }
        }

        //获取物理内存：
        public static string GetTotalPhysicalMemory()
        {
            var totalPhyMem = string.Empty;
            try
            {
                var mc = new ManagementClass("Win32_ComputerSystem");
                var moc = mc.GetInstances();
                foreach (var mo in moc)
                {
                    totalPhyMem = mo["TotalPhysicalMemory"].ToString();
                    break;
                }
                return totalPhyMem;
            }
            catch
            {
                return string.Empty;
            }
        }

   



    }
}
