using System.Collections.Generic;

namespace ProjectZakynthos.Persistence
{
	public interface IWishlistRepository
	{
		IEnumerable<string> GetWishlist();
	}
}
