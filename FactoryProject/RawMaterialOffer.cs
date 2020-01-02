using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class RawMaterialOffer
    {

		private double pricePerKilo;
		private double quality;

		public double PricePerKilo

		{
			get { return pricePerKilo; }
			set
			{
				pricePerKilo = value * (1 + quality / 100);
			}
		}
		public double Quality //Quality is an indicator meaning price should be either a derivative or influenced by it
		{
			get { return quality; }
			set 
			{
				if ( value < 0 || value > 10)
				{
					Console.WriteLine("Quality indicator cannot exceed 10 or be less than 0");
				}
				else
					quality = value; 
			}
		}
		public double RawMaterialAmount { get; set; }
		public Supplier SupplierRelated { get; set; }
		public bool IsActive {get; set;} = true;

		public RawMaterialOffer(double price, double amount, Supplier supplierRelated)
		{
			Quality = quality;
			PricePerKilo = price;
			RawMaterialAmount = amount; //in units
			SupplierRelated = supplierRelated;
			IsActive = true;
		}
	}
}
