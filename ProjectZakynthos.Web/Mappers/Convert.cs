using ProjectZakynthos.Domain.Philately;
using ProjectZakynthos.Web.Areas.stamps.Models;
using System;
using System.Linq;

namespace ProjectZakynthos.Web.Mappers
{
    public class Convert
	{
		public static Wishlist ToWishlist(ManageWishlistViewModel model)
		{
			var conversion = model.Items.Select(item => new PhilatelicItem {
				Id = Guid.NewGuid(),
				CatalogueReference = 
                    new CatalogueReference
					{
						Catalogue = item.Catalogue,
						Number = item.CatalogueNumber,
						Area = item.Area
					},
				Year = item.Year,
				Description = item.Description,
				Conditions = item.Conditions
			});

			return new Wishlist(conversion);
		}

        internal static ShowWishlistViewModel ToShowWishlistViewModel(Wishlist wishlist)
        {
            var conversion = wishlist.Select(item =>                
                new ShowWishlistItemViewModel
                {
                    Id = item.Id,
                    Year = item.Year,
                    Area = item.CatalogueReference.Area,
                    Description = item.Description ?? string.Empty ,
                    Conditions = item.Conditions,
                    CatalogueNumber = $"{ new CatalogueAbbreviations()[item.CatalogueReference.Catalogue] } {item.CatalogueReference.Number}",
                    NextAuction = DateTime.MinValue,
                    NextAuctionHouse = "the item is not offered by any auction house at the moment"
                }
            );
            
            return new ShowWishlistViewModel { Items = conversion};
        }

        internal static ManageWishlistViewModel ToManageWishlistViewModel(Wishlist wishlist)
        {
            var conversion = wishlist.Select(item => 
                new ManagePhilatelicItemViewModel
                {
                    Year = item.Year,
                    Area = item.CatalogueReference.Area,
                    Catalogue = item.CatalogueReference.Catalogue,
                    CatalogueNumber = item.CatalogueReference.Number,
                    Description = item.Description,
                    Conditions = item.Conditions
                }
            );

            return new ManageWishlistViewModel { Items = conversion };
        }
    }
}