namespace Observer.NET
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new();
            WeatherStation weatherStation = new();

            CurrentConditionsDisplay currentConditionsDisplay = new(weatherStation);
            StatisticDisplay statisticDisplay = new(weatherStation);

            for (int i = 0; i < 5; i++)
            {
                if (i == 2)
                {
                    statisticDisplay.Unsubscribe();
                }
                weatherStation.WeatherDataChanged(new()
                {
                    Humidity = random.Next(1, 100),
                    Pressure = random.Next(1, 100),
                    Temperature = random.Next(1, 100)
                });
            }

        }
    }
}
