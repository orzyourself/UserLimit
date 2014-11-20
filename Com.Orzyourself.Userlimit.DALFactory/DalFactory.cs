  //引进TT模板的命名空间

using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using Com.Orzyourself.UserLimit.IDAL;


namespace Com.Orzyourself.UserLimit.DALFactory
{
        public partial class DalFactory
		{		
			
		public static IBasePermissionDal GetBasePermissionDal()
        {
            
            object obj = Assembly.Load(LimitAssemblyName).CreateInstance(LimitNameSpace + ".BasePermissionDal", true);

            return obj as IBasePermissionDal;
        }
			
		public static IBaseRoleDal GetBaseRoleDal()
        {
            
            object obj = Assembly.Load(LimitAssemblyName).CreateInstance(LimitNameSpace + ".BaseRoleDal", true);

            return obj as IBaseRoleDal;
        }
			
		public static IBaseUserDal GetBaseUserDal()
        {
            
            object obj = Assembly.Load(LimitAssemblyName).CreateInstance(LimitNameSpace + ".BaseUserDal", true);

            return obj as IBaseUserDal;
        }
			
		public static IR_Role_PermissionDal GetR_Role_PermissionDal()
        {
            
            object obj = Assembly.Load(LimitAssemblyName).CreateInstance(LimitNameSpace + ".R_Role_PermissionDal", true);

            return obj as IR_Role_PermissionDal;
        }
			
		public static IR_User_PermissionDal GetR_User_PermissionDal()
        {
            
            object obj = Assembly.Load(LimitAssemblyName).CreateInstance(LimitNameSpace + ".R_User_PermissionDal", true);

            return obj as IR_User_PermissionDal;
        }
			
		public static IR_User_RoleDal GetR_User_RoleDal()
        {
            
            object obj = Assembly.Load(LimitAssemblyName).CreateInstance(LimitNameSpace + ".R_User_RoleDal", true);

            return obj as IR_User_RoleDal;
        }
	}

}