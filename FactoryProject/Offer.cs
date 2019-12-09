using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Offer
    {
		private double price;
		//sxolioz
		public double Price
		{
			get { return price; }
			set { price = value; }
		}

		private double quantity;

		public double Quality
		{
			get { return quantity; }
			set { quantity = value; }
		}

		private double amount;

		public double Amount
		{
			get { return amount; }
			set { amount = value; }
		}

		public Supplier SupplierRelated { get; set; }

		public Offer(double price, double quality, double amount, Supplier supplierRelated)
		{
			Price = price;
			Quality = quality;
			Amount = amount; //in kgs
			SupplierRelated = supplierRelated;
		}
	}
}
