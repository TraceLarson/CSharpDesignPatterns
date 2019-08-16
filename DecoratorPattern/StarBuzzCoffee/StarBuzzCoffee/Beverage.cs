using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzCoffee
{
    public abstract class Beverage
    {
        public enum Size
        {
            Tall,
            Grande,
            Venti
        };

        public Size size = Size.Tall;
        public string Description = "Unknown Beverage";

        public virtual string GetDescription()
        {
            return Description;
        }

        public void SetSize(Size size)
        {
            this.size = size;
        }

        public virtual Size GetSize()
        {
            return size;
        }

        public abstract decimal Cost();
    }
}
