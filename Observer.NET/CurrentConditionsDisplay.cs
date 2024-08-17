namespace Observer.NET
{
    public class CurrentConditionsDisplay : IObserver<WeatherData>
    {
        private readonly IObservable<WeatherData> _observable;
        private readonly IDisposable _unsubscriber;
        private WeatherData _state;

        public CurrentConditionsDisplay(IObservable<WeatherData> observable)
        {
            this._observable = observable;
            _unsubscriber = observable.Subscribe(this);
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
            Console.WriteLine($"Current temperature is {_state.Temperature}");
        }

        public void Unsubscribe() => _unsubscriber.Dispose();
    }
}
