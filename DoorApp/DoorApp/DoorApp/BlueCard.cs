using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    public class BlueCard  : IDoorCardBehavior
    {
        public string color = "Blue";
        public BlueCard(Door door)
        {
            Console.WriteLine("No Card or Invalid Card was presented");
            
        }

        public BlueCard(BlueDoor door)
        {   
            UseCard();
            door.LockUnlock("Open!");
            door.Display();
        }

        public string GetColor()
        {
            return color;
        }
        public void UseCard()
        {
            Console.WriteLine($"A {color} card was presented");
        }
    }
}
