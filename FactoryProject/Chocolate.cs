using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryProject
{
    class Chocolate
    {
        
        private ChocoKind kind;

        private int amount; 
        public ChocoKind Kind { get; set; }
        public int Amount { get; set; }
        public float Value { get; set; }
        public DateTime ProductionDate { get; set; }

        public DateTime ProductionDate { get; private set; }

        public Chocolate(ChocoKind name, int amount)
        {
            Kind = name;
            Amount = amount;
            ProductionDate = DateTime.Now;
        }

    }
}
