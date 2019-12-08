using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Contract
    {
        public Offer ChosenOffer { get; set; }
        public Organisation OrganisationRelated { get; set; }
        public Supplier SupplierRelated { get; set; }

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
        public Contract(Offer offer, Organisation organisation, Supplier supplier, DateTime startdate, DateTime enddate)
        {
            ChosenOffer = offer;
            OrganisationRelated = organisation;
            SupplierRelated = supplier;
            StartDate = startdate;
            EndDate = enddate;
        }
    }
}
