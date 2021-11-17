using BusinessLayer2.Concrate;
using DataAccessLayer.Concrate.Context;
using DataAccessLayer.Concrate.EntityFramework;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace NLayerBlogProje.Controllers
{
    
    public class LoginController : Controller
    {
        // GET: Login
        AdminManeger maneger = new AdminManeger(new EFAdminDal());
        public ActionResult Index(Admin admin)
        {
            //Context context = new Context();
            //var values = context.Admins.FirstOrDefault(x => x.UserName == admin.UserName && x.Password == admin.Password);
            var values = maneger.GetAdminBL(admin);
            if (values != null)
            {
                FormsAuthentication.SetAuthCookie(values.UserName,false);
                Session["UserName"] = values.UserName;
                return RedirectToAction("AdminHome", "AdminHome");
            }
            else
            {
                return View();
            }
            

        }
        public ActionResult LoginOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
    }
}