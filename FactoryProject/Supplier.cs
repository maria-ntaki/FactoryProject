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

		private List<RawMaterialOffer> offers;
		private List<Contract> conductedContracts;


		public Supplier(string firstName, string lastName,string companyWork)
		{
			offers = new List<RawMaterialOffer>();
			conductedContracts = new List<Contract>();

			FirstName = firstName;
			LastName = lastName;
			CompanyWork = companyWork;
		}

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
		public void MakeContract()
		{
			Contract newContract = new Contract(null,null,this,null,null,null);
			conductedContracts.Add(newContract);
		}
		public void CreateOffer()
		{
			//Create an Offer
			RawMaterialOffer newoffer = new RawMaterialOffer(500,100,100,this);
			offers.Add(newoffer);
		}		 
	}
}
