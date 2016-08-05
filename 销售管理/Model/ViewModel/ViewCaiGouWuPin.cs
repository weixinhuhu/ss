using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 销售管理.Model.ViewModel
{
    public class ViewCaiGouWuPin
    {
        //必须设置为属性DataGridView才能显示
        public string 物品编号 { get; set; }
        public string 物品名称 { get; set; }
        public string 单位 { get; set; }
        public decimal? 参考单价 { get; set; }
        public string 规格型号 { get; set; }
        public string 物品分类 { get; set; }
        public string 备注 { get; set; }
    }
}
