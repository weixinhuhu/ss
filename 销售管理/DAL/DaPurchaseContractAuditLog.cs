//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace 销售管理.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class DaPurchaseContractAuditLog
    {
        public int IntID { get; set; }
        public int IntPurchaseContractID { get; set; }
        public int IntOperationID { get; set; }
        public long IntUserID { get; set; }
        public System.DateTime DtCreate { get; set; }
    
        public virtual DaPurchaseContract DaPurchaseContract { get; set; }
        public virtual T_Users T_Users { get; set; }
        public virtual ZdContractStatu ZdContractStatu { get; set; }
    }
}
