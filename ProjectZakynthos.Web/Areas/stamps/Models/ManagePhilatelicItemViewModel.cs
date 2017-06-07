using ProjectZakynthos.Domain.Philately;

namespace ProjectZakynthos.Web.Areas.stamps.Models
{
    public class ManagePhilatelicItemViewModel
    {
        //public Guid Id { get; set; }
        public CataloguesInUse Catalogue { get; set; }
        public string CatalogueNumber { get; set; }
        public string Area { get; set; }
        public int Year { get; set; }
        public string Description { get; set; }
        public Conditions Conditions { get; set; }
    }
}