using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Employee
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

		public List<IWorkplace> WorkPlaces { get; set; }
		public Employee(IWorkplace workplace, string firstName, string lastName)
		{
			FirstName = firstName;
			LastName = lastName;
			WorkPlaces = new List<IWorkplace>();
			WorkPlaces.Add(workplace);
		}
	}
}
