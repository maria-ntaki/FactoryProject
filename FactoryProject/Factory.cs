using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Factory : IWorkplace
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double rawMaterial;

        public double RawMaterial
        {
            get { return rawMaterial; }
            set { rawMaterial = value; }
        }
        public List<Employee> Employees { get; set; }
        public Organisation OrganisationRelated { get; set; }
        public ChocolateWarehouse ChocoWarehouse { get; set; }
        public Contract ActiveContract { get; set; }
        public List<Contract> RegisteredContracts { get; set; }
        public double RawMaterialStock { get; set; }

        public Factory(string name, double rawmaterial, Organisation organisationRelated)
        {
            Name = name;
            RawMaterial = rawmaterial;
            OrganisationRelated = organisationRelated;
            Employees = new List<Employee>();
            ChocoWarehouse = new ChocolateWarehouse(this);
        }

        public void ShipChocolateOrder(Store storeRelated)
        {
            rawMaterial--;
        }
    }
}
