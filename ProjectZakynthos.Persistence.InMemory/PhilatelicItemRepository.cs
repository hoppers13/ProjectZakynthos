using System.Collections.Generic;
using ProjectZakynthos.Domain.Philately;

namespace ProjectZakynthos.Persistence.InMemory
{
	public class PhilatelicItemRepository : IPhilatelicItemRepository
	{
		public IEnumerable<PhilatelicItem> GetAll()
		{
			return SampleData.SamplePhilatelicItems.Items;	
		}
	}
}