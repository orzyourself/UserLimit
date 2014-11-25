using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Com.Orzyourself.UserLimit.Common.Model
{
 
        public class ParamterQuery
        {
            /// <summary>
            /// 当前第几页
            /// </summary>
            public int PageIndex { get; set; }
            /// <summary>
            /// 页面大小
            /// </summary>
            public int PageSize { get; set; }
            /// <summary>
            /// 页面总数
            /// </summary>
            public int Total { get; set; }
        }
    
}
