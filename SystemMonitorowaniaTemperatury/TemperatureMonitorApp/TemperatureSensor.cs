using System.Collections.Generic;

namespace TemperatureMonitorApp
{
    public class TemperatureSensor
    {
        private List<ITemperatureObserver> _observers = new List<ITemperatureObserver>();
        private int _temperature;

        public void AddObserver(ITemperatureObserver observer)
        {
            _observers.Add(observer);
        }

        public void RemoveObserver(ITemperatureObserver observer)
        {
            _observers.Remove(observer);
        }

        public void SetTemperature(int temperature)
        {
            _temperature = temperature;
            NotifyObservers();
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_temperature);
            }
        }
    }
}
