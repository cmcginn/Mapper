using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mapper.Web.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Json2Html()
        {
            return View();
        }

        public ActionResult Json2HtmlMap()
        {
            return View();

        }
    }
}