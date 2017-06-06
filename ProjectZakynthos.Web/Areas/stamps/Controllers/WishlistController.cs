using System.Web.Mvc;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

using ProjectZakynthos.Persistence;
using ProjectZakynthos.Web.Areas.stamps.Models;

namespace ProjectZakynthos.Web.Areas.stamps.Controllers
{
	[Authorize]
    public class WishlistController : Controller
    {
        IWishlistRepository repository;

        public WishlistController(IWishlistRepository repository)
        {
            this.repository = repository;
        }

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
				Items = new List<PhilatelicItemViewModel>
				{
					new PhilatelicItemViewModel{Area = "GB"},
					new PhilatelicItemViewModel{Area = "GB"},
					new PhilatelicItemViewModel{Area = "GB"},
					new PhilatelicItemViewModel{Area = "GB"},
					new PhilatelicItemViewModel{Area = "GB"},
					new PhilatelicItemViewModel{Area = "GB"}					
				}
			};
			
			return View(model);
		}

		[HttpPost]
		public ActionResult Manage(WishlistViewModel model)
		{
            var user = User.Identity.GetUserId();



			return View(model);
		}
    }
}