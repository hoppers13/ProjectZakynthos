using ProjectZakynthos.Domain;
using ProjectZakynthos.Domain.Philately;
using System.Collections.Generic;
using System.Linq;

namespace ProjectZakynthos.Persistence.InMemory
{
    public class WishlistRepository : IWishlistRepository
    {
        private static IPhilatelicItemRepository itemsRepository;

        public WishlistRepository(IPhilatelicItemRepository itemsRepo)
		{
			itemsRepository = itemsRepo;
		}

		public Wishlist GetWishlist(UserIdentity userId)
        {
            if (InMemoryDataStore.Wishlists.ContainsKey(userId))
            {
                var allItems = itemsRepository.GetAll();
                var ids = InMemoryDataStore.Wishlists[userId];

                var items = allItems.Where(item => ids.Any(id => id ==  item.Id));

                return new Wishlist(items);
            }
            
            return null;
        }

        public void SaveWishlist(UserIdentity userId, Wishlist wishlist)
        {
            //assumption: the manage wishlist page will only allow to use a catalogue at a time (default: Stanley Gibbons)

            // verify which item is already known
            var knownItems = RetrieveKnownItems(wishlist.GetCatalogueReferences(CataloguesInUse.STANLEY_GIBBONS));

            //save items not yet knownn 
            var unknownItems = wishlist.Where(wish =>  !knownItems.Any(itm => wish.IsSameItem(itm.CatalogueReference)));
            itemsRepository.Save(unknownItems);

            var inMemoryWishlist = knownItems.Select(item => item.Id);
            inMemoryWishlist = inMemoryWishlist.Union(unknownItems.Select(item => item.Id));

            // update wishlist
            if (InMemoryDataStore.Wishlists.ContainsKey(userId)){
                InMemoryDataStore.Wishlists[userId] = inMemoryWishlist;
                return;
            }        
            
            // add new wishlist
            InMemoryDataStore.Wishlists.Add(userId, inMemoryWishlist);
        }

        private IEnumerable<PhilatelicItem> RetrieveKnownItems(IEnumerable<CatalogueReference> references)
        {
            return itemsRepository.GetItems(references);            
        }
    }
}