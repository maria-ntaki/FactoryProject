using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        List<ChocolateOrder> ChocoOrders { get; set; }
        public double TotalExpenses
        {
            get
            {
                double returnValue = 0;
                foreach (var order in ChocoOrders)
                {
                    returnValue += order.TotalPrice;
                }
                return returnValue;
            }
        }
        public Customer(string fName, string lName)
        {
            FirstName = fName;
            LastName = lName;
            ChocoOrders = new List<ChocolateOrder>();
        }
        public Customer(string fName, string lName, ChocolateOrder order)
        {
            FirstName = fName;
            LastName = lName;
            ChocoOrders = new List<ChocolateOrder>();
            ChocoOrders.Add(order);
        }
    }
}
