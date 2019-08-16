using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataApp
{
    class ForcastDisplay: iObserver, iDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private iSubject weatherData;

        public ForcastDisplay(iSubject weatherData)
        {
            weatherData.RegisterObserver(this);
            this.weatherData = weatherData;
        }
        public void Update(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display() {
            Console.WriteLine($"The Forcast is ... sunny skies on the way!");
        }
    }
}
