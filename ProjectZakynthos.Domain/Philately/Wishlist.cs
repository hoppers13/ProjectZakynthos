using System.Collections.Generic;

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
    }
}
