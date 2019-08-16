using System;
using System.Collections.Generic;
using System.Text;

namespace DuckApp
{
    public abstract class Duck
    {
        IFlyBehavior flyBehavior;
        IQuackBehavior quackBehavior;


        public virtual void SetFlyBehavior(IFlyBehavior newFlyBehavior)
        {
            flyBehavior = newFlyBehavior;
        }

        public virtual void SetQuackBehavior(IQuackBehavior newQuackBehavior)
        {
            quackBehavior = newQuackBehavior;
        }

        public virtual void PerformFly()
        {
            flyBehavior.Fly();
        }

        public virtual void PerformQuack()
        {
            quackBehavior.DoQuack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

        public abstract void Display();
    }
}
