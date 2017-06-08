using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectZakynthos.Domain.Philately;
using System.IO;
using System.Configuration;
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
    }
}
