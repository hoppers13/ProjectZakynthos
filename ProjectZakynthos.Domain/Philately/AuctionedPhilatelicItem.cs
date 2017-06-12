using System;

namespace ProjectZakynthos.Domain.Philately
{
    public class AuctionedPhilatelicItem
    {
        public Guid Id { get; set; }
        public PhilatelicItem Item { get; set; }
        public string AuctionHouse { get; set; }
        public DateTime AuctionDate { get; set; }
        public string LotDescription { get; set; }
        public string LotScan { get; set; }
        public decimal StartingBid { get; set; }
        public bool Sold { get; set; }
        public decimal Realisation { get; set; }
    }
}