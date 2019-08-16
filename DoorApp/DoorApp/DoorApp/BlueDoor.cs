using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
   public sealed class BlueDoor: Door
    {
        public BlueDoor()
        {
            Console.WriteLine($"Blue Door Constructor");
        }

        public override void Display()
        {
            Console.WriteLine($"Door is {DoorState}");
        }
    }
}