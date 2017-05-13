using System;

namespace ProjectZakynthos.Persistence
{
    public interface IItemRepository
    {
        Guid Create(string description);   
    }
}