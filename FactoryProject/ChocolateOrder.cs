using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class ChocolateOrder
    {
        public List<Chocolate> Chocolates { get; set; }
        public Supplier Supplier { get; set; }
        public ChocoBuyers Buyer { get; set; }
        private double totalPrice;
        public double TotalPrice 
        { 
            get
            {
                return totalPrice;
            }
            set
            {
                totalPrice = 0;
                if (Chocolates.Count != 0)
                {
                    foreach (var chocolate in Chocolates)
                    {
                        if (chocolate.ChocolateKind == Kind.Almond)
                            totalPrice += 5;
                        else if (chocolate.ChocolateKind == Kind.Dark)
                            totalPrice += 7;
                        else if (chocolate.ChocolateKind == Kind.Milk)
                            totalPrice += 6;
                        else if (chocolate.ChocolateKind == Kind.Peanut)
                            totalPrice += 5.5;
                        else
                            totalPrice += 8;
                    }
                }
            }
        }
        public ChocolateOrder(List<Chocolate> chocolates, Supplier supplier, ChocoBuyers buyer )
        {   //Use of interfaces to group Seller/Buyer properly?
            if (chocolates.Count != 0)
            {
                Chocolates = chocolates;
                Supplier = supplier;
                Buyer = buyer;
            }
            else
            {
                throw new ChocolateOrderNoneException("Order cannot must contain at least 1 chocolate!");
            }
        }
    }
}
