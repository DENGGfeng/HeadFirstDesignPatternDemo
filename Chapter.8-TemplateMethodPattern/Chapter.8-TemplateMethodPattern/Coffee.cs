using System;

namespace Chapter._8_TemplateMethodPattern
{
    public class Coffee : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Adding Sugar and Milk");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Dripping Coffee through filter");
        }
    }
}
