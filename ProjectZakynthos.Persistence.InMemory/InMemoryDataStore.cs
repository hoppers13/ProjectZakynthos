using ProjectZakynthos.Domain;
using ProjectZakynthos.Domain.Philately;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectZakynthos.Persistence.InMemory
{
    public static class InMemoryDataStore
    {
        private static Dictionary<Guid, PhilatelicItem> philatelicItems;
        private static Dictionary<UserIdentity, IEnumerable<Guid>> wishlists;

        static InMemoryDataStore()
        {
            philatelicItems = new Dictionary<Guid, PhilatelicItem>();
            foreach(var item in SampleData.SamplePhilatelicItems.Items)
            {
                philatelicItems.Add(item.Id, item);
            }

            wishlists = new Dictionary<UserIdentity, IEnumerable<Guid>>();
            var defaultUser = "gianluca@email.com";
            wishlists.Add(new UserIdentity { Name = defaultUser }, SampleData.SamplePhilatelicItems.Items.Select(item => item.Id));
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