using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataApp
{
    class StatisticsDisplay : iObserver, iDisplayElement
    {
        private List<iSubject> longTermWeatherData = new List<iSubject>();
        private float temperature;
        private float humidity;
        private float pressure;
        private iSubject weatherData;

        public StatisticsDisplay(iSubject weatherData)
        {
            weatherData.RegisterObserver(this);
            this.weatherData = weatherData;
            RegisterLongTermWeatherData(this.weatherData);

        }
        public void Update(float temperature, float humidity, float pressure){
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            Display();

        }

        public void RegisterLongTermWeatherData(iSubject weatherData)
        {
            longTermWeatherData.Add(weatherData);
        }

        public void Display() {
            float dataTemps = 0;
            float tempAvg = 0;
            foreach(WeatherData datas in longTermWeatherData)
            {
                dataTemps += datas.GetTemperature();
                tempAvg = dataTemps / longTermWeatherData.Count;
                
            }
            Console.WriteLine($"Temperature Average: {tempAvg} degrees");

        }
    }
}
