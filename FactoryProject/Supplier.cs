using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Supplier
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public List<RawMaterialOffer> Offers { get; set; }
        public Supplier(string name)
        {
            Name = name;
            Offers = new List<RawMaterialOffer>();
        }

        public RawMaterialOffer CreateOffer()
        {
            return new RawMaterialOffer(0, 0, 0, this);
        }
    }
}
