using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Employee
    {
		private string name;

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		private string surName;

		public string SurName
		{
			get { return surName; }
			set { surName = value; }
		}

		public IWorkplaces WorkPlace { get; set; }
		public Employee(IWorkplaces workplace, string name, string surname)
		{
			Name = name;
			SurName = surname;
			WorkPlace = workplace;
		}
	}
}
