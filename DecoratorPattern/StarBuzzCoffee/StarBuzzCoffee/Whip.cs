﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzCoffee
{
    public class Whip : CondimentsDecorator
    {
//        private readonly Beverage beverage;
        public Whip(Beverage beverage)
        {
            this.beverage = beverage;
        }

        public override string GetDescription()
        {
            return beverage.GetDescription() + ", Whip";
        }

        public override decimal Cost()
        {
            decimal cost = beverage.Cost();

            if (beverage.GetSize() == Size.Tall)
            {
                Console.WriteLine("Size is tall");
                cost += .10M;
            }
            else if (beverage.GetSize() == Size.Grande)
            {
                cost += .15M;
            }
            else if (beverage.GetSize() == Size.Venti)
            {
                cost += .20M;
            }

            return cost;
            //            return beverage.Cost() + .15M;
        }
    }
}
