using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Factory
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
        //public List<Chocolate> ChocolatesStock?

        public Factory(string name, double rawmaterial, Organisation organisationRelated)
        {
            Name = name;
            RawMaterial = rawmaterial;
            OrganisationRelated = organisationRelated;
            Employees = new List<Employee>();
        }

        public void  ChocolateCreation(int numberToProduce, string nameOfChoco)
        {
            var chocoWarehouse = new ChocoWareHouse() { };
            float costOfRaw = 0.5;

            var choco = new Chocolate() { Kind = (nameOfChoco) , Amount = numberToProduce };
            choco.ProductionDate = DateTime.Now;
            var x = RawMaterial - numberToProduce * costOfRaw;
            rawMaterial = x;
            choco.Value = 

            chocoWarehouse.ChocolateStored.Add(choco);

        }

    }
}
