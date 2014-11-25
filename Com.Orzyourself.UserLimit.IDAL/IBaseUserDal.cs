using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Orzyourself.UserLimit.Common.Model;
using Com.Orzyourself.UserLimit.MODEL;

namespace Com.Orzyourself.UserLimit.IDAL
{
     public partial interface IBaseUserDal
    {
        /// <summary>
        /// 实体数据类型的多条件查询
        /// </summary>
        /// <param name="user">将所有的条件都封装到这个类里面，直接调用类</param>
        /// <returns></returns>
         IEnumerable<BaseUser> LoadSearchData(UserQuery user);
    }
}
