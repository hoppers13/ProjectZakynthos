using ProjectZakynthos.Domain;
using ProjectZakynthos.Domain.Philately;
using System;
using System.Collections.Generic;

namespace ProjectZakynthos.Persistence.InMemory
{
    public class WishlistRepository : IWishlistRepository
    {
        private static Dictionary<UserIdentity, Wishlist> store;
        
        public Wishlist GetWishlist(UserIdentity userId)
        {
            if (store.ContainsKey(userId))
            {
                return store[userId];
            }

            return null;
        }

        public void SaveWishlist(UserIdentity userId, Wishlist wishlist)
        {
            throw new NotImplementedException();
        }
    }
}
