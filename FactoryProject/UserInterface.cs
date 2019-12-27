using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    abstract class UserInterface
    {
        public static void MainMenu(Organisation company)
        {
            //Console.WriteLine("Which entity would you like to work with?");
            Console.WriteLine("Press 1 to work with the Administration of the organization");
            Console.WriteLine("Press 2 to work with the factories of the organization");
            Console.WriteLine("Press 3 to work with the Stores of the organization");
            Console.WriteLine("Press 4 to work with a customer");

            string userChoice = Console.ReadLine();

            switch (userChoice)
            {
                case "1":

                    break;

                case "2":

                    break;

                case "3":

                    break;

                case "4":

                    break;

                default:

                    break;
            }
        }



    }
}
