using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using System.Data.Entity;
using Com.Orzyourself.UserLimit.MODEL;


namespace Com.Orzyourself.UserLimit.DAL
{
    /// <summary>
    /// 保证EF的上下文。线程内实例唯一，一次请求一个实例
    /// </summary>
     public class DbContextFactory
    {
         public static DbContext GetCurrentDbSession()
         {
             //线程内实例唯一
             DbContext db = HttpContext.Current.Items["DbContext"] as DbContext;
             if (db == null)
             {
                 db = new UserLimitEntities();
                 HttpContext.Current.Items.Add("DbContext",db);
             }
             return db;
         }
    }
}
