using System;

namespace DuckApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Duck mallard = new MallardDuck();
            mallard.PerformQuack();
            mallard.PerformFly();
            mallard.Swim();

            Duck model = new ModelDuck();
            model.Display();
            model.PerformQuack();
            model.PerformFly();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
            
        }
    }
}
