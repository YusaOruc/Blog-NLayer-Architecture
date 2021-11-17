using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NLayerBlogProje.Controllers
{
    public class ContactController : Controller
    {
        // GET: Contact
        public PartialViewResult ContactIndex()
        {
            return PartialView();
        }
    }
}