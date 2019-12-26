using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Store : IWorkplaces
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Employee> Employees { get; set; }
        public Organisation Owner { get; set; }
        public List<ChocolateOrder> ChocolatesStock { get; set; }
        public Store(string name, Organisation owner)
        {
            Name = name;
            Owner = owner;
            Employees = new List<Employee>();
            ChocolatesStock = new List<ChocolateOrder>();
        }

        public void SellChocolateOrder()
        {
            Console.WriteLine("What kind do you want to buy?");
            Console.WriteLine("Do you want to add another kind in the cart??");
            //Creates a new ChocolateOrder , removing objects from the ChocolatesStock depending ChocolateOrderRelated.DateProduced


            Owner.MoneyBalance += 10000;
        }
    }
}
