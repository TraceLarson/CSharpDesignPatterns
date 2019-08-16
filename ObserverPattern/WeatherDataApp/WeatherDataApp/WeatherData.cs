using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherDataApp
{
    class WeatherData : iSubject
    {
        private List<iObserver> observers;
        private float temperature;
        private float humidity;
        private float pressure;

        public WeatherData()
        {
            observers = new List<iObserver>();
        }

        public void RegisterObserver(iObserver o) {
            observers.Add(o);
        }
        public void RemoveObserver(iObserver o) {
            int i = observers.IndexOf(o);
            if (i >- 0)
            {
                observers.Remove(o);
            }
        }
        public void NotifyObservers() {
            foreach (iObserver observer in observers)
            {
                observer.Update(temperature, humidity, pressure);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }
        
        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
        public float GetTemperature()
        {
            return temperature;
        }
        public float GetHumidity()
        {
            return humidity;
        }

        public float GetPressure()
        {
            return pressure;
        }

    }
}
