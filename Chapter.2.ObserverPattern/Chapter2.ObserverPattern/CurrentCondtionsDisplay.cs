using System;

namespace Chapter2.ObserverPattern
{
    public class CurrentCondtionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private ISubject wetherData;

        public CurrentCondtionsDisplay(ISubject wetherData)
        {
            this.wetherData = wetherData;
            wetherData.RegisterObserver(this);
        }
        public void Display()
        {
            Console.WriteLine($"Current condtions:{temperature} F degress and {humidity}% humidity.");
        }

        public void Update(float temp, float humidity, float pressure)
        {
            this.humidity = humidity;
            this.temperature = temp;
            Display();
        }
    }
}
