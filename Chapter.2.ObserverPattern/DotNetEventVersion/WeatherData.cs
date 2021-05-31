using System;

namespace DotNetEventVersion
{
    public class WeatherData
    {
        public EventHandler<WeatherEventArgs> MeasurementsChangedEvent;

        protected virtual void OnMeasurementsChangedEvent(WeatherEventArgs e)
        {
            MeasurementsChangedEvent?.Invoke(this, e);
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            OnMeasurementsChangedEvent(new WeatherEventArgs(temperature,humidity,pressure) { });
        }
    }
}
