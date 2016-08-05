using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace 销售管理.DAL
{
    class ClassAttribute
    {
    }
    [MetadataType(typeof(DaSupplierContactMetaData))]
    public partial class DaSupplierContact
    {
       
    }

    [MetadataType(typeof(DaSupplierMetaData))]
    public partial class DaSupplier
    {

    }

    [MetadataType(typeof(DaGoodsMetaData))]
    public partial class DaGoods
    {

    }

    [MetadataType(typeof(DaGoodsTypeMetaData))]
    public partial class DaGoodsType
    {

    }

    [MetadataType(typeof(DaInvoiceMetaData))]
    public partial class DaInvoice
    {

    }

    [MetadataType(typeof(DaStockInMetaData))]
    public partial class DaStockIn
    {

    }

    class DaSupplierContactMetaData
    {
        public int IntID { get; set; }
        public int IntSupplierID { get; set; }

        [MaxLength(64, ErrorMessage = "姓名长度不能超过64")]
        [Required(ErrorMessage = "姓名不能为空")]
        public string VcName { get; set; }
        [MaxLength(32, ErrorMessage = "职务长度不能超过32")]
        public string VcPost { get; set; }
        [MaxLength(32, ErrorMessage = "固话长度不能超过16")]
        public string VcTel { get; set; }
        [MaxLength(32, ErrorMessage = "传真长度不能超过16")]
        public string VcFax { get; set; }
        [MaxLength(32, ErrorMessage = "手机长度不能超过32")]
        public string VcMobile { get; set; }
        [MaxLength(16, ErrorMessage = "QQ长度不能超过16")]
        public string VcQQ { get; set; }
        [MaxLength(32, ErrorMessage = "邮箱长度不能超过32")]
        public string VcEmail { get; set; }
        [MaxLength(128, ErrorMessage = "备注长度不能超过128")]
        public string VcRemark { get; set; }
        public System.DateTime DtCreate { get; set; }
        public long IntEmpNum { get; set; }

        public virtual DaSupplier DaSupplier { get; set; }
        public virtual T_Users T_Users { get; set; }
    }

    class DaSupplierMetaData
    {
        public int IntID { get; set; }
        public string VcNum { get; set; }
        [MaxLength(64, ErrorMessage = "名称长度不能超过64")]
        [Required(ErrorMessage = "名称不能为空")]
        public string VcName { get; set; }
        [MaxLength(32, ErrorMessage = "注册资本长度不能超过32")]
        //[Required(ErrorMessage = "注册资本不能为空")]
        public string VcRegCapital { get; set; }
        [MaxLength(32, ErrorMessage = "法人代表长度不能超过32")]
        public string VcLegalRep { get; set; }
        [MaxLength(32, ErrorMessage = "税号长度不能超过32")]
        public string VcTaxID { get; set; }
        [MaxLength(64, ErrorMessage = "开户银行长度不能超过64")]
        public string VcOpeningBank { get; set; }
        [MaxLength(32, ErrorMessage = "银行账号长度不能超过32")]
        public string VcBankAccount { get; set; }
        [MaxLength(64, ErrorMessage = "经营地址长度不能超过64")]
        public string VcAddress { get; set; }
        [MaxLength(32, ErrorMessage = "公司网站长度不能超过32")]
        public string VcWebsite { get; set; }
        [MaxLength(32, ErrorMessage = "公司固话长度不能超过32")]
        public string VcTel { get; set; }
        [MaxLength(32, ErrorMessage = "公司传真长度不能超过32")]
        public string VcFax { get; set; }
        [MaxLength(16, ErrorMessage = "邮编长度不能超过16")]
        public string VcPostCode { get; set; }
        public int IntStatus { get; set; }
        [MaxLength(128, ErrorMessage = "备注长度不能超过128")]
        public string VcRemark { get; set; }
        public System.DateTime DtCreate { get; set; }
        public long IntEmpNum { get; set; }
    }

    class DaGoodsMetaData
    {
        public int IntID { get; set; }
        [MaxLength(16, ErrorMessage = "物品编码长度不能超过16")]
        [Required(ErrorMessage = "物品编码不能为空")]
        public string VcNum { get; set; }
        [MaxLength(32, ErrorMessage = "名称长度不能超过32")]
        [Required(ErrorMessage = "名称不能为空")]
        public string VcName { get; set; }
        
        [Required(ErrorMessage = "单位不能为空")]
        [Range(1,int.MaxValue)]
        public int IntUnit { get; set; }
        [MaxLength(64, ErrorMessage = "规格型号长度不能超过64")]
        [Required(ErrorMessage = "规格型号不能为空")]
        public string VcNorms { get; set; }
        public int IntTypeID { get; set; }
        [MaxLength(128, ErrorMessage = "备注长度不能超过128")]
        public string VcRemark { get; set; }
        public System.DateTime DtCreate { get; set; }
        public long IntEmpNum { get; set; }

    }

     class DaGoodsTypeMetaData
     {
         public int IntID { get; set; }
         [MaxLength(32, ErrorMessage = "类目名称长度不能超过32")]
         [Required(ErrorMessage = "类目名称不能为空")]
         public string VcType { get; set; }
         public int IntParentID { get; set; }
         public System.DateTime DtCreate { get; set; }
         public long IntEmpNum { get; set; }
     }

     class DaInvoiceMetaData
     {
         public int IntID { get; set; }
         
         [MaxLength(32, ErrorMessage = "发票号码长度不能超过32")]
         [Required(ErrorMessage = "发票号码不能为空")]
         public string VcNum { get; set; }
         [MaxLength(16, ErrorMessage = "单位长度不能超过16")]
         public string VcUnit { get; set; }
         public Nullable<decimal> NumCount { get; set; }
         [Required(ErrorMessage = "不含税单价不能为空")]
         public decimal MonPrice { get; set; }
         [Required(ErrorMessage = "不含税合计不能为空")]
         public decimal MonSumNoTax { get; set; }
         [Required(ErrorMessage = "价税合计不能为空")]
         public decimal MonSum { get; set; }
         public int IntStatus { get; set; }
         [MaxLength(128, ErrorMessage = "备注长度不能超过128")]
         public string VcRemark { get; set; }
         public System.DateTime DtCreate { get; set; }
         public long IntEmpNum { get; set; }
     }

    class DaStockInMetaData
    {
        public int IntID { get; set; }
        
        [MaxLength(16, ErrorMessage = "单位长度不能超过16")]
        public string VcUnit { get; set; }
        public Nullable<decimal> NumCount { get; set; }
        [Required(ErrorMessage = "入库单价不能为空")]
        public decimal MonPrice { get; set; }
        [Required(ErrorMessage = "入库合计不能为空")]
        public decimal MonSum { get; set; }
        public int IntStatus { get; set; }
        [MaxLength(128, ErrorMessage = "备注长度不能超过128")]
        public string VcRemark { get; set; }
        public System.DateTime DtCreate { get; set; }
        public long IntEmpNum { get; set; }
    }
}
