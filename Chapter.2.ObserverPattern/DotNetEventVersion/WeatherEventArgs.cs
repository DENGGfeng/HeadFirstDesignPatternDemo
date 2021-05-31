using System;

namespace DotNetEventVersion
{
    public class WeatherEventArgs : EventArgs
    {
        public float humidity { get; private set; }
        public float pressure { get; private set; }
        public float temperature { get; private set; }

        public WeatherEventArgs(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
        }
    }
}
