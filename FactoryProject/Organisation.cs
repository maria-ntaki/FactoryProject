using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Organisation : IWorkplaces
    {
        public List<Factory> Factories { get; set; }
        public List<Store> Stores { get; set; }
        public List<Contract> ActiveContract { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        private double moneyBalance;
        public double MoneyBalance
        {
            get { return moneyBalance; }
            set { moneyBalance = value; }
        }
        public Organisation(string name, double moneybalance)
        {
            Name = name;
            MoneyBalance = moneybalance;
        }
        public void NewChocolateOrder(Store storeRelated)
        {
            // storeRelate.chocolates.Add();

            MoneyBalance--;
        }
        public void NewRawMaterialOrder(Factory factoryRelated)
        {
            //reference of supplier should be saved in activecontract if needed
            // factoryRelated.RawMaterial +=

        }
        public void EvaluateOffers(List<RawMaterialOffer> offers)
        {

        }
    }
}
