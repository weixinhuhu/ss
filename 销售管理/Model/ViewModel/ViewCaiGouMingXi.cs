using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 销售管理.Model.ViewModel
{
    public class ViewCaiGouMingXi
    {//必须设置为属性DataGridView才能显示
        public DateTime 日期 { get; set; }
        public string 物料代码 { get; set; }
        public string 物料名称 { get; set; }
        public string 规格型号 { get; set; }
        public string 供应商长代码 { get; set; }
        public string 供应商名称 { get; set; }
        public string 单据号码 { get; set; }
        public string 币别{ get; set; }
        public string 发票单位 { get; set; }
        public Decimal? 不含税单价 { get; set; }
        public Decimal? 不含税合计 { get; set; }
        public Decimal? 含税合计 { get; set; }
        public Decimal? 发票数量 { get; set; }
        public string 入库单位 { get; set; }
        public Decimal? 入库数量 { get; set; }
        public Decimal? 入库单价 { get; set; }
        public decimal? 入库金额 { get; set; }
    }
}
