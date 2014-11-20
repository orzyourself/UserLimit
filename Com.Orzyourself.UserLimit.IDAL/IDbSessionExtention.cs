using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Orzyourself.UserLimit.IDAL
{
    public partial interface IDbSession
    {
        /// <summary>
        /// 将当前应用程序跟数据库的会话内所有实体的变化更新回数据库
        /// </summary>
        /// <returns>返回一个int类型的的执行结果</returns>
        int SaveChanges();
        /// <summary>
        /// 执行sql语句的写法  EF5.0
        ///  EF4.0的写法   int ExcuteSql(string strSql, ObjectParameter[] parameters);
        /// </summary>
        /// <param name="strSql">执行的sql语句</param>
        /// <param name="parameters">参数</param>
        /// <returns>返回的int类型</returns>
        int ExcuteSql(string strSql, DbParameter[] parameters);

    }

}
