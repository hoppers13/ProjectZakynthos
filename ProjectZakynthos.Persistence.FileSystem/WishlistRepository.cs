using System;
using ProjectZakynthos.Domain;
using ProjectZakynthos.Domain.Philately;

namespace ProjectZakynthos.Persistence.FileSystem
{
    public class WishlistRepository : IWishlistRepository
	{
		public Wishlist GetWishlist(UserIdentity userId)
        {
            throw new NotImplementedException();
        }

        public void SaveWishlist(UserIdentity userId, Wishlist wishlist)
        {
            throw new NotImplementedException();
        }
    }
}
