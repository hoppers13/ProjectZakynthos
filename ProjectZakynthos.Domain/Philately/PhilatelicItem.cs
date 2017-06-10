using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjectZakynthos.Domain.Philately
{
    public class PhilatelicItem
    {
        public Guid Id { get; set; }
        public int Year { get; set; }
        public PhilatelicItemType Type { get; set; }
        public string Description { get; set; }
        public Conditions Conditions { get; set; }
        public CatalogueReference CatalogueReference { get; set; }
        public IEnumerable<AuctionedPhilatelicItem> UpcomingAuctions { get; set; }
        public IEnumerable<AuctionedPhilatelicItem> PastAuctions { get; set; }

        //TODO: unit tests
        public bool IsSameItem(CatalogueReference reference)
        {
            return
                CatalogueReference.Catalogue == reference.Catalogue
                && CatalogueReference.Area == reference.Area
                && CatalogueReference.Number == reference.Number;            
        }
        
        public AuctionedPhilatelicItem NextAuction
        {
            get
            {
                if (UpcomingAuctions == null) return null;

                var nextDate = UpcomingAuctions.Min(auction => auction.AuctionDate);
                return UpcomingAuctions.FirstOrDefault(auction => auction.AuctionDate == nextDate);
            }
        } 
    }
}
