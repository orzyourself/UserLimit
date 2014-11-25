using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Orzyourself.UserLimit.Common.Enum;
using Com.Orzyourself.UserLimit.Common.Model;
using Com.Orzyourself.UserLimit.MODEL;

namespace Com.Orzyourself.UserLimit.BLL
{
    public partial class BaseUserBll
    {
        public IEnumerable<BaseUser> LoadSearchData(UserQuery query)
        {
           return _dbSession.BaseUserDal.LoadSearchData(query);
        }

         public LoginResult CheckUserNameExist(string userName)
         {
            BaseUser user = _dbSession.BaseUserDal.LoadEntities(u => u.UserName == userName).FirstOrDefault();
             if (user != null)
             {
                 return LoginResult.UserExist;
             }
             return LoginResult.UserNotExist;
         }
    }
}
