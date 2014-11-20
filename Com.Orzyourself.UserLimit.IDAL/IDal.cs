  //引进TT模板的命名空间

//使用TT模板生成代码的片段
using Com.Orzyourself.UserLimit.MODEL;

namespace Com.Orzyourself.UserLimit.IDAL
{

	//在这里需要一个for循环来遍历数据库中所有的表放置在下面即可，这样就实现了所有的表对应的仓储显示出来了。
	    public partial interface IBasePermissionDal : IBaseDal<BasePermission>
    {
     
    }

	    public partial interface IBaseRoleDal : IBaseDal<BaseRole>
    {
     
    }

	    public partial interface IBaseUserDal : IBaseDal<BaseUser>
    {
     
    }

	    public partial interface IR_Role_PermissionDal : IBaseDal<R_Role_Permission>
    {
     
    }

	    public partial interface IR_User_PermissionDal : IBaseDal<R_User_Permission>
    {
     
    }

	    public partial interface IR_User_RoleDal : IBaseDal<R_User_Role>
    {
     
    }

}