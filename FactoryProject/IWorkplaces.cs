using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    interface IWorkplace
    {
        string Name { get; set; }

        //We should add a second interface deriving from this one
        //It should serve to separate stores+factories from organisation
        //Idea based on modeling choco orders to be only between stores-factories - customers
    }
}
