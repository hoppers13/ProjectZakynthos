using System.Web.Mvc;

namespace ProjectZakynthos.Web.Areas.stamps.Controllers
{
	[Authorize]
    public class WishlistController : Controller
    {
        // GET: stamps/Wishlist
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Manage()
		{
			return View();
		}
    }
}