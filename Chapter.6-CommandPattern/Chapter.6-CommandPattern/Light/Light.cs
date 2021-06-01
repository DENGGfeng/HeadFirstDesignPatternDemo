using System;

namespace Chapter._6_CommandPattern
{
    public class Light
    {
        string name;

        public Light(string name)
        {
            this.name = name;
        }

        public void On() => Console.WriteLine($"{name} Light On.");
        public void Off() => Console.WriteLine($"{name} Light Off.");
    }
}
