using System.Web.Mvc;

namespace ProjectZakynthos.Web.Areas.stamps.Controllers
{
	public class WishController : Controller
    {

		[Authorize]
        // GET: stamps/Wish
        public ActionResult Index()
        {
            return View();
        }
    }
}