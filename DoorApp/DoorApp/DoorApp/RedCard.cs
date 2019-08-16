using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    public class RedCard : IDoorCardBehavior
    {
        public string color = "Red";
        public RedCard(Door door)
        {
            Console.WriteLine("No Card or Invalid Card was presented");
        }

        public RedCard(RedDoor door)
        {
            UseCard();
            door.LockUnlock("Open!");
            door.Display();
            
        }

        public RedCard(BlueDoor door)
        {   
            UseCard();
            door.LockUnlock("Open!");
            door.Display();
        }

        public RedCard(GreenDoor door)
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
            Console.WriteLine("A Red card was presented");
        }
    }
}
