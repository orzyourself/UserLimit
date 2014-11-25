using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Orzyourself.UserLimit.Common.Enum
{
    /// <summary>
    /// 枚举出当用户登录的时候出现的各种错误
    /// </summary>
     public enum LoginResult
    {
         /// <summary>
         /// 密码错误
         /// </summary>
         PwdError=0,
         /// <summary>
         /// 用户名不存在
         /// </summary>
         UserNotExist=1,
         /// <summary>
         /// 用户名存在
         /// </summary>
         UserExist=2,
         /// <summary>
         /// 用户名为空
         /// </summary>
         UserIsNull=3,
         /// <summary>
         /// 密码为空
         /// </summary>
         PwdIsNull=4,
         /// <summary>
         /// 登陆成功
         /// </summary>
         LoginSuccess=5

    }
}
