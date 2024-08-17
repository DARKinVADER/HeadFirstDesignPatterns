using Observer.Observers;
using Observer.Subject;

namespace Observer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new ();
            WeatherStation weatherStation = new ();

            IObserver currentConditionsDisplay = new CurrentConditionsDisplay(weatherStation);
            IObserver forecastDisplay = new ForecastDisplay(weatherStation);    
            IObserver statisticDisplay = new StatisticDisplay(weatherStation);

            for (int i = 0; i < 3; i++)
            {
                weatherStation.MeasurementsChanged(new()
                {
                    Humidity = random.Next(1, 100),
                    Pressure = random.Next(1, 100),
                    Temperature = random.Next(1, 100)
                });
            }
        }
    }
}
