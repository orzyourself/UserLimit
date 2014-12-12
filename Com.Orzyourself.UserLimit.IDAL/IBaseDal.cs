using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Com.Orzyourself.UserLimit.IDAL
{
    /// <summary>
    /// 数据接口的抽象，其实这种方式不怎么好，因为作为接口，
    /// 你不能这样定义，因为它和具体的一种数据实现关系太紧密了，
    /// 是强耦合的实现，这样的话接口层意义何在？
    /// 以前用ado写的时候，增删改返回的都是影响的行数，现在这样的写法跟EF完全耦合，
    /// 这样感觉写接口就是为了实现约束ef的定义，没多大的意思，搞接口跟作秀似的。
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IBaseDal<T> where T : class , new ()
    {
        /// <summary>
        /// EF的添加数据的操作
        /// </summary>
        /// <param name="entity">数据实体类型</param>
        /// <returns>数据实体类型</returns>
        T AddEntity(T entity);
        /// <summary>
        /// 删除操作
        /// </summary>
        /// <param name="entity">数据实体的类型</param>
        /// <returns>bool值</returns>
        bool DeleteEntity(T entity);
        /// <summary>
        /// 实现普通查询数据的操作
        /// </summary>
        /// <param name="whereLambda">自己定义的方法实现</param>
        /// <returns>为什么是返回IQueryable接口而不是实体类，因为我们需要自己根据这个接口实现更多的操作，完全和EF耦合</returns>
        IQueryable<T> LoadEntities(Expression<Func<T, bool>> whereLambda);
        /// <summary>
        /// 实现分页数据库查询操作
        /// </summary>
        /// <typeparam name="S">按照某个类进行排序</typeparam>
        /// <param name="pageIndex">当前第几页</param>
        /// <param name="pageSize">一页显示多少数据</param>
        /// <param name="total">总条数</param>
        /// <param name="whereLambda">筛选条件</param>
        /// <param name="isAse">如何排序，倒叙还是升序</param>
        /// <param name="orderByLambda">根据哪个字段进行排序</param>
        /// <returns></returns>
        IQueryable<T> LoadPageEntities<S>(int pageIndex, int pageSize, out int total,
            Expression<Func<T, bool>> whereLambda, bool isAse, Expression<Func<T, S>> orderByLambda);
        /// <summary>
        /// 更新数据
        /// </summary>
        /// <param name="entity">数据实体类型</param>
        /// <returns>bool值</returns>
        bool UpdateEntity(T entity);

    }
}
