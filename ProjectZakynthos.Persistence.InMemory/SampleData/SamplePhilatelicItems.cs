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
					Year = 1899,
					Type = PhilatelicItemType.Stamp,
					Description = "2d. deep violet (15.12.99)",
					Conditions = Conditions.MNH,
					CatalogueReference = 
                        new CatalogueReference{
							Catalogue = CataloguesInUse.STANLEY_GIBBONS,
							Area = "Australia",
							Number = "231"
						},
                    Auctions = new List<AuctionedPhilatelicItem>
                    {
                        new AuctionedPhilatelicItem
                        {
                            AuctionDate = DateTime.Now.AddDays(14),
                            StartingBid = 350,
                            AuctionHouse = "Spink London"                            
                        },
                        new AuctionedPhilatelicItem
                        {
                            AuctionDate = DateTime.Now.AddDays(24),
                            StartingBid = 430,
                            AuctionHouse = "Stanley Gibbons"
                        },
                        new AuctionedPhilatelicItem
                        {
                            AuctionDate = DateTime.Now.AddDays(7),
                            StartingBid = 330,
                            AuctionHouse = "Mark Bloxham"
                        }
                    }
				},
				new PhilatelicItem
				{
					Id = new Guid("7d22998b-c393-46e5-bda3-ef828e890b0b"),
					Year = 1883,
					Type = PhilatelicItemType.Stamp,
					Description = "1/2 d. vermillion Doubly printed",
					Conditions = Conditions.NoGum,
					CatalogueReference = 
						new CatalogueReference{
							Catalogue = CataloguesInUse.STANLEY_GIBBONS,
							Area = "GB",
							Number = "197c"
						},
                    Auctions = new List<AuctionedPhilatelicItem>
                    {
                        new AuctionedPhilatelicItem
                        {
                            AuctionDate = DateTime.Now.AddDays(21),
                            StartingBid = 1350,
                            AuctionHouse = "Apex Auctions"
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
