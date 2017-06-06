using ProjectZakynthos.Domain.Philately;
using ProjectZakynthos.Web.Areas.stamps.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectZakynthos.Web.Mappers
{
	public class Convert
	{
		public static Wishlist ToWishlist(WishlistViewModel model)
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
	}
}