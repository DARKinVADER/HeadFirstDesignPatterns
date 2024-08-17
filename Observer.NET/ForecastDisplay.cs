namespace Observer.NET
{
    public class ForecastDisplay : IObserver<WeatherData>
    {
        public void OnCompleted()
        {
            throw new NotImplementedException();
        }

        public void OnError(Exception error)
        {
            throw new NotImplementedException();
        }

        public void OnNext(WeatherData value)
        {
            throw new NotImplementedException();
        }
    }
}
