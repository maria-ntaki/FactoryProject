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

		private double rawMaterialAmount;

		public double RawMaterialAmount
		{
			get { return rawMaterialAmount; }
			set { rawMaterialAmount = value; }
		}

		public Supplier SupplierRelated { get; set; }

		public RawMaterialOffer(double price, double quality, double amount, Supplier supplierRelated)
		{
			Price = price;
			Quality = quality;
			RawMaterialAmount = amount; 
			SupplierRelated = supplierRelated;
		}
	}
}
