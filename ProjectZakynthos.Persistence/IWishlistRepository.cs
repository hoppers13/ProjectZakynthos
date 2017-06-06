using ProjectZakynthos.Domain;
using ProjectZakynthos.Domain.Philately;

namespace ProjectZakynthos.Persistence
{
    public interface IWishlistRepository
	{
        void SaveWishlist(UserIdentity userId, Wishlist wishlist);

        Wishlist GetWishlist(UserIdentity userId);
	}
}
