﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoorApp
{
    public interface IDoorCardBehavior
    {
        void UseCard();
        string GetColor();
    }
}
