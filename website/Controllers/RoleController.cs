using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using PagedList;

namespace website.Controllers
{
    public class RoleController : BaseController
    {
        // GET: Role
        public ActionResult Index(int page=1)
        {
            Users user = GetCurrentUser();
            BLL.Users service = new BLL.Users();
            BLL.Role roleservice = new BLL.Role();
            if (user != null)
            {
                ViewData["username"] = user.UserName;
                ViewData["TrueName"] = user.TrueName;
            }            
            var slist = roleservice.QueryList("where 1=1 ").ToPagedList(page, 2);
            return View(slist);
        }
    }
}