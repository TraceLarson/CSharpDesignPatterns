using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataApp
{
    interface iSubject
    {
        void RegisterObserver(iObserver o);
        void RemoveObserver(iObserver o);
        void NotifyObservers();

    }
}
