using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Orzyourself.UserLimit.DAL;
using Com.Orzyourself.UserLimit.IDAL;


namespace Com.Orzyourself.UserLimit.DALFactory
{
     public  partial  class DbSession:IDbSession
    {
        public int SaveChanges()
        {
            //让当前的上下文（一次一个上下文。）进行提交。
            return DbContextFactory.GetCurrentDbSession().SaveChanges();
        }

        public int ExcuteSql(string strSql, System.Data.Common.DbParameter[] parameters)
        {
            throw new NotImplementedException();
        }
    }
}
