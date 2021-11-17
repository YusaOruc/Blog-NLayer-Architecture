using BusinessLayer.Concrate;

using DataAccessLayer.Concrate.EntityFramework;
using EntityLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PagedList;
using PagedList.Mvc;

namespace NLayerBlogProje.Controllers.AdminPanel
{
    [Authorize]
    public class AdminMessageController : Controller
    {
        // GET: AdminMessage
        MessageManeger messageManeger = new MessageManeger(new EFMessageDal());
        public ActionResult AdminMessage(int p=1)
        {
            var values = messageManeger.ListBL().ToPagedList(p,10);
            return View(values);
        }
       
        [HttpPost]
        public ActionResult AddMessage(Message message)
        {
            messageManeger.InsertBL(message);
            return RedirectToAction("#");
        }


        public ActionResult GetDetailMessage(int id)
        {
            var values = messageManeger.GetBL(id);
            return View(values);
        }
    }
}