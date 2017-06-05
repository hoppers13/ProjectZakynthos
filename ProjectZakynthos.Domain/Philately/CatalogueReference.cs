using System;

namespace ProjectZakynthos.Domain.Philately
{
    public class CatalogueReference
    {
        public Guid Id { get; set; }
        public Catalogue Catalogue { get; set; }
        public string Area { get; set; }
        public string Number { get; set; }        
    }
}
