using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Orzyourself.UserLimit.Common.Model;
using Com.Orzyourself.UserLimit.MODEL;

namespace Com.Orzyourself.UserLimit.DAL
{
     public partial  class BaseUserDal
    {

         public IEnumerable<BaseUser> LoadSearchData(UserQuery query)
         {
             var temp = this.LoadEntities(u => true);
             if (!string.IsNullOrEmpty(query.RealName))
             {
                 temp.Where(u => u.RealName.Contains(query.RealName));
             }
             if (!string.IsNullOrEmpty(query.Telephone))
             {
                 temp.Where(u => u.Telephone.Contains(query.Telephone));
             }
             if (!string.IsNullOrEmpty(query.Email))
             {
                 temp.Where(u => u.Email.Contains(query.Email));
             }
             if (query.Enabled != -1)
             {
                 temp.Where(u => u.Enabled == query.Enabled);
             }
             if (!string.IsNullOrEmpty(query.AuditStatus)&&query.AuditStatus!="-1")
             {
                 temp.Where(u => u.AuditStatus.Contains(query.AuditStatus));
             }
             temp = query.DeletionStateCod == 1
                 ? temp.Where(u => u.DeletionStateCode == query.DeletionStateCod)
                 : temp.Where(u => u.DeletionStateCode == 0);
             query.Total = temp.Count();
             return temp.OrderBy(u => u.SortCode).Skip(query.PageSize*(query.PageIndex - 1)).Take(query.PageSize).ToList();
         
         }
    }
}
