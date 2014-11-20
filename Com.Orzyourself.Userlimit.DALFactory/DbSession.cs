  //引进TT模板的命名空间
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Orzyourself.UserLimit.IDAL;
using Com.Orzyourself.UserLimit.DAL;

namespace Com.Orzyourself.UserLimit.DALFactory
{
   public  partial  class DbSession:IDbSession
    {
		
   private IBasePermissionDal _BasePermissionDal;
		public IBasePermissionDal BasePermissionDal
		{
			get
			{
				if (_BasePermissionDal == null)
				{
					_BasePermissionDal = DalFactory.GetBasePermissionDal();
				}
				return _BasePermissionDal;
			}
		}
	
   private IBaseRoleDal _BaseRoleDal;
		public IBaseRoleDal BaseRoleDal
		{
			get
			{
				if (_BaseRoleDal == null)
				{
					_BaseRoleDal = DalFactory.GetBaseRoleDal();
				}
				return _BaseRoleDal;
			}
		}
	
   private IBaseUserDal _BaseUserDal;
		public IBaseUserDal BaseUserDal
		{
			get
			{
				if (_BaseUserDal == null)
				{
					_BaseUserDal = DalFactory.GetBaseUserDal();
				}
				return _BaseUserDal;
			}
		}
	
   private IR_Role_PermissionDal _R_Role_PermissionDal;
		public IR_Role_PermissionDal R_Role_PermissionDal
		{
			get
			{
				if (_R_Role_PermissionDal == null)
				{
					_R_Role_PermissionDal = DalFactory.GetR_Role_PermissionDal();
				}
				return _R_Role_PermissionDal;
			}
		}
	
   private IR_User_PermissionDal _R_User_PermissionDal;
		public IR_User_PermissionDal R_User_PermissionDal
		{
			get
			{
				if (_R_User_PermissionDal == null)
				{
					_R_User_PermissionDal = DalFactory.GetR_User_PermissionDal();
				}
				return _R_User_PermissionDal;
			}
		}
	
   private IR_User_RoleDal _R_User_RoleDal;
		public IR_User_RoleDal R_User_RoleDal
		{
			get
			{
				if (_R_User_RoleDal == null)
				{
					_R_User_RoleDal = DalFactory.GetR_User_RoleDal();
				}
				return _R_User_RoleDal;
			}
		}

	}

}

