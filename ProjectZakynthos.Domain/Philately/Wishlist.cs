using System.Collections.Generic;
using System.Linq;

namespace ProjectZakynthos.Domain.Philately
{
	public class Wishlist : List<PhilatelicItem>
    {
		public Wishlist() { }

		public Wishlist(IEnumerable<PhilatelicItem> wishes)
		{
			foreach(var wish in wishes)
			{
				this.Add(wish);
			}
		}

		public Wishlist Relevant()
		{
			var clean = this.Where(wish => wish.CatalogueReferences.Any(catRef => !string.IsNullOrWhiteSpace(catRef.Number)));
			return new Wishlist(clean);			
		}
    }
}
