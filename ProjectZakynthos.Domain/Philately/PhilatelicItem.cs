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
        public IEnumerable<AuctionedPhilatelicItem> Auctions { get; set; }

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
                if (!UpcomingAuctions.Any()) return null;

                var nextDate = UpcomingAuctions.Min(auction => auction.AuctionDate);
                return UpcomingAuctions.FirstOrDefault(auction => auction.AuctionDate == nextDate);
            }
        }
        
        public IEnumerable<AuctionedPhilatelicItem> UpcomingAuctions {
            get
            {
                if (Auctions == null) return new List<AuctionedPhilatelicItem>();

                return Auctions.Where(auction => auction.AuctionDate > DateTime.Now.Date)
                    .OrderBy(auction => auction.AuctionDate);
            }
        }

        public IEnumerable<AuctionedPhilatelicItem> PastAuctions
        {
            get
            {
                if (Auctions == null) return new List<AuctionedPhilatelicItem>();

                return Auctions.Where(auction => auction.AuctionDate < DateTime.Now.Date)
                    .OrderByDescending(auction => auction.AuctionDate);
            }
        }
    }
}