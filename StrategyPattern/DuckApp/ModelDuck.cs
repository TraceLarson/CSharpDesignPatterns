using System;
using System.Collections.Generic;
using System.Text;

namespace DuckApp
{
    class ModelDuck : Duck
    {
        public ModelDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new Quack());
        }

        public override void Display()
        {
            Console.WriteLine("I'm a model Duck!");
        }
    }
}
