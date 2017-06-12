using ProjectZakynthos.Domain.Philately;
using System;
using System.Collections.Generic;

namespace ProjectZakynthos.Persistence.InMemory.SampleData
{
    public static class SamplePhilatelicItems
	{
		public static IEnumerable<PhilatelicItem> Items;
		
		static SamplePhilatelicItems()
		{
			Items = new List<PhilatelicItem> {
				new PhilatelicItem
				{
					Id = new Guid("1c362074-96b0-40ab-8988-c06c0c1f5efc"),
					Year = 1919,
					Type = PhilatelicItemType.Stamp,
					Description = "(6 Mar.) Wmk Mult Crown CA P.14, 10s. black",
					Conditions = Conditions.MH,
					CatalogueReference = 
                        new CatalogueReference{
							Catalogue = CataloguesInUse.STANLEY_GIBBONS,
							Area = "Malta",
							Number = "96"
						},
                    Auctions = new List<AuctionedPhilatelicItem>
                    {
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(14),
                            StartingBid = 2300,
                            AuctionHouse = "Cherrystone Auctions, Inc.",
                            LotDescription = "1919 10sh black, well centered, h.r., v.f., signed Brun (SG 96) (Catalog value £3,250)",
                            LotScan = "/Content/Images/MaltaSG96.jpg"
                        },
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(24),
                            StartingBid = 2000,
                            AuctionHouse = "Robert A. Siegel",
                            LotDescription = "MALTA, 1919, 10sh Black (65; SG 96). Deep shade, well-centered. VERY FINE. A HANDSOME EXAMPLE OF THE KEY STAMP OF MALTA. £3,250",
                            LotScan = "/Content/Images/MaltaSG96.Siegel.jpg"
                        },
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(7),
                            StartingBid = 750,
                            AuctionHouse = "Kelleher Auctions",
                            LotDescription = "Malta, 1919, St. Paul, 10s black (Scott 65), Multiple Crown CA watermark, o.g., lightly hinged, exceptionally fresh and clean, Fine to Very Fine, signed F.B. Turpin, London. SG 96; L3,250 ($5,040). Scott $3,500. Estimate $1,500 - 2,000 AN OUTSTANDING EXAMPLE OF THE RARE 10S ST. PAUL WITH MULTIPLE CA WATERMARK",
                            LotScan = "/Content/Images/MaltaSG96.Kelleher.jpg"
                        },
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(-14),
                            StartingBid = 3450,
                            AuctionHouse = "Brandon stamps",
                            Sold = false
                        },
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(-124),
                            StartingBid = 2430,
                            AuctionHouse = "Stanley Gibbons",
                            Sold = true,
                            Realisation = 2875
                        },
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(-77),
                            StartingBid = 3200,
                            AuctionHouse = "Samwells",
                            Sold = true,
                            Realisation = 3390
                        },
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(-274),
                            StartingBid = 2430,
                            AuctionHouse = "Stanley Gibbons",
                            Sold = true,
                            Realisation = 2550
                        },
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(-377),
                            StartingBid = 3200,
                            AuctionHouse = "Apex",
                            Sold = true,
                            Realisation = 3415
                        }
                    }
				},
				new PhilatelicItem
				{
					Id = new Guid("7d22998b-c393-46e5-bda3-ef828e890b0b"),
					Year = 1886,
					Type = PhilatelicItemType.Stamp,
					Description = "Victoria 5Sh red, wmk CC inverted",
					Conditions = Conditions.NoGum,
					CatalogueReference = 
						new CatalogueReference{
							Catalogue = CataloguesInUse.STANLEY_GIBBONS,
							Area = "Malta",
							Number = "30w"
						},
                    Auctions = new List<AuctionedPhilatelicItem>
                    {
                        new AuctionedPhilatelicItem
                        {
                            Id = Guid.NewGuid(),
                            AuctionDate = DateTime.Now.AddDays(21),
                            StartingBid = 112,
                            AuctionHouse = "Burda Auction s.r.o.",
                            LotDescription = "1886 SG.30w, Victoria 5Sh red, wmk CC INVERTED; cat. £160",
                            LotScan = "/Content/Images/MaltaSG30w.jpg"
                        }
                    }
                },
				new PhilatelicItem
				{
					Id = new Guid("5f9e829c-1cae-44f7-9fcc-bb8cd43c2449"),
					Year = 1902,
					Type = PhilatelicItemType.Stamp,
					Description = "£1 dull blue-green (16.6.02)",
					Conditions = Conditions.MNH,
					CatalogueReference = 
                        new CatalogueReference{
							Catalogue = CataloguesInUse.STANLEY_GIBBONS,
							Area = "GB",
							Number = "266"
						}					
				}
			};
		}
	}
}
