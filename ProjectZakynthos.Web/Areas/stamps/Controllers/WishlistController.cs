using System;
using System.Web.Mvc;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using System.Linq;
using ProjectZakynthos.Persistence;
using ProjectZakynthos.Web.Areas.stamps.Models;
using ProjectZakynthos.Domain.Philately;

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
            var userIdentity = new Domain.UserIdentity { Id = new Guid(User.Identity.GetUserId()) };
            var wishlist = repository.GetWishlist(userIdentity);

            if(wishlist == null) { return View(); }

            var model = Mappers.Convert.ToShowWishlistViewModel(wishlist);

            return View(model);
        }

		[HttpGet]
		public ActionResult Manage()
		{
            var wishlistMaxSize = 6;

			var userIdentity = new Domain.UserIdentity { Id = new Guid(User.Identity.GetUserId()) };
            var wishlist = repository.GetWishlist(userIdentity);

            if(wishlist == null)
            {
                return View(new ManageWishlistViewModel {
                    Items = new List<ManagePhilatelicItemViewModel>
                    {
                        new ManagePhilatelicItemViewModel { Catalogue = CataloguesInUse.STANLEY_GIBBONS, Area = "GB" },
                        new ManagePhilatelicItemViewModel { Catalogue = CataloguesInUse.STANLEY_GIBBONS, Area = "GB" },
                        new ManagePhilatelicItemViewModel { Catalogue = CataloguesInUse.STANLEY_GIBBONS, Area = "GB" },
                        new ManagePhilatelicItemViewModel { Catalogue = CataloguesInUse.STANLEY_GIBBONS, Area = "GB" },
                        new ManagePhilatelicItemViewModel { Catalogue = CataloguesInUse.STANLEY_GIBBONS, Area = "GB" },
                        new ManagePhilatelicItemViewModel { Catalogue = CataloguesInUse.STANLEY_GIBBONS, Area = "GB" }
                    }       
                });
            }

            var manageWishlist = Mappers.Convert.ToManageWishlistViewModel(wishlist);
            
            var repeat = Enumerable.Range(1, wishlistMaxSize - manageWishlist.Items.Count());

            var spareSlots = new List<ManagePhilatelicItemViewModel>();
            foreach(var i in repeat)
            {
                spareSlots.Add(new ManagePhilatelicItemViewModel { Catalogue = CataloguesInUse.STANLEY_GIBBONS, Area = "GB" });                  
            }
            var final = manageWishlist.Items.Concat(spareSlots);
            manageWishlist.Items = final;

            return View(manageWishlist);
		}

		[HttpPost]
		public ActionResult Manage(ManageWishlistViewModel model)
		{
            var userIdentity = new Domain.UserIdentity { Id = new Guid(User.Identity.GetUserId()) };
			var wishlist = Mappers.Convert.ToWishlist(model).TakeRelevant();
			
			repository.SaveWishlist(userIdentity, wishlist);

			return RedirectToAction("Index","Wishlist");
		}
    }
}