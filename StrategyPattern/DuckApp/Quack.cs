using System;
using System.Collections.Generic;
using System.Text;

namespace DuckApp
{
    class Quack : IQuackBehavior
    {
        public void DoQuack ()
        {
            Console.WriteLine("QUACK!");
        }
    }
}
