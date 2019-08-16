using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataApp
{
    class CurrentConditionsDisplay : iObserver, iDisplayElement 
    {
        private float temperature;
        private float humidity;
        private iSubject weatherData;

        public CurrentConditionsDisplay(iSubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(float temperature, float humidity, float pressure) {
            this.temperature = temperature;
            this.humidity = humidity;
            Display();
        }
        public void Display() {
            Console.WriteLine($"Current Conditions:\r\nTemperature: {temperature} degrees\r\nHumidity: {humidity} %humidity");
        }
    }
}
