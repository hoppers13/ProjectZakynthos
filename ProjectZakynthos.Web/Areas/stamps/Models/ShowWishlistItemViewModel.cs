using ProjectZakynthos.Domain.Philately;
using System;

namespace ProjectZakynthos.Web.Areas.stamps.Models
{
    public class ShowWishlistItemViewModel
    {
        public Guid Id { get; set; }
        
        public int Year { get; set; }
        public string Area { get; set; }
        public string Description { get; set; }
        public Conditions Conditions { get; set; }
        public string CatalogueNumber { get; set; }

        public DateTime NextAuction { get; set;}
        public string NextAuctionHouse { get; set; }
    }
}