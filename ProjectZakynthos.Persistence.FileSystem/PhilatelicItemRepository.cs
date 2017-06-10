using System;
using System.Collections.Generic;
using ProjectZakynthos.Domain.Philately;
using System.IO;
using Newtonsoft.Json;

namespace ProjectZakynthos.Persistence.FileSystem
{
    public class PhilatelicItemRepository : IPhilatelicItemRepository
    {
		string dbLocation = @".\sampleData\philatelicItemDB.json";   ///ConfigurationManager.AppSettings["philatelicItemDB"];

        public IEnumerable<PhilatelicItem> GetAll()
        {
            using(var file = File.OpenText(dbLocation))
            {
                JsonSerializer serializer = new JsonSerializer();
                var items = serializer.Deserialize(file, typeof(PhilatelicItem));                
            }

            throw new NotImplementedException();
        }

        public IEnumerable<PhilatelicItem> GetItems(IEnumerable<CatalogueReference> references)
        {
            throw new NotImplementedException();
        }

        public void Save(IEnumerable<PhilatelicItem> items)
        {
            throw new NotImplementedException();
        }
    }
}
