using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace webCV.Controllers
{
    public class studentController : Controller
    {
        // GET: student
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult education()
        {
            return View();
        }
        public ActionResult projects()
        {
            return View();
        }
        public ActionResult reference()
        {
            return View();
        }
    }
}