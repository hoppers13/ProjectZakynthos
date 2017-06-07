using System;
using System.Web.Mvc;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;

using ProjectZakynthos.Persistence;
using ProjectZakynthos.Web.Areas.stamps.Models;
using ProjectZakynthos.Web.Mappers;

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
			var model = new ManageWishlistViewModel
			{
				Items = new List<ManagePhilatelicItemViewModel>
				{
					new ManagePhilatelicItemViewModel{Area = "GB"},
					new ManagePhilatelicItemViewModel{Area = "GB"},
					new ManagePhilatelicItemViewModel{Area = "GB"},
					new ManagePhilatelicItemViewModel{Area = "GB"},
					new ManagePhilatelicItemViewModel{Area = "GB"},
					new ManagePhilatelicItemViewModel{Area = "GB"}					
				}
			};
			
			return View(model);
		}

		[HttpPost]
		public ActionResult Manage(ManageWishlistViewModel model)
		{
            var userIdentity = new Domain.UserIdentity { Id = new Guid(User.Identity.GetUserId()) };
			var wishlist = Mappers.Convert.ToWishlist(model).Relevant();
			
			repository.SaveWishlist(userIdentity, wishlist);

			return View(model);
		}
    }
}