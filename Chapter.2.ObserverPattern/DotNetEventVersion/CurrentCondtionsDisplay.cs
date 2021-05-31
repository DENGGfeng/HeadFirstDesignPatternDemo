using System;

namespace DotNetEventVersion
{
    public class CurrentCondtionsDisplay : IDisplayElement
    {
        private float temperature;
        private float humidity;

        public CurrentCondtionsDisplay(WeatherData wetherData)
        {
            wetherData.MeasurementsChangedEvent += MeasurementsChanged;
        }
        public void Display()
        {
            Console.WriteLine($"Current condtions:{temperature} F degress and {humidity}% humidity.");
        }

        public void MeasurementsChanged(object sender, WeatherEventArgs e)
        {
            this.humidity = e.humidity;
            this.temperature = e.temperature;
            Display();
        }
    }
}
