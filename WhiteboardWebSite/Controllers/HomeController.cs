using System.Web.Mvc;

namespace WhiteboardWebSite.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index() {
            return View();
        }

        public ViewResult AboutUs() {
            return View();
        }
    }
}
