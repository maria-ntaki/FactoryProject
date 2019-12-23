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
			Name = firstName;
			LastName = lastName;
			CompanyWork = companyWork;
		}

		public List<Contract> ConductedContracts { get; set; }

		public List<Offer> Offers { get ; set; }

		public RawMaterialOrder OrderMaterial()
		{
			ordernew = new Raw
		}


		 
	}
}
