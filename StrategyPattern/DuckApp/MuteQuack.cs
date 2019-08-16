using System;
using System.Collections.Generic;
using System.Text;

namespace DuckApp
{
    class MuteQuack : IQuackBehavior
    {
        public void DoQuack()
        {
            Console.WriteLine("I cannot quack");
        }
    }
}
