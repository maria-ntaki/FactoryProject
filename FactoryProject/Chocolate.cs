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

        private DateTime expDate;

        public DateTime ExpDate
        {
            get { return expDate; }
            private set { expDate = DateProduced.AddYears(1); }
        }

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

        public static List<Chocolate> CreateChocolatesRequest()
        {
            List<Chocolate> chocolates = new List<Chocolate>();

            Console.WriteLine("How many dark chocolates do you want to order?");
            int dark = int.Parse(Console.ReadLine());

            Console.WriteLine("How many white chocolates do you want to order?");
            int white = int.Parse(Console.ReadLine());

            Console.WriteLine("How many milk chocolates do you want to order?");
            int milk = int.Parse(Console.ReadLine());

            Console.WriteLine("How many almond chocolates do you want to order?");
            int almond = int.Parse(Console.ReadLine());

            Console.WriteLine("How many peanut chocolates do you want to order?");
            int peanut = int.Parse(Console.ReadLine());


            for (int i = 0; i < dark; i++)
            {
                Chocolate newDarkChoco = new Chocolate(Kind.Dark);
                chocolates.Add(newDarkChoco);
            }

            for (int i = 0; i < white; i++)
            {
                Chocolate newWhiteChoco = new Chocolate(Kind.White);
                chocolates.Add(newWhiteChoco);
            }

            for (int i = 0; i < milk; i++)
            {
                Chocolate newMilkChoco = new Chocolate(Kind.Milk);
                chocolates.Add(newMilkChoco);
            }

            for (int i = 0; i < almond; i++)
            {
                Chocolate newAlmondChoco = new Chocolate(Kind.Almond);
                chocolates.Add(newAlmondChoco);
            }

            for (int i = 0; i < peanut; i++)
            {
                Chocolate newPeanutChoco = new Chocolate(Kind.Peanut);
                chocolates.Add(newPeanutChoco);
            }


            return chocolates;
        }

        public bool CheckIfExpired()
        {
            bool isExpired = false;
            if (ExpDate >= DateTime.Now)
            {
                isExpired = true;
            }
            return isExpired;
        }

    }
}
