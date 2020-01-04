using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Store : IWorkplace, IChocoBuyers
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
        public double Income { get; set; }
        public List<Customer> Customers { get; set; }
        public Store(string name, Organisation owner)
        {
            Name = name;
            StoreOwner = owner;
            Employees = new List<Employee>();
            Chocolates = new List<Chocolate>();
            Transactions = new List<ChocolateOrder>();
            Customers = new List<Customer>();
        }

        public void ResupplyChocolate(Factory factoryRelated)
        {
            List<Chocolate> chocolatesListRequest = Chocolate.CreateChocolatesRequest();

            ChocolateOrder newChocolatesRequest = new ChocolateOrder(chocolatesListRequest, factoryRelated, this); //Chocolates list is used to produce an order tracking the relation between store and customer and assigning price data
            ChocolateOrder chocolatesDelivery = factoryRelated.ShipChocolateOrder(this, newChocolatesRequest); //Invoking factory method passing the current store to return a valid representation of chocolate data, extracted from the factory's chocolate stock
            
            foreach (var item in chocolatesDelivery.Chocolates) //Populating store chocolate stock catalog
            {
                Chocolates.Add(item);
            }

            Console.WriteLine("Resupply was successful");
        }
        public void SellChocolateOrder(List<Chocolate> chocolatesSelected, Customer customer)
        {
            //list imported should be used to pass amount value of each kind to variables
            //Then create 5 lists querying items from the store's chcolate stock depending on date (to get rid of old ones first)
            //Loop every list you produced and populate a new list with each item, while also removing it from the stock
            //Use the produced list to create an order which you store on the Transactions list of the store, to keep track of the income aswell

            int darkChocos = 0;
            int whiteChocos = 0;
            int milkChocos = 0;
            int peanutChocos = 0;
            int almondChocos = 0;

            foreach (var chocolate in chocolatesSelected)
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

            var almondChocolates = (from c in Chocolates
                                    where c.ChocolateKind == Kind.Almond
                                    orderby c.DateProduced ascending
                                    select c).Take(almondChocos);

            var whiteChocolates = (from c in Chocolates
                                   where c.ChocolateKind == Kind.White
                                   orderby c.DateProduced ascending
                                   select c).Take(whiteChocos);

            var darkChocolates = (from c in Chocolates
                                  where c.ChocolateKind == Kind.Dark
                                  orderby c.DateProduced ascending
                                  select c).Take(darkChocos);

            var peanutChocolates = (from c in Chocolates
                                    where c.ChocolateKind == Kind.Peanut
                                    orderby c.DateProduced ascending
                                    select c).Take(peanutChocos);

            var milkChocolates = (from c in Chocolates
                                  where c.ChocolateKind == Kind.Milk
                                  orderby c.DateProduced ascending
                                  select c).Take(milkChocos);

            List<Chocolate> chocolatesList = new List<Chocolate>();

            foreach (var item in almondChocolates)
            {
                chocolatesList.Add(item); //Adding selected values to our list
                Chocolates.Remove(item);//Removing them from warehouse
            }

            foreach (var item in whiteChocolates)
            {
                chocolatesList.Add(item);
                Chocolates.Remove(item);
            }

            foreach (var item in darkChocolates)
            {
                chocolatesList.Add(item);
                Chocolates.Remove(item);
            }

            foreach (var item in peanutChocolates)
            {
                chocolatesList.Add(item);
                Chocolates.Remove(item);
            }

            foreach (var item in milkChocolates)
            {
                chocolatesList.Add(item);
                Chocolates.Remove(item);
            }

            ChocolateOrder newOrder = new ChocolateOrder(chocolatesList, this, customer);
            customer.ChocoOrders.Add(newOrder);
            this.Transactions.Add(newOrder);

            bool customerExists = false;
            foreach (var existingCustomer in Customers)
            {
                if (existingCustomer.Equals(customer))
                    customerExists = true;
            }

            if (!customerExists)
                Customers.Add(customer);

            Income += newOrder.TotalPrice;

        }
    }
}
