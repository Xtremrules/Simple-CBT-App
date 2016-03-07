using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CBT.WebUI.Controllers
{
    public class CBTController : Controller
    {
        // GET: CBT
        public ActionResult Index()
        {
            return View();
        }
    }
}