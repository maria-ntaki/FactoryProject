using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class ChocolateOrder
    {
        public List<Chocolate> Chocolates { get; set; } // units of chocolate
        private double totalPrice;
        public double TotalPrice { 
            get
            {
                foreach (var chocolate in Chocolates)
                {
                    if (chocolate.Name == "Dark")
                        totalPrice += 10;
                    else if (chocolate.Name == "White")
                        totalPrice += 8;
                    else
                        totalPrice += 5;
                }
                return totalPrice;
            }
        }

        public DateTime DateProduced { get; set; } //Property tha will help define what to sell first

        //idea to keep reference to either factory or store as  Seller
        // Store SellerReference --> can be null if order is from factory to store

        public ChocolateOrder(List<Chocolate> chocolates, DateTime dateProduced)
        {
            Chocolates = new List<Chocolate>();
            DateProduced = dateProduced;
        }
    }
}
