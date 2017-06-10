using ProjectZakynthos.Domain.Philately;
using System;
using System.Collections.Generic;

namespace ProjectZakynthos.Persistence
{
    public interface IPhilatelicItemRepository
    {
        IEnumerable<PhilatelicItem> GetAll();
        PhilatelicItem Get(Guid id);
        IEnumerable<PhilatelicItem> GetItems(IEnumerable<CatalogueReference> references);

        void Save(IEnumerable<PhilatelicItem> items);
    }
}
