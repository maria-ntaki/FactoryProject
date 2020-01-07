using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Program
    {
        static void Main(string[] args)
        {

                Organisation company = new Organisation("QuarkSoft Business");
                Factory demoFactory = new Factory("DemoFactory", 2000, company);
                company.Factories.Add(demoFactory);
                Supplier demoSupplier = new Supplier("DemoFirstName", "DemoLastName", "DemoBusinessName");
                company.Suppliers.Add(demoSupplier);
                Store demoStore = new Store("superDemoShop", company);
                company.Stores.Add(demoStore);


                bool exit = false;
                do
                {
                    Console.Clear();

                    Console.WriteLine("Press 1 to work with the Administration of the organization");
                    Console.WriteLine("Press 2 to work with a factory of the organization");
                    Console.WriteLine("Press 3 to work with a store of the organization");
                    Console.WriteLine("Press 4 to work with a customer");
                    Console.WriteLine("Press Q to exit.");

                    string userChoice = Console.ReadLine();

                    switch (userChoice)
                    {
                        case "1":
                            UserInterface.ManageOrganisation(company);
                            break;

                        case "2":
                            UserInterface.ManageFactory(company);
                            break;

                        case "3":
                            UserInterface.ManageStore(company);
                            break;

                        case "4":
                            UserInterface.ManageCustomer(company);
                            break;

                        case "q":
                        case "Q":
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Invalid choice");
                            break;
                    }

                    Console.WriteLine("Actions done. Press any key to continue");
                    Console.ReadKey();
                } while (!exit);


            //Testing changes v0.1
            //Tesitng changes v0.2

        }
    }
}
