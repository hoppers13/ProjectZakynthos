using System.Collections.Generic;

namespace ProjectZakynthos.Web.Areas.stamps.Models
{
    public class ShowWishlistViewModel
    {
        public IEnumerable<ShowWishlistItemViewModel> Items { get; set; }
    }
}