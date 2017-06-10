using System.Collections.Generic;
using ProjectZakynthos.Domain.Philately;
using System.Linq;
using System;

namespace ProjectZakynthos.Persistence.InMemory
{
    public class PhilatelicItemRepository : IPhilatelicItemRepository
	{
        public PhilatelicItem Get(Guid id)
        {
            if (InMemoryDataStore.PhilatelicItems.ContainsKey(id))
            {
                return InMemoryDataStore.PhilatelicItems[id];
            }

            return null;
        }

        public IEnumerable<PhilatelicItem> GetAll()
		{
            return InMemoryDataStore.PhilatelicItems.Values;
		}

        public IEnumerable<PhilatelicItem> GetItems(IEnumerable<CatalogueReference> references)
        {
            return GetAll().Where(item => references.Any(reference => item.IsSameItem(reference)));
        }

        public void Save(IEnumerable<PhilatelicItem> items)
        {
            foreach(var item in items)
            {
                InMemoryDataStore.PhilatelicItems.Add(item.Id, item);
            }
        }
    }
}