using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class ChocolateOrder
    {
        //ed
        
        public List<Chocolate> Chocolates { get; set; }
        public IWorkplace Seller { get; set; }
        public IChocoBuyers Buyer { get; set; }
        public double TotalPrice
        {
            get
            {
                double output = 0;
                if (Chocolates.Count != 0)
                    foreach (var chocolate in Chocolates)
                    {
                        if (chocolate.ChocolateKind == Kind.Almond)
                            output += 5;
                        else if (chocolate.ChocolateKind == Kind.Dark)
                            output += 7;
                        else if (chocolate.ChocolateKind == Kind.Milk)
                            output += 6;
                        else if (chocolate.ChocolateKind == Kind.Peanut)
                            output += 5.5;
                        else
                            output += 8;
                    }
                return output;
            }
        }


        public ChocolateOrder(List<Chocolate> chocolates, IWorkplace seller, IChocoBuyers buyer)
        {   //Use of interfaces to group Seller/Buyer properly?
            if (chocolates.Count != 0)
            {
                Chocolates = chocolates;
                Seller = seller;
                Buyer = buyer;
            }
            else
            {
                throw new ChocolateOrderNoneException("Order cannot must contain at least 1 chocolate!");
            }
        }


    }
}
