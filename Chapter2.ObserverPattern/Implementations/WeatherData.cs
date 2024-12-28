using Chapter2.ObserverPattern.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter2.ObserverPattern.Implementations
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;
        private float pressure;

        public void registerObserver(IObserver observer) // required from interface
        {
            observers.Add(observer);
        }

        public void removeObserver(IObserver observer) // required from interface
        {
            observers.Remove(observer); 
        }

        public void notifyObservers() // required from interface
        {
            foreach (IObserver observer in observers) 
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void setMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
