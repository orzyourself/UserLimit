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
    
    public partial class BasePermission
    {
        public BasePermission()
        {
            this.R_Role_Permission = new HashSet<R_Role_Permission>();
            this.R_User_Permission = new HashSet<R_User_Permission>();
        }
    
        public int ID { get; set; }
        public string Code { get; set; }
        public string RequestURL { get; set; }
        public Nullable<int> RequestHttpType { get; set; }
        public string PerMission { get; set; }
        public Nullable<int> AllowEdit { get; set; }
        public Nullable<int> AllowDelete { get; set; }
        public Nullable<int> IsVisible { get; set; }
        public Nullable<int> SortCode { get; set; }
        public Nullable<short> DeletionStateCode { get; set; }
        public Nullable<int> Enabled { get; set; }
        public string Description { get; set; }
        public Nullable<System.DateTime> CreateOn { get; set; }
        public string CreateUserID { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> ModifiedOn { get; set; }
        public string ModifiedUserID { get; set; }
        public string ModifiedBy { get; set; }
       //导航属性
       [JsonIgnore]
        public virtual ICollection<R_Role_Permission> R_Role_Permission { get; set; }
       [JsonIgnore]
        public virtual ICollection<R_User_Permission> R_User_Permission { get; set; }
    }
}
