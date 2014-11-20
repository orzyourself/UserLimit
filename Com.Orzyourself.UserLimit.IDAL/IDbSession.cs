  //引进TT模板的命名空间

//使用TT模板生成代码的片段
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

	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
	   //每个表对应的实体仓储对象
        IDAL.IBasePermissionDal BasePermissionDal { get; }

		   //每个表对应的实体仓储对象
        IDAL.IBaseRoleDal BaseRoleDal { get; }

		   //每个表对应的实体仓储对象
        IDAL.IBaseUserDal BaseUserDal { get; }

		   //每个表对应的实体仓储对象
        IDAL.IR_Role_PermissionDal R_Role_PermissionDal { get; }

		   //每个表对应的实体仓储对象
        IDAL.IR_User_PermissionDal R_User_PermissionDal { get; }

		   //每个表对应的实体仓储对象
        IDAL.IR_User_RoleDal R_User_RoleDal { get; }

		}
}