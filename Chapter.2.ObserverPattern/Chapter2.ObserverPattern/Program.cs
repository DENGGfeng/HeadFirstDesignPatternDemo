using System;

namespace Chapter2.ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //主题
            WeatherData weatherData = new WeatherData();
            //观察者
            CurrentCondtionsDisplay currentCondtionsDisplay = new CurrentCondtionsDisplay(weatherData);
            weatherData.SetMeasurements(80, 65, 30.4f);
            weatherData.SetMeasurements(82, 70, 29.2f);
            weatherData.SetMeasurements(78, 90, 29.2f);

            Console.ReadKey();
        }
    }
}
