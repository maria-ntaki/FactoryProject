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
            Console.WriteLine("Welcome");

            Console.WriteLine("Which entity would you like to work with?");

            Console.WriteLine("1. Factory");
            //Prints a list of all factories
            //Prompts user to bind an element(factory) to work with
            //Prints all data for specific factory
            //Option to "force" rawMaterial resupply 
            //Option to "force" chocolate production
            Console.WriteLine("2. Organiastion");
            //Prints full organization info
            //Option to print List of all contracts
            //Option to print List of all factories
            //Option to print List of all stores
            //Option to print List of all contracts
            Console.WriteLine("3. Store");
            //Prints a list of all stores
            //Prompts user to bind an element(store) to work with
            //Prints all data for specific store
            //Option to "force" chocolate resupply 
            
            Console.WriteLine("4. Customer");
            //Prints all customers or creates one
            //Binds one
            //Forms an order
            //Prints all stores
            //Asks which store to make the order from
            //done
        }
    }
}
