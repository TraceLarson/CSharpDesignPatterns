using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    public sealed class YellowDoor: Door
    {
        public YellowDoor()
        {
            Console.WriteLine($"Yellow Door Constructor");
        }

        public override void Display()
        {
            Console.WriteLine($"Door is {DoorState}");
        }
    }
}
