namespace Observer.NET
{
    public class StatisticDisplay : IObserver<WeatherData>
    {
        private readonly IObservable<WeatherData> _observable;
        private readonly IDisposable _unsubscriber;
        private WeatherData _state;

        public StatisticDisplay(IObservable<WeatherData> observable)
        {
            _observable = observable;
            _unsubscriber = _observable.Subscribe(this);
        }
        public void OnCompleted()
        {
            Console.WriteLine("No more data for StatisticDisplay");
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            _state = value;
            Console.WriteLine($"Statistic is {_state.Pressure}");
        }

        public void Unsubscribe() => _unsubscriber.Dispose();
    }
}
