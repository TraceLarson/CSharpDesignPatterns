using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzCoffee
{
    public abstract class CondimentsDecorator : Beverage
    {
        public Beverage beverage;
        public override string GetDescription()
        {
            return Description;
        }

        public override Size GetSize()
        {
            return beverage.GetSize();
        }

        
    }
}
