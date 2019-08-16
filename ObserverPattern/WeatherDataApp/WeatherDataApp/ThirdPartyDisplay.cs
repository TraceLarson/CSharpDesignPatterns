using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataApp
{
    class ThirdPartyDisplay : iObserver, iDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private iSubject weatherData;

        public ThirdPartyDisplay(iSubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();
        }

        public void Display() {
            Console.WriteLine($"Insert third party display here");
        }
    }
}
