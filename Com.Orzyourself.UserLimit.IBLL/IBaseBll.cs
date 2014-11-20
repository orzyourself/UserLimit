using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Com.Orzyourself.UserLimit.IBLL
{
     public interface IBaseBll<T> where T:class , new ()
    {

         T AddEntity(T entity);
         bool DeleteEntity(T entity);
         IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);

         IQueryable<T> LoadPageEntities<S>(int pageIndex, int pageSize, out int total,
           Expression<Func<T, bool>> whereLambda, bool isAse, Expression<Func<T, S>> orderByLambda);

         bool UpdateEntity(T entity);
    }
}
