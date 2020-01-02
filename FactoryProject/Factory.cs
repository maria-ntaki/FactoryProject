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
         
        public List<Employee> Employees { get; set; }
        public Organisation OrganisationRelated { get; set; }
        public Contract ActiveContract { get; set; } //Contract to reference or resupply
        public List<Chocolate> ChocolatesStock { get; set; }
        public List<Contract> RegisteredContracts { get; set; } //Contracts record
        public List<ChocolateOrder> OrdersConducted { get; set; }
        public Factory(string name, double rawmaterial, Organisation organisationRelated)
        {
            Name = name;
            RawMaterial = rawmaterial;
            OrganisationRelated = organisationRelated;
            Employees = new List<Employee>();
            OrdersConducted = new List<ChocolateOrder>();
            RegisteredContracts = new List<Contract>();
            ChocolatesStock = new List<Chocolate>();
            //ActiveContract = organisationRelated.ProduceContract(this);
        }
        private double rawMaterial;
        public double RawMaterial
        {
            get
            {
                return rawMaterial;
            }
            set
            {
                if (value > 10000) //in units..
                {
                    throw new Exception("Value exceeded stock capacity");
                }
                else if (value < 0)
                {
                    throw new Exception("Value cannot be lower than zero");
                }
                else if (value < 1000) //1000 represent 10% of 10000 -> thats when resupplying is made, incresing amount and expenses as well
                {
                    Resupply();
                }
                else
                {
                    rawMaterial = value;
                }
            }
        }

        private double expenses;
        public double Expenses
        { 
            get
            {
                return expenses;
            }
            set
            {
                expenses = value;
            }
        }



        /// <summary>
        /// Takes as parameteres the Store that is placing the order and the information about the chocolates to "extraxt" from the warehouse
        /// Returns a chocolate order containing a list of chocolates representing actual objects from the warehouse fot he factory
        /// </summary>
        /// <returns></returns>
        public ChocolateOrder ShipChocolateOrder(Store storeRelated, ChocolateOrder order)
        {
            //variables to keep track of number of items to remove from warehouse
            int darkChocos = 0;
            int whiteChocos = 0;
            int milkChocos = 0;
            int peanutChocos = 0;
            int almondChocos = 0;

            //Modifying valye of variables depending on data 
            foreach (var chocolate in order.Chocolates)
            {
                if (chocolate.ChocolateKind == Kind.White)
                    whiteChocos += 1;
                else if (chocolate.ChocolateKind == Kind.Peanut)
                    peanutChocos += 1;
                else if (chocolate.ChocolateKind == Kind.Milk)
                    milkChocos += 1;
                else if (chocolate.ChocolateKind == Kind.Dark)
                    darkChocos += 1;
                else //(ChocolateKind == Kind.Almond)
                    almondChocos += 1;
            }

            
            List<Chocolate> chocolatesList = new List<Chocolate>();//Creating the list that we will use to create the returning chocolate order

            //Querying the values from warehouse to create lists
            List<Chocolate> darkCholatesFromWarehouse = ChocolateExtractionFromStock(darkChocos, Kind.Dark);
            List<Chocolate> whiteCholatesFromWarehouse = ChocolateExtractionFromStock(whiteChocos, Kind.White);
            List<Chocolate> milkCholatesFromWarehouse = ChocolateExtractionFromStock(milkChocos, Kind.Milk);
            List<Chocolate> peanutCholatesFromWarehouse = ChocolateExtractionFromStock(peanutChocos, Kind.Peanut);
            List<Chocolate> almondCholatesFromWarehouse = ChocolateExtractionFromStock(almondChocos, Kind.Almond);

            chocolatesList = AddRemoveChocolates(darkCholatesFromWarehouse, chocolatesList);
            chocolatesList = AddRemoveChocolates(whiteCholatesFromWarehouse, chocolatesList);
            chocolatesList = AddRemoveChocolates(milkCholatesFromWarehouse, chocolatesList);
            chocolatesList = AddRemoveChocolates(peanutCholatesFromWarehouse, chocolatesList);
            chocolatesList = AddRemoveChocolates(almondCholatesFromWarehouse, chocolatesList);



            ChocolateOrder newOrder = new ChocolateOrder(chocolatesList, this, storeRelated);
            OrdersConducted.Add(newOrder);
            return newOrder; 


        }

        private List<Chocolate> ChocolateExtractionFromStock(int chocolateAmount, Kind chocoKind)
        {
            List<Chocolate> extractedChocolates = (from c in ChocolatesStock
                                                   where c.ChocolateKind == chocoKind
                                                   orderby c.DateProduced ascending
                                                   select c).Take(chocolateAmount).ToList();
            return extractedChocolates;
        }

        private List<Chocolate> AddRemoveChocolates(List<Chocolate> warehouseChocolateQuery, List<Chocolate> chocolatesToShip)
        {
            foreach (var item in warehouseChocolateQuery)
            {
                chocolatesToShip.Add(item);
                ChocolatesStock.Remove(item);
            }
            return chocolatesToShip;
        }

        public void UpdateContract(Contract newContract)
        {
            ActiveContract = newContract;
            RegisteredContracts.Add(newContract);
        }

        public void ProduceChocolate(int dark, int white, int milk, int almond, int peanut)
        {
            for (int i = 0; i < dark; i++)
            {
                Chocolate darkCholate = new Chocolate(Kind.Dark, DateTime.Now);
                RawMaterial -= 0.15;
                ChocolatesStock.Add(darkCholate);
            }

            for (int i = 0; i < white; i++)
            {
                Chocolate whiteChocolate = new Chocolate(Kind.White, DateTime.Now);
                RawMaterial -= 0.2;
                ChocolatesStock.Add(whiteChocolate);
            }

            for (int i = 0; i < milk; i++)
            {
                Chocolate milkChocolate = new Chocolate(Kind.Milk, DateTime.Now);
                RawMaterial -= 0.25;
                ChocolatesStock.Add(milkChocolate);
            }

            for (int i = 0; i < almond; i++)
            {
                Chocolate almondChocolate = new Chocolate(Kind.Almond, DateTime.Now);
                RawMaterial -= 0.22;
                ChocolatesStock.Add(almondChocolate);
            }

            for (int i = 0; i < peanut; i++)
            {
                Chocolate peanutChocolate = new Chocolate(Kind.Peanut, DateTime.Now);
                RawMaterial -= 0.26;
                ChocolatesStock.Add(peanutChocolate);
            }
        }

        public void Resupply()
        {
            rawMaterial += ActiveContract.RelatedOffer.RawMaterialAmount;//Contract holds the "transaction" data to be transfered
            Expenses += ActiveContract.RelatedOffer.PricePerKilo;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb
                .AppendLine($"Factory name: {Name}")
                .AppendLine($"Employees Count: {Employees.Count}")
                .AppendLine($"Owner: {OrganisationRelated.Name}")
                .AppendLine($"Contract end date: {ActiveContract.EndDate}")
                .AppendLine($"Contract supplier: {ActiveContract.SupplierRelated.FirstName + " " + ActiveContract.SupplierRelated.LastName}")
                .AppendLine($"Chocolates in stock: {ChocolatesStock.Count}")
                .AppendLine($"Contracts conducted: {RegisteredContracts.Count}");

            return sb.ToString();
        }

    }
}
