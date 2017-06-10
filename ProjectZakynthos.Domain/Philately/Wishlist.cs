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
        
        //TODO: unit test
        public IEnumerable<CatalogueReference> GetCatalogueReferences(CataloguesInUse catalogue)
        {
            return this.Select(wish => wish.CatalogueReference).Where(reference => reference.Catalogue == catalogue);
        }

        //TODO: unit test
        // get rid of any element in the collection without a valid catalogue reference
        public Wishlist Purge()
		{
			var clean = this.Where(wish => !string.IsNullOrWhiteSpace(wish.CatalogueReference.Number));
			return new Wishlist(clean);			
		}
    }
}
