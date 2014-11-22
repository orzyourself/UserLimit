using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Com.Orzyourself.UserLimit.UI.Controllers
{
    public class UserController : Controller
    {
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
	}
}