using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataApp
{
    interface iObserver
    {
        void Update(float temp, float humidity, float pressure);
    }
}
