using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    public abstract class Door
    {
        protected string DoorColor;
        protected string DoorState;

        
        public abstract void Display();
        

        public virtual void LockUnlock(string newDoorState)
        {
            DoorState = newDoorState;
        }
    }
}
