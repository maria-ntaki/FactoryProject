using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Contract
    {
        public RawMaterialOffer RelatedOffer { get; set; }
        public Organisation OrganisationRelated { get; set; }
        public Supplier SupplierRelated { get; set; }
        public Factory FactoryRelated { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate
        {
            get { return StartDate.AddYears(1); }
        }
        public bool IsActive
        {
            get
            {
                if (DateTime.Now > EndDate)
                    return false;
                else
                    return true;
            }
        }

        public Contract(RawMaterialOffer offer, Organisation organisation, Supplier supplier, Factory factoryRelated, DateTime startdate)
        {
            RelatedOffer = offer;
            OrganisationRelated = organisation;
            SupplierRelated = offer.SupplierRelated;
            FactoryRelated = factoryRelated;
            StartDate = startdate;
        }
    }
}
