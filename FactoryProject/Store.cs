using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Store : IWorkplace
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Employee> Employees { get; set; }
        public Organisation StoreOwner { get; set; }
        public List<ChocolateOrder> Transactions { get; set; }
        public ChocolateWarehouse ChocoWarehouse { get; set; }
        public Store(string name, Organisation owner)
        {
            Name = name;
            StoreOwner = owner;
            Employees = new List<Employee>();
            ChocoWarehouse = new ChocolateWarehouse(this);
        }

        public void SellChocolateOrder( Customer customer)
        {

            //Creates a new ChocolateOrder , removing objects from the ChocolatesStock depending ChocolateOrderRelated.DateProduced

        }
    }
}
