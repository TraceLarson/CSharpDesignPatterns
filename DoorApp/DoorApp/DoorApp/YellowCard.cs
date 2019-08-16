using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    public class YellowCard : IDoorCardBehavior
    {
        public string color = "Yellow";
        public YellowCard(Door door)
        {
            Console.WriteLine("No Card or Invalid Card was presented");
        }


        public YellowCard(BlueDoor door)
        {   
            UseCard();
            door.LockUnlock("Open!");
            door.Display();
        }

        public YellowCard(GreenDoor door)
        {
            UseCard();
            door.LockUnlock("Open!");
            door.Display();
        }

        public YellowCard(YellowDoor door)
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
