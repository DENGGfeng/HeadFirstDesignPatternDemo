using System;

namespace Chapter._1_DuckDemo
{
    public class FlyNoWay : FlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't flying!");
        }
    }
}
