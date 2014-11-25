using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Orzyourself.UserLimit.Common.Model
{
    public class UserQuery : ParamterQuery
    {
        /// <summary>
        /// 真是姓名
        /// </summary>
        public string RealName { get; set; }
        /// <summary>
        /// 电话号码
        /// </summary>
        public string Telephone { get; set; }
        /// <summary>
        /// 邮箱
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// 此用户是否有效
        /// </summary>
        public int? Enabled { get; set; }
        /// <summary>
        /// 用户的状态
        /// </summary>
        public string AuditStatus { get; set; }
        /// <summary>
        /// 删除的标志
        /// </summary>
        public int? DeletionStateCod { get; set; }


    }
}
