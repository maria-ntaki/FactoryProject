using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    public enum Kind { White, Dark, Milk, Peanut, Almond}
    class Chocolate
    {
        public Kind ChocolateKind { get; set; }
        public DateTime DateProduced { get; set; }
        //public double Price 
        //{ 
        //    get
        //    {
        //        if (ChocolateKind == Kind.White)
        //            return 5;
        //        else if (ChocolateKind == Kind.Peanut)
        //            return 6;
        //        else if (ChocolateKind == Kind.Milk)
        //            return 7;
        //        else if (ChocolateKind == Kind.Dark)
        //            return 4;
        //        else //(ChocolateKind == Kind.Almond)
        //            return 8;
        //    }
        //}

        public Chocolate(Kind chocoKind)
        { //Constructor used for modeling the orders
            ChocolateKind = chocoKind;
        }

        public Chocolate(Kind chocoKind, DateTime dateProduced)
        { //constructor used when producing from factory
            DateProduced = dateProduced;
        }


    }
}
