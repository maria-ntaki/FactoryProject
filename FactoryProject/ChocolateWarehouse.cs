using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class ChocolateWarehouse
    {   //Described in units
        public int DarkChocolates { get; set; }
        public int WhiteChocolates { get; set; }
        public int MilkChocolates { get; set; }
        public int AlmondChocolates { get; set; }
        public int PeanutChocolates { get; set; }
        IWorkplace WorkPlaceRelated { get; set; }

        public ChocolateWarehouse(int dark, int white, int milk, int almond, int peanut, IWorkplace workplace)
        {
            DarkChocolates = dark;
            WhiteChocolates = white;
            MilkChocolates = milk;
            AlmondChocolates = almond;
            PeanutChocolates = peanut;
            WorkPlaceRelated = workplace;
        }
        public ChocolateWarehouse(IWorkplace workplace)
        {
            DarkChocolates = 0;
            WhiteChocolates = 0;
            MilkChocolates = 0;
            AlmondChocolates = 0;
            PeanutChocolates = 0;
            WorkPlaceRelated = workplace;
        }
    }
}
