using System.Collections.Generic;
using ProjectZakynthos.Domain.Philately;
using System.Linq;

namespace ProjectZakynthos.Persistence.InMemory
{
    public class PhilatelicItemRepository : IPhilatelicItemRepository
	{
        public IEnumerable<PhilatelicItem> GetAll()
		{
            //TODO: add sample datas once, then only use in memory repository 
            //return SampleData.SamplePhilatelicItems.Items;

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