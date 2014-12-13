using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Com.Orzyourself.UserLimit.DAL
{
     public class BaseDal<T> where T:class ,new()
     {
         private DbContext db;

         public BaseDal()
         {
             db = DbContextFactory.GetCurrentDbSession();
         }

         public T AddEntity(T entity)
         {
             db.Set<T>().Add(entity);
             return entity;
         }

         public bool UpdateEntity(T entity)
         {
             db.Entry(entity).State = EntityState.Modified;
             return true;
         }

         public bool DeleteEntity(T entity)
         {
             db.Entry(entity).State = EntityState.Deleted;
             return true;
         }
         //db.Set<UserInfo>().Where(u => u.ID > 10).Select(u => u);
         public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLamdba)
         {
             return db.Set<T>().Where(whereLamdba);
         }

         public IQueryable<T> LoadPageEntities<S>(int pageIndex, int pageSize, out int total,
             Expression<Func<T, bool>> whereLambda, bool isAse, Expression<Func<T, S>> orderByLambda)
         {
             IQueryable<T> temp = db.Set<T>().Where(whereLambda);
             total = temp.Count();

             if (isAse)
             {
                 temp = temp.OrderBy(orderByLambda)
                     .Skip(pageSize*(pageIndex - 1))
                     .Take(pageSize);
             }
             else
             {
                 temp = temp.OrderByDescending(orderByLambda)
                     .Skip(pageSize*(pageIndex - 1))
                     .Take(pageSize);
             }
             return temp;
         }
     }
}
