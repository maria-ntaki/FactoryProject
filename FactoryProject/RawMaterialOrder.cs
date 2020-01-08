using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class RawMaterialOrder
    {
        //private int id;
        //
        //public int ID
        //{
        //    get { return id; }
        //    set { id = value; }
        //}
        //
        private double rawMaterial;
        public double RawMaterial
        {
            get { return rawMaterial; }
            set { rawMaterial = value; }
        }
        private double price;
        public double Price
        {
            get { return price; }
            set { price = value; }
        }

        public RawMaterialOrder(double rawMaterial, double price)
        {
            RawMaterial = rawMaterial;
            Price = price;
        }
    }
}
