using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
   public sealed class GreenDoor : Door
    {
        public GreenDoor()
        {
            Console.WriteLine($"Green Door Constructor");
        }

        public override void Display()
        {
            Console.WriteLine($"Door is {DoorState}");
        }
    }
}