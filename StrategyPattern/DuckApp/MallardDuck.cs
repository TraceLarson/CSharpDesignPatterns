using System;
using System.Collections.Generic;
using System.Text;

namespace DuckApp
{
    class MallardDuck : Duck
    {
        public MallardDuck()
        {
            SetFlyBehavior(new FlyWithWings());
            SetQuackBehavior(new Quack());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real Mallard Duck!");
        }
    }
}
