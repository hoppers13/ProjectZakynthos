using ProjectZakynthos.Persistence;
using System.Web.Mvc;

namespace ProjectZakynthos.Web.Areas.Demo.Controllers
{
	public class WishController : Controller
    {
		IWishRepository repository;

		public WishController(IWishRepository repository)
		{
			this.repository = repository;
		}

		// GET: Demo/Wish
		[Authorize]
        public ActionResult Index()
        {
            return View();
        }
    }
}