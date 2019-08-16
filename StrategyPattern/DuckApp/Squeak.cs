using System;
using System.Collections.Generic;
using System.Text;

namespace DuckApp
{
    class Squeak : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("Rubber Duck Squeak!");
        }
    }
}
