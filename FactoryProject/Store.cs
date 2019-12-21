using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Store : IWorkplace, ChocoBuyers
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Employee> Employees { get; set; }
        public Organisation StoreOwner { get; set; }
        public List<ChocolateOrder> Transactions { get; set; } //Should keep track of chocolate orders with customers
        public List<Chocolate> Chocolates { get; set; }
        public Store(string name, Organisation owner)
        {
            Name = name;
            StoreOwner = owner;
            Employees = new List<Employee>();
            Chocolates = new List<Chocolate>();
        }

        public void ResupplyChocolate(List<Chocolate> chocolates, Factory factoryRelated)//Chocolates list contains information collected from user input about amount and kind of chocolate
        {
            ChocolateOrder newChocolatesRequest = new ChocolateOrder(chocolates, factoryRelated, this); //Chocolates list is used to produce an order tracking the relation between store and customer and assigning price data
            ChocolateOrder chocolatesDelivery = factoryRelated.ShipChocolateOrder(this, newChocolatesRequest); //Invoking factory method passing the current store to return a valid representation of chocolate data, extracted from the factory's chocolate stock
            
            foreach (var item in chocolatesDelivery.Chocolates) //Populating store chocolate stock catalog
            {
                chocolates.Add(item);
            }


        }
        public void SellChocolateOrder(List<Chocolate> chocolatesSelected, Customer customer)
        {
            //list imported should be used to pass amount value of each kind to variables
            //Then create 5 lists querying items from the store's chcolate stock depending on date (to get rid of old ones first)
            //Loop every list you produced and populate a new list with each item, while also removing it from the stock
            //Use the produced list to create an order which you store on the Transactions list of the store, to keep track of the income aswell
           

        }
    }
}
