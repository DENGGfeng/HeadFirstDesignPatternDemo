using System;

namespace Chapter._1_DuckDemo
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            quackBehavior = new Quackk();
            flyBehavior = new FlyNoWay();
        }

        public override void Display()
        {
            Console.WriteLine("I'm Model Duck");
        }
    }
}
