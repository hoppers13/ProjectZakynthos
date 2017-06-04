using System.Web.Mvc;
using ProjectZakynthos.Web.Areas.stamps.Models;
using System.Collections.Generic;

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

		[HttpGet]
		public ActionResult Manage()
		{
			var model = new WishlistViewModel
			{
				Items = new List<PhilatelicItem>
				{
					new PhilatelicItem{Country = "GB"},
					new PhilatelicItem{Country = "GB"},
					new PhilatelicItem{Country = "GB"},
					new PhilatelicItem{Country = "GB"},
					new PhilatelicItem{Country = "GB"},
					new PhilatelicItem{Country = "GB"}					
				}
			};
			
			return View(model);
		}

		[HttpPost]
		public ActionResult Manage(WishlistViewModel model)
		{
			return View(model);
		}

    }
}