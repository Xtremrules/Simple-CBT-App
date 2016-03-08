using System.Web.Mvc;

namespace CBT.WebUI.Controllers
{
    [Authorize(Roles = "AdminRole")]
    public class CBTController : Controller
    {
        // GET: CBT
        public ActionResult Index()
        {
            return View();
        }
    }
}