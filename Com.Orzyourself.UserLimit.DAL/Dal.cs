  //引进TT模板的命名空间

using Com.Orzyourself.UserLimit.MODEL;

namespace Com.Orzyourself.UserLimit.DAL
{
     public partial class BasePermissionDal :BaseDal<BasePermission>,IDAL.IBasePermissionDal
    {

    } 
   public partial class BaseRoleDal :BaseDal<BaseRole>,IDAL.IBaseRoleDal
    {

    } 
   public partial class BaseUserDal :BaseDal<BaseUser>,IDAL.IBaseUserDal
    {

    } 
   public partial class R_Role_PermissionDal :BaseDal<R_Role_Permission>,IDAL.IR_Role_PermissionDal
    {

    } 
   public partial class R_User_PermissionDal :BaseDal<R_User_Permission>,IDAL.IR_User_PermissionDal
    {

    } 
   public partial class R_User_RoleDal :BaseDal<R_User_Role>,IDAL.IR_User_RoleDal
    {

    } 


}