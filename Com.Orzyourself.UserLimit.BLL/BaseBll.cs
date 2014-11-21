using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Com.Orzyourself.UserLimit.DALFactory;
using Com.Orzyourself.UserLimit.IDAL;

namespace Com.Orzyourself.UserLimit.BLL
{
    public abstract class BaseBll<T> where T : class , new()
    {

        protected IDbSession _dbSession;

        public IBaseDal<T> CurrentDal; 

        public BaseBll()
        {
            _dbSession = DbSessionFactory.GetCurrentDbSession();
            SetCurrentDal();
        }
        //需要给CurrentDal赋值。基类 不知道当前Dal是谁。 子类知道。
        //逼迫子类给父类的一个属性赋值。
        protected abstract void SetCurrentDal();
         public  T AddEntity(T entity)
         {
             CurrentDal.AddEntity(entity);
             _dbSession.SaveChanges();
             return entity;
         }

        public  bool DeleteEntity(T entity)
        {
            CurrentDal.DeleteEntity(entity);
            return _dbSession.SaveChanges() > 0;
        }

        public IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda)
        {
            return CurrentDal.LoadEntities(whereLambda);
        }

        public IQueryable<T> LoadPageEntities<S>(int pageIndex, int pageSize, out int total,
            Expression<Func<T, bool>> whereLambda, bool isAse, Expression<Func<T, S>> orderByLambda)
        {
            return CurrentDal.LoadPageEntities(pageIndex, pageSize, out total, whereLambda, isAse, orderByLambda);
        }

        public bool UpdateEntity(T entity)
        {
            CurrentDal.UpdateEntity(entity);
            return _dbSession.SaveChanges() > 0;
        }
    }
}
