using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    public class GreenCard  : IDoorCardBehavior
    {
        public string color = "Green";
        public GreenCard(Door door)
        {
            Console.WriteLine("No Card or Invalid Card was presented");
        }

        public GreenCard(BlueDoor door)
        {   
            UseCard();
            door.LockUnlock("Open!");
            door.Display();
        }

        public GreenCard(GreenDoor door)
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
