using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Store
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public List<Chocolate> Chocolates { get; set; }
        public List<Employee> Employees { get; set; }
        public Organisation Owner { get; set; }
        public Store(string name, Organisation owner)
        {
            Name = name;
            Owner = owner;
            Employees = new List<Employee>();
            Chocolates = new List<Chocolate>();
        }

        void SellChocolate(string chocolatename, int quantity)
        {

        }
    }
}
