using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class RawMaterialOffer
    {
		private double price;
		//sxolioz
		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		private double quality;

		public double Quality //quality should be GET only and derive from amount/price formula 
		{
			get { return quality; }
			set { quality = value; }
		}

		private double amount;

		public double Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		public Supplier SupplierRelated { get; set; }

		public RawMaterialOffer(double price, double quality, double amount, Supplier supplierRelated)
		{
			Price = price;
			Quality = quality;
			Amount = amount; //in units
			SupplierRelated = supplierRelated;
		}
	}
}
