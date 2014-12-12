using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Orzyourself.UserLimit.Common.Enum;
using Com.Orzyourself.UserLimit.Common.Model;
using Com.Orzyourself.UserLimit.MODEL;

namespace Com.Orzyourself.UserLimit.IBLL
{
     public partial interface IBaseUserBll
     {
         /// <summary>
         /// 实体数据类型的多条件查询
         /// </summary>
         /// <param name="user">将所有的条件都封装到这个类里面，直接调用类</param>
         /// <returns></returns>
         IEnumerable<BaseUser> LoadSearchData(UserQuery user);
         /// <summary>
         /// 验证用户名是否存在
         /// </summary>
         /// <param name="userName">用户名</param>
         /// <returns>枚举值</returns>
         LoginResult CheckUserNameExist(string userName);

         /// <summary>
         /// 批量删除用户或者删除单个用户
         /// </summary>
         /// <param name="deleteIds">一个List集合></param>
         /// <returns>返回影响的行数</returns>
         int DeleteUsers(List<int> deleteIds);

     }
}
