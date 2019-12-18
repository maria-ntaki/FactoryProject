using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class ChocolateOrder
    {
        public int DarkChocolates { get; set; }
        public int WhiteChocolates { get; set; }
        public int MilkChocolates { get; set; }
        public int AlmondChocolates { get; set; }
        public int PeanutChocolates { get; set; }
        public IWorkplace Seller { get; set; }
        public ChocoBuyers Buyer { get; set; }
        private double totalPrice;
        public double TotalPrice { 
            get
            {
                return (double)DarkChocolates * 0.7 + WhiteChocolates * 0.6 + MilkChocolates * 0.3 + AlmondChocolates * 0.5 + PeanutChocolates * 0.6;
            }
        }


        public ChocolateOrder(int dark, int white, int milk, int almond, int peanut, IWorkplace seller, ChocoBuyers buyer )
        {   //Use of interfaces to group Seller/Buyer properly?
            DarkChocolates = dark;
            WhiteChocolates = white;
            AlmondChocolates = almond;
            PeanutChocolates = peanut;
            MilkChocolates = milk;
            Seller = seller;
            Buyer = buyer;
            Buyer = null;
        }
    }
}
