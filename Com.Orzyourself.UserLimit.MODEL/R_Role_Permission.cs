//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Com.Orzyourself.UserLimit.MODEL
{
    using Newtonsoft.Json;//添加引用
    using System;
    using System.Collections.Generic;
    
    public partial class R_Role_Permission
    {
        public int ID { get; set; }
        public int RoleID { get; set; }
        public int PermissionID { get; set; }
        public Nullable<int> Enable { get; set; }
        public string Description { get; set; }
        public Nullable<int> SortCode { get; set; }
        public Nullable<int> DeletionStateCode { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string CreateUserID { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedUserID { get; set; }
        public string ModifiedBy { get; set; }
       //导航属性
       [JsonIgnore]
        public virtual BasePermission BasePermission { get; set; }
       [JsonIgnore]
        public virtual BaseRole BaseRole { get; set; }
    }
}
