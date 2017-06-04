using ProjectZakynthos.Persistence;
using System.Web.Mvc;

namespace ProjectZakynthos.Web.Areas.Demo.Controllers
{
	public class WishlistController : Controller
    {
		IWishlistRepository repository;

		public WishlistController(IWishlistRepository repository)
		{
			this.repository = repository;
		}
		
		// GET: Demo/Wishlist
		[Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}