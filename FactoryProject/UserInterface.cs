using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    abstract class UserInterface
    {
        public static void ManageOrganisation(Organisation company)
        {
            bool exit = false;
            do
            {
                Console.Clear();

                Console.WriteLine("Press 1 to print information for all registered factories");
                Console.WriteLine("Press 2 to print information for all registered stores");
                Console.WriteLine("Press 3 to print information for all registered contracts");
                Console.WriteLine("Press 4 to print information for all registered Suppliers");
                Console.WriteLine("Press any other key to go back to main Menu");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        foreach (var factory in company.Factories)
                        {
                            Console.WriteLine(factory);
                        }
                        break;

                    case "2":
                        foreach (var store in company.Stores)
                        {
                            Console.WriteLine(store);
                        }
                        break;

                    case "3":
                        foreach (var contract in company.ContractsConducted)
                        {
                            Console.WriteLine(contract);
                        }
                        break;

                    case "4":
                        foreach (var supplier in company.Suppliers)
                        {
                            Console.WriteLine(supplier);
                        }
                        break;

                    default:
                        exit = true;
                        break;
                }
                Console.ReadKey();
            } while (!exit);
        }

        public static void ManageFactory(Organisation company)
        {
            bool exit = false;

            do
            {
                Console.Clear();
                Factory relatedFactory = SelectFatory(company);

                Console.WriteLine("Press 1 to print full factory info");
                Console.WriteLine("Press 2 to print all orders? conducted from factory");
                Console.WriteLine("Press 3 to force factory resupply");
                Console.WriteLine("Press 4 to force chocolate production");
                Console.WriteLine("Press any other key to go back to MainMenu");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine(relatedFactory);
                        break;

                    case "2":
                        foreach (var order in relatedFactory.OrdersConducted)
                        {
                            Console.WriteLine(order);
                        }
                        break;

                    case "3":
                        relatedFactory.Resupply();
                        break;

                    case "4":
                        relatedFactory.ProduceChocolate(50, 50, 50, 50, 50);
                        break;

                    default:
                        exit = true;
                        break;
                }
                Console.ReadKey();
            } while (!exit);
        }

        public static void ManageStore(Organisation company)
        {
            bool exit = false;

            do
            {
                Console.Clear();
                Store relatedStore = SelectStore(company);

                Console.WriteLine("Press 1 to print full store info");
                Console.WriteLine("Press 2 to print transactions conducted from store");
                Console.WriteLine("Press 3 to force store resupply from random factory");
                Console.WriteLine("Press 4 print all employees");
                Console.WriteLine("Press any other key to go back to MainMenu");

                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        Console.WriteLine(relatedStore);
                        break;

                    case "2":
                        foreach (var transaction in relatedStore.Transactions)
                        {
                            Console.WriteLine(transaction);
                        }
                        break;

                    case "3":
                        relatedStore.ResupplyChocolate(company.Factories[0]);
                        break;

                    case "4":
                        foreach (var employee in relatedStore.Employees)
                        {
                            Console.WriteLine(employee);
                        }
                        break;

                    default:
                        exit = true;
                        break;
                }
                Console.ReadKey();
            } while (!exit);
        }

        public static void ManageCustomer(Organisation company)
        {
            bool exit = false;

            do
            {
                Console.Clear();
                Customer relatedCustomer = SelectCustomer(company);

                Console.WriteLine("Press 1 to print all customer's transactions");
                Console.WriteLine("Press 2 to place a new order");
                Console.WriteLine("Press any other key to go back to MainMenu");


                string userChoice = Console.ReadLine();

                switch (userChoice)
                {
                    case "1":
                        foreach (var order in relatedCustomer.ChocoOrders)
                        {
                            Console.WriteLine(order);
                        }
                        break;

                    case "2":
                        PlaceOrder(relatedCustomer, company);
                        break;


                    default:
                        exit = true;
                        break;
                }
                Console.ReadKey();
            } while (!exit);
        }

        public static Factory SelectFatory(Organisation company)
        {
            bool isNumber = false;
            int relatedFactoryIndex;

            do
            {
                Console.Clear();

                for (int i = 0; i < company.Factories.Count; i++)
                {
                    Console.WriteLine($"{i}. {company.Factories[i]}");
                }

                Console.WriteLine("Please type the index of the factory you want to work with");

                string userChoice = Console.ReadLine();

                isNumber = int.TryParse(userChoice, out relatedFactoryIndex);

            } while (!isNumber);

            return company.Factories[relatedFactoryIndex];
        }

        public static Store SelectStore(Organisation company)
        {
            bool isNumber = false;
            int relatedStoreIndex;

            do
            {
                Console.Clear();

                for (int i = 0; i < company.Stores.Count; i++)
                {
                    Console.WriteLine($"{i}. {company.Stores[i]}");
                }

                Console.WriteLine("Please type the index of the store you want to work with");

                string userChoice = Console.ReadLine();

                isNumber = int.TryParse(userChoice, out relatedStoreIndex);

            } while (!isNumber);

            return company.Stores[relatedStoreIndex];

        }

        public static Customer SelectCustomer(Organisation company)
        {
            bool isNumber = false;
            int relatedCustomerIndex;
            List<Customer> customersBufferList = new List<Customer>();
            do
            {
                Console.Clear();

                
                foreach (var store in company.Stores)
                {
                    foreach (var customer in store.Customers)
                    {
                        customersBufferList.Add(customer);
                    }
                }

                for (int i = 0; i < customersBufferList.Count; i++)
                {
                    Console.WriteLine($"{i}. {customersBufferList[i]}");
                }


                Console.WriteLine("Please type the index of the custommer you want to work with");

                string userChoice = Console.ReadLine();

                isNumber = int.TryParse(userChoice, out relatedCustomerIndex);

            } while (!isNumber);

            return customersBufferList[relatedCustomerIndex];

        }

        public static void PlaceOrder(Customer customer, Organisation company)
        {
            Console.WriteLine("How mayn dark chocolates do you want to buy?");
            int dark = int.Parse(Console.ReadLine());

            Console.WriteLine("How mayn dark chocolates do you want to buy?");
            int white = int.Parse(Console.ReadLine());

            Console.WriteLine("How mayn dark chocolates do you want to buy?");
            int milk = int.Parse(Console.ReadLine());

            Console.WriteLine("How mayn dark chocolates do you want to buy?");
            int peanut = int.Parse(Console.ReadLine());

            Console.WriteLine("How mayn dark chocolates do you want to buy?");
            int almond = int.Parse(Console.ReadLine());

            List<Chocolate> desiredChocolates = customer.CreateOrder(dark, white, milk, peanut, almond);
            Console.Clear();

            Store storeToBuyFrom = SelectStore(company);
            storeToBuyFrom.SellChocolateOrder(desiredChocolates, customer);
            
            

        }
    }
}
