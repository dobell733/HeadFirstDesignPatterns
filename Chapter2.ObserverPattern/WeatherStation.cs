using Chapter2.ObserverPattern.Implementations;

namespace Chapter2.ObserverPattern
{
    internal class WeatherStation // Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData); // registered as an observer to weatherData in it's constructor

            // practice implementing these
            // StatisticsDisplay statisticsDisplay = new StatisticsDisplay(weatherData)
            // ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData)

            weatherData.setMeasurements(80, 65, 30.4f);
            weatherData.setMeasurements(82, 70, 29.2f);
            weatherData.setMeasurements(78, 90, 29.2f);
        }
    }
}
