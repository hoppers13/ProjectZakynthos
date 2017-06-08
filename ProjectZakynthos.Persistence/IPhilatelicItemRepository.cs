using ProjectZakynthos.Domain.Philately;
using System.Collections.Generic;

namespace ProjectZakynthos.Persistence
{
    public interface IPhilatelicItemRepository
    {
        IEnumerable<PhilatelicItem> GetAll();
    }
}
