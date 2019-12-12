using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    enum Kind
    {
        Dark, White, Milk, Almond, Hazelnut
    }
    class Chocolate
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private double price;
        //public double Price
        //{
        //    get { return price; }
        //    set { price = value; }
        //}
        //private double rawMaterial;
        //public double RawMaterial
        //{
        //    get { return rawMaterial; }
        //    set { rawMaterial = value; }
        //}
        public Chocolate(string name) //, double price, double rawmaterial
        {
            Name = name;
            //Price = price;
            //RawMaterial = rawmaterial;
        }
    }
}
