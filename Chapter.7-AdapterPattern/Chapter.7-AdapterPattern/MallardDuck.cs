using Chapter._7_AdapterPattern.Interface;
using System;

namespace Chapter._7_AdapterPattern
{
    public class MallardDuck : Duck
    {
        public void Fly() => Console.WriteLine(nameof(Fly));

        public void Quack() => Console.WriteLine(nameof(Quack));
    }
}
