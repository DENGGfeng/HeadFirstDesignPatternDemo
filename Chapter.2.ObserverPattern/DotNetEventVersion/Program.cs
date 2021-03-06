using System;

namespace DotNetEventVersion
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentCondtionsDisplay currentCondtionsDisplay = new CurrentCondtionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
