using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Balance
    {
        public double Value { get; private set; }
        public Balance(double initialValue)
        {
            Value = initialValue;
        }


        public void AddCash(float ammount)
        {
            Value += ammount;
        }
        public void SubCash(float ammount)
        {
            Value -= ammount;
        }
    }
}
