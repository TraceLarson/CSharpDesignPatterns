using System;
using System.Collections.Generic;
using System.Text;

namespace DuckApp
{
    class FlyWithWings : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
