namespace Observer.NET
{
    public class Unsubscriber(List<IObserver<WeatherData>> observers, IObserver<WeatherData> observer) : IDisposable
    {
        private readonly List<IObserver<WeatherData>> _observers = observers;
        private readonly IObserver<WeatherData> _observer = observer;

        public void Dispose()
        {
            if (_observers != null)
            {
                _observers.Remove(_observer);
            }
        }
    }
}
