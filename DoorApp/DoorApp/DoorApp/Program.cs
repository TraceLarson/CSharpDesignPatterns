using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    class Program
    {
        static void Main(string[] args)
        {

            IDoorCardBehavior myCard = new YellowCard(new BlueDoor());
        }
    }
}