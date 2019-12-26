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

        private DateTime startDate;
        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }

        private DateTime endDate;

        public DateTime EndDate
        {
            get { return endDate; }
            set { endDate = value; }
        }
        public Contract(RawMaterialOffer offer, Organisation organisation, Supplier supplier, Factory factoryRelated, DateTime startdate, DateTime enddate)
        {
            RelatedOffer = offer;
            OrganisationRelated = organisation;
            SupplierRelated = supplier;
            StartDate = startdate;
            EndDate = enddate;
            FactoryRelated = factoryRelated;
        }
        public void ChocolateOrder()
        {

        }
    }
}
