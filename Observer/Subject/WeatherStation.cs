using Observer.Observers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer.Subject
{
    public class WeatherStation : ISubject
    {
        private List<IObserver> _observers = new();
        State _state;

        public void NotifyObservers()
        {
            _observers.ForEach(o => o.Update(_state));
        }

        public void RegisterObserver(IObserver observer)
        {
            if (observer is null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            _observers.Add(observer);
        }

        public void UnregisterObserver(IObserver observer)
        {
            if (observer is null)
            {
                throw new ArgumentNullException(nameof(observer));
            }

            _observers.Remove(observer);
        }

        public int GetTemperature() => 1;
        public int GetPressure() => 2;
        public int GetHumidity() => 3;
        public void MeasurementsChanged(State state)
        {
            _state = state;
            NotifyObservers();
        }
    }
}
