using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaFactory
{
    public class ChicagoStylePizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            switch (type)
            {
                case "Cheese":
                    pizza = new ChicagoStyleCheesePizza();
                    break;
                case "pepperoni":
                    pizza = new ChicagoStylePepperoniPizza();
                    break;
                case "clam":
                    pizza = new ChicagoStyleClamPizza();
                    break;
                case "veggie":
                    pizza = new ChicagoStyleVeggiePizza();
                    break;
                default:
                    Console.WriteLine("default case");
                    break;
            }

            return pizza;
        }
        public class ChicagoStyleCheesePizza : Pizza
        {
            public override void Prepare()
            {
                
                Console.WriteLine("Preparing pizza");
            }

            public override void Bake()
            {
                Console.WriteLine("Baking pizza");
            }

            public override void Cut()
            { 
                Console.WriteLine("Cutting Pizza");
            }

            public override void Box()
            {
                Console.WriteLine("Boxing pizza");
            }
        }


        public class ChicagoStyleVeggiePizza : Pizza
        {
            public override void Prepare()
            {
                Console.WriteLine("Preparing pizza");
            }

            public override void Bake()
            {

                Console.WriteLine("Baking pizza");
            }

            public override void Cut()
            {
                Console.WriteLine("Cutting Pizza");
            }

            public override void Box()
            {

                Console.WriteLine("Boxing pizza");
            }
        }

        public class ChicagoStyleClamPizza : Pizza
        {
            public override void Prepare()
            {
                Console.WriteLine("Preparing pizza");
            }

            public override void Bake()
            {

                Console.WriteLine("Baking pizza");
            }

            public override void Cut()
            {

                Console.WriteLine("Cutting Pizza");
            }

            public override void Box()
            {

                Console.WriteLine("Boxing pizza");
            }
        }

        public class ChicagoStylePepperoniPizza : Pizza
        {
            public override void Prepare()
            {
                
                Console.WriteLine("Preparing pizza");
            }

            public override void Bake()
            {

                Console.WriteLine("Baking pizza");
            }

            public override void Cut()
            {

                Console.WriteLine("Cutting Pizza");
            }

            public override void Box()
            {
                Console.WriteLine("Boxing pizza");
            }
        }
    }
}
