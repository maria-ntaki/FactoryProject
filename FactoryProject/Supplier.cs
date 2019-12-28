using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Supplier
	{
		private string firstName;

		public string FirstName
		{
			get { return firstName; }
			set { firstName = value; }
		}

		private string lastName;

		public string LastName
		{
			get { return lastName; }
			set { lastName = value; }
		}

		private string companyWork;

		public string CompanyWork
		{
			get { return companyWork; }
			set { companyWork = value; }
		}

		public List<RawMaterialOffer> Offers { get; set; }
		public List<Contract> ConductedContracts { get; set; }


		public Supplier(string firstName, string lastName,string companyWork)
		{
			Offers = new List<RawMaterialOffer>();
			ConductedContracts = new List<Contract>();

			FirstName = firstName;
			LastName = lastName;
			CompanyWork = companyWork;
		}

		//public RawMaterialOrder OrderMaterial(double quantity ,double price)
		//{
		//	//New Order Material
		//	RawMaterialOrder newOrder = new RawMaterialOrder(quantity, price);
		//	return newOrder;
		//}
		//public ChocolateOrder OrderChocolate(List<Chocolate> chocolates, IChocoBuyers buyer)
		//{
		//	//New Order Chocolate
		//	ChocolateOrder newOrder = new ChocolateOrder(chocolates, this, buyer);
		//	return newOrder;
		//}


		public RawMaterialOffer CreateOffer()
		{
			//Create an Offer
			Random selector = new Random();

			RawMaterialOffer newoffer = new RawMaterialOffer(selector.Next(2,4), selector.Next(51, 300),this);

			Offers.Add(newoffer);

			return newoffer;
		}		 
	}
}
