using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class ChocolateOrderNoneException : Exception
    {
        public ChocolateOrderNoneException(string message) : base (message)
        {

        }
    }

    class SecondException : Exception
    {

        public SecondException(string message) : base(message)
        {

        }
    }

}
