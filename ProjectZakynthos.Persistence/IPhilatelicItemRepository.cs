using ProjectZakynthos.Domain.Philately;
using System.Collections.Generic;

namespace ProjectZakynthos.Persistence
{
    public interface IPhilatelicItemRepository
    {
        IEnumerable<PhilatelicItem> GetAll();
        IEnumerable<PhilatelicItem> GetItems(IEnumerable<CatalogueReference> references);

        void Save(IEnumerable<PhilatelicItem> items);
    }
}
