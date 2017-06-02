using System.Web.Mvc;

namespace ProjectZakynthos.Web.Areas.Demo.Controllers
{
    public class WishlistController : Controller
    {
        // GET: Demo/Wishlist
        [Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}