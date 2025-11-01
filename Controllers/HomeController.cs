using System.Runtime.InteropServices.WindowsRuntime;
using System.Web.Mvc;

namespace sereneVilla.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ContactUs(){
            return View();
        }

        public ActionResult AboutUs()
        {
            return View();
        }

        public ActionResult PlacesToVisit() {
            return View();
        }
    }
}