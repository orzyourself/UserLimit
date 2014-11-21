  //引进TT模板的命名空间
using Com.Orzyourself.UserLimit.MODEL;
using Com.Orzyourself.UserLimit.IBLL;

namespace Com.Orzyourself.UserLimit.BLL
{
  	    public partial class BasePermissionBll : BaseBll<BasePermission>,IBasePermissionBll
    {
         protected override void SetCurrentDal()
        {
            CurrentDal = _dbSession.BasePermissionDal;
        }
    }

	    public partial class BaseRoleBll : BaseBll<BaseRole>,IBaseRoleBll
    {
         protected override void SetCurrentDal()
        {
            CurrentDal = _dbSession.BaseRoleDal;
        }
    }

	    public partial class BaseUserBll : BaseBll<BaseUser>,IBaseUserBll
    {
         protected override void SetCurrentDal()
        {
            CurrentDal = _dbSession.BaseUserDal;
        }
    }

	    public partial class R_Role_PermissionBll : BaseBll<R_Role_Permission>,IR_Role_PermissionBll
    {
         protected override void SetCurrentDal()
        {
            CurrentDal = _dbSession.R_Role_PermissionDal;
        }
    }

	    public partial class R_User_PermissionBll : BaseBll<R_User_Permission>,IR_User_PermissionBll
    {
         protected override void SetCurrentDal()
        {
            CurrentDal = _dbSession.R_User_PermissionDal;
        }
    }

	    public partial class R_User_RoleBll : BaseBll<R_User_Role>,IR_User_RoleBll
    {
         protected override void SetCurrentDal()
        {
            CurrentDal = _dbSession.R_User_RoleDal;
        }
    }


}