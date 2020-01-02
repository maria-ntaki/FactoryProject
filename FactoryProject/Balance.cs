using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Balance
    {
        public float HardValue { get; private set; }
        public Balance(float hardValue)
        {
            HardValue = hardValue;
        }


        public void AddCash(float ammount)
        {
            HardValue += ammount;
        }
        public void SubCash(float ammount)
        {
            HardValue -= ammount;
        }
    }
}
