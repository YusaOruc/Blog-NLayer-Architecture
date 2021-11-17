using BusinessLayer.Concrate;
using DataAccessLayer.Concrate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerBlogProje.Controllers
{
    public class SkillsController : Controller
    {
        // GET: Skills
        SkillManeger skillManeger = new SkillManeger(new EFSkillDal());
        public PartialViewResult SkillsIndex()
        {
            var values = skillManeger.ListBL();
            return PartialView(values);
        }
    }
}