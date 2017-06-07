using ProjectZakynthos.Domain.Philately;
using ProjectZakynthos.Web.Areas.stamps.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectZakynthos.Web.Mappers
{
	public class Convert
	{
		public static Wishlist ToWishlist(ManageWishlistViewModel model)
		{
			var conversion = model.Items.Select(item => new PhilatelicItem {
				Id = Guid.NewGuid(),
				CatalogueReferences = new List<CatalogueReference>
				{
					new CatalogueReference
					{
						Id = Guid.NewGuid(),
						Catalogue = item.Catalogue,
						Number = item.CatalogueNumber,
						Area = item.Area
					}
				},
				Year = item.Year,
				Description = item.Description,
				Conditions = item.Conditions
			});

			return new Wishlist(conversion);
		}

        internal static ShowWishlistViewModel ToShowWishlistViewModel(Wishlist wishlist)
        {
            var conversion = wishlist.Select(item => {
                var catalogue = item.CatalogueReferences.First(x => !string.IsNullOrEmpty(x.Area));

                return new ShowWishlistItemViewModel
                {
                    Id = item.Id,
                    Year = item.Year,
                    Area = catalogue.Area,
                    Description = item.Description ?? "-",
                    CatalogueNumber = $"{ new CatalogueAbbreviations()[catalogue.Catalogue] } {catalogue.Number}",
                    NextAuction = DateTime.MinValue,
                    NextAuctionHouse = "none"
                };
            });
            
            return new ShowWishlistViewModel { Items = conversion};
        }

        internal static ManageWishlistViewModel ToManageWishlistViewModel(Wishlist wishlist)
        {
            var conversion = wishlist.Select(item => {
                var catalogue = item.CatalogueReferences.First(x => !string.IsNullOrEmpty(x.Area));

                return new ManagePhilatelicItemViewModel
                {
                    Year = item.Year,
                    Area = catalogue.Area,
                    Catalogue = catalogue.Catalogue,
                    CatalogueNumber = catalogue.Number,
                    Description = item.Description,
                    Conditions = item.Conditions
                };
            });

            return new ManageWishlistViewModel { Items = conversion };
        }
    }
}