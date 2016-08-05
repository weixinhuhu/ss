using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Word;

namespace 销售管理.Classes
{
    public static class MyDictionarys
    {
        //字典  采购类型
        //public static Dictionary<int, string> 采购类型 = new Dictionary<int, string>
        //{
        //    { 0, "外购入库" }, 
        //    { 1, "委外加工" }
        //};

        public enum ApproveType
        {
            通过 = 2,
            不通过 = 3
        }

        //public static Dictionary<int, string> 到货记录状态 = new Dictionary<int, string>
        //{
        //    { 1, "等待产品部检验" }, 
        //    { 2, "产品部检验通过" }, 
        //    { 3, "产品部检验不通过" }
        //};
        

        public static T GetDicKeyByValue<T, C>(Dictionary<T, C> dic, C value)
        {

            //Linq
            var key = dic.FirstOrDefault(q => Equals(q.Value, value)).Key;  //get all keys

            return key;

            //var firstKey = dic.FirstOrDefault(q => q.Value == "2").Key;  //get first key
        }

        public static BindingSource GetCmbData(Dictionary<int, string> dic, bool insertAll)
        {
            if (insertAll)
            {
                dic.Add(-1, "全部");
            }
            var bs = new BindingSource {DataSource = dic};
            return bs;
        }
       
    }
}
