using System.Collections.Generic;

namespace ProjectZakynthos.Web.Areas.stamps.Models
{
	public class WishlistViewModel
	{
		public IEnumerable<PhilatelicItem> Items { get; set; }
	}

	public class PhilatelicItem
	{
		public string Country { get; set; }
		public int Year { get; set; }
		public string FaceValue { get; set; }
		public string Description { get; set; }
	}
}