using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;
using Com.Orzyourself.UserLimit.BLL;
using Com.Orzyourself.UserLimit.Common;
using Com.Orzyourself.UserLimit.Common.Enum;
using Com.Orzyourself.UserLimit.Common.Model;
using Com.Orzyourself.UserLimit.MODEL;

namespace Com.Orzyourself.UserLimit.UI.Controllers
{
    public class UserController : Controller
    {
        //首先采用这种方式，之后再改用框架去进行解耦
        IBLL.IBaseUserBll _userBll = new BaseUserBll();
        //
        // GET: /User/
        public ActionResult Index()
        {
            IEnumerable<SelectListItem> select = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "-1",Text = "请选择"},
                new SelectListItem() {Value = "0",Text = "是职员"},
                new SelectListItem() {Value = "1",Text = "不是职员"}
            };
            IEnumerable<SelectListItem> selectAuditStatus = new List<SelectListItem>()
            {
                new SelectListItem() {Value = "-1",Text = "请选择"},
                new SelectListItem() {Value = "0",Text = "已审核"},
                new SelectListItem() {Value = "1",Text = "未审核"}
            };
            ViewData["select"] = select;
            ViewData["selectAuditSattus"] = selectAuditStatus;
            return View();
        }

        public ActionResult GetUserInfo()
        {
            return Content("");
        }
        public ActionResult GetAllUserInfos(UserQuery query)
        {
            //实现对用户分页的查询，rows：一共多少条，page：请求的当前第几页
            //这是easyui默认传递的参数，我们只需要按照他的api来即可
            int pageIndex = Request["page"] == null ? 1: int.Parse(Request["page"]);
            int pageSize = Request["rows"] == null? 10 : int.Parse(Request["rows"]);
            query.PageIndex = pageIndex;
            query.PageSize = pageSize;
            #region 弃用代码
            //采用模型绑定的方式获取表单数据
            //string RealName = Request["RealName"];
            //string Telephone = Request["Telephone"];
            //string Email = Request["Email"];
            //int? Enabled = Request["Enabled"] == null ? -1 : int.Parse(Request["Enabled"]);
            //string AuditStatus = Request["AuditStatus"];
            //int? DeletionStateCode = Request["DeletionStateCode"] == null ? 0 : int.Parse(Request["DeletionStateCode"]);
            //int total = 0;
            //封装一个业务逻辑层的方法，来处理分页过滤事件
            //var userQuery = new UserQuery()
            //{
            //    PageSize = pageSize,
            //    PageIndex = pageIndex,
            //    RealName = RealName,
            //    Telephone = Telephone,
            //    Email = Email,
            //    Enabled = Enabled,
            //    AuditStatus = AuditStatus,
            //    Total = 0,
            //    DeletionStateCod = DeletionStateCode
            //}; 
            #endregion

            var data = _userBll.LoadSearchData(query).Select(u=>new {ID=u.ID,UserName = u.UserName,RealName=u.RealName,Email=u.Email,Gender=u.Gender,Mobile=u.Mobile,QICQ=u.QICQ,CreateBy=u.CreateBy,ModifiedBy=u.ModifiedBy});
            var result = new {total = query.Total, rows = data};
            
            
            return Json(JsonSerializable.SerializableToString(result),JsonRequestBehavior.AllowGet);
        }
        /// <summary>
        /// 添加用户信息(其实这些默认的值在数据库里就可以给了，数据库里面不是有那个默认值的约束么)
        /// </summary>
        /// <param name="user">通过模型绑定传递表单的参数</param>
        /// <returns>用户添加是否成功的标志</returns>
        public ActionResult RegisterUser(BaseUser user)
        {
            user.Code = Guid.NewGuid().ToString(); //随机产生的一些数据
            user.QuickQuery = user.UserName;    //获取数据的查询码
            user.UserFrom = "";   //用户来源
            user.Lang = "";  //默认系统识别的是汉语
            user.IsStaff = (int?)StaffEnum.IsStaff;         //默认是职员
            user.IsVisible = (int?)VisibleEnum.Visible;     //默认显示信息
            user.Enabled = (int?)EnabledEnum.Enabled;       //默认用户有效
            user.AuditStatus = "";  //默认添加的用户已经经过审核
            user.DeletionStateCode = (int?)DeletionStateCodeEnum.NoDelete;  //默认没有伪删除
            user.CreateOn = DateTime.Now.ToLocalTime();  //默认创建用户日期
            BaseUser baseUser = Session["User"] as BaseUser;  //不要担心为空，因为会进行处理的，没有值就进不到这一步
            //user.CreateUserID = baseUser.Code;  //获取添加此用户的管理者的ID
            //user.CreateBy = baseUser.UserName;  //获取添加此用户的管理者的名称

            _userBll.AddEntity(user);
            return Content("ok");
        }
        public ActionResult CheckUserName(string UserName)
        {
           LoginResult result =  _userBll.CheckUserNameExist(UserName);
            if (result == LoginResult.UserExist)
            {
                return Content("error");
            }
            return Content("ok");
        }

        public ActionResult UpdateUser()
        {
            return Content("");
        }

        public ActionResult DeleteUser()
        {
            return Content("");
        }

        
	}
}