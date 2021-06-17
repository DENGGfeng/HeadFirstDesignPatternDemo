using Chapter._7_AdapterPattern.Interface;
using System;

namespace Chapter._7_AdapterPattern
{
    public class WildTurkey : Turkey
    {
        public void Fly() => Console.WriteLine("I'm flying a short distance.");

        public void Gobble() => Console.WriteLine("Gobble gobble");
    }
}
