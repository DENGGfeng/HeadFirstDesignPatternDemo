using System;

namespace Chapter._1_DuckDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Duck mallerd = new MallardDuck();
            //mallerd.PerformFly();
            //mallerd.PerformQuack();

            Duck model = new ModelDuck();
            model.PerformFly();
            //model.PerformQuack();
            model.SetFlyBehavior(new FlyRocketPowered());
            model.PerformFly();
            Console.ReadKey();
        }
    }
}
