namespace Observer.NET
{
    public class WeatherStation : IObservable<WeatherData>
    {
        List<IObserver<WeatherData>> _observers = new();
        private WeatherData _weatherData;

        public IDisposable Subscribe(IObserver<WeatherData> observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }

            return new Unsubscriber(_observers, observer);
        }

        private void NotifyObservers()
        {
            foreach (var observer in _observers)
            {
                observer.OnNext(_weatherData);
            }
        }

        public void WeatherDataChanged(WeatherData weatherData)
        {
            _weatherData = weatherData;
            NotifyObservers();
        }
    }
}
