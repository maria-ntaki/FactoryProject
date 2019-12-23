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

		public Supplier(string firstName, string lastName,string companyWork)
		{
			FirstName = firstName;
			LastName = lastName;
			CompanyWork = companyWork;
		}

		public List<Contract> ConductedContracts { get; set; }

		//public List<Offer> Offers { get ; set; }

		public RawMaterialOrder OrderMaterial(double quantity ,double price)
		{
			//New Order Material
			RawMaterialOrder newOrder = new RawMaterialOrder(quantity, price);
			return newOrder;
		}
		public ChocolateOrder OrderChocolate(List<Chocolate> chocolates,ChocoBuyers buyer)
		{
			//New Order Chocolate
			ChocolateOrder newOrder = new ChocolateOrder(chocolates, this, buyer);
			return newOrder;
		}

	
		
	

		 
	}

 //   {
  //      private string name;
//
 //       public string Name
 //       {
  //          get { return name; }
   //         set { name = value; }
   //     }

 //       public List<RawMaterialOffer> Offers { get; set; }
  //      public Supplier(string name)
  //      {
  //          Name = name;
  //          Offers = new List<RawMaterialOffer>();
  //      }

 //       public RawMaterialOffer CreateOffer()
  //      {
  //          return new RawMaterialOffer(0, 0, 0, this);
  //      }
 //   }
}
