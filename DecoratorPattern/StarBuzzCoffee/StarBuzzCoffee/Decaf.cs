﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StarBuzzCoffee
{
    public class Decaf : Beverage
    {
        public Decaf()
        {
            Description = "Decaf Coffee";
        }

        public override decimal Cost()
        {
            return 1.05M;
        }
    }
}
