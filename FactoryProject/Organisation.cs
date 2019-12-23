using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Organisation 
    {
        public List<Factory> Factories { get; set; }
        public List<Store> Stores { get; set; }
        public List<Contract> ContractsConducted { get; set; }

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        //private double moneyBalance;
        //public double MoneyBalance
        //{
        //    get { return moneyBalance; }
        //    set { moneyBalance = value; }
        //}
        public Organisation(string name)
        {
            Name = name;
        }

        public void EvaluateOffers(List<RawMaterialOffer> offers)
        {

        }
    }
}
