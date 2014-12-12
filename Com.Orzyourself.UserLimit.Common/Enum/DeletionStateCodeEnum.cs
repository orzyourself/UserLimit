using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Orzyourself.UserLimit.Common.Enum
{
    /// <summary>
    /// 伪删除标志
    /// </summary>
   public enum DeletionStateCodeEnum
    {
        /// <summary>
        /// 未被删除标志
        /// </summary>
        NoDelete = 0,
        /// <summary>
        /// 删除标志
        /// </summary>
        Deleted = 1
    }
}
