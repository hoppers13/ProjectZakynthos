using ProjectZakynthos.Domain;
using ProjectZakynthos.Domain.Philately;
using System;
using System.Collections.Generic;

namespace ProjectZakynthos.Persistence.InMemory
{
    public static class InMemoryDataStore
    {
        private static Dictionary<Guid, PhilatelicItem> philatelicItems;
        private static Dictionary<UserIdentity, IEnumerable<Guid>> wishlists;

        static InMemoryDataStore()
        {
            philatelicItems = new Dictionary<Guid, PhilatelicItem>();
            wishlists = new Dictionary<UserIdentity, IEnumerable<Guid>>();
        }

        public static Dictionary<Guid, PhilatelicItem> PhilatelicItems
        {
            get
            {
                return philatelicItems;
            }
        }

        public static Dictionary<UserIdentity, IEnumerable<Guid>> Wishlists
        {
            get
            {
                return wishlists;
            }
        }
    }
}