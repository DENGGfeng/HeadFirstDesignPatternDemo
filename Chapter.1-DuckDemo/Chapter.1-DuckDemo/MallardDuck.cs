using System;

namespace Chapter._1_DuckDemo
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            quackBehavior = new Quackk();
            flyBehavior = new FlyWithWings();
        }

        public override void Display()
        {
            Console.WriteLine("I'm a real MallardDuck");
        }
    }
}
