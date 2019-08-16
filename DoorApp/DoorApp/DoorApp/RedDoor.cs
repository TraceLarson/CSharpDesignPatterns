using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    public sealed class RedDoor: Door
    {
        public RedDoor()
        {
            Console.WriteLine($"Red Door Constructor");
        }

        public override void Display()
        {
            Console.WriteLine($"Door is {DoorState}");
        }
    }
}