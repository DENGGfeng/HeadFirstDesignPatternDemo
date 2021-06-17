using Chapter._7_AdapterPattern.Interface;
using System;

namespace Chapter._7_AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            MallardDuck duck = new MallardDuck();
            WildTurkey turkey = new WildTurkey();

            Duck turkeyAdapter = new TurkeyAdapter(turkey);

            turkey.Fly();
            turkey.Gobble();

            TestDuck(duck);

            TestDuck(turkeyAdapter);

            Console.ReadKey();
        }

        static void TestDuck(Duck duck)
        {
            duck.Fly();
            duck.Quack();
        }
    }
}
