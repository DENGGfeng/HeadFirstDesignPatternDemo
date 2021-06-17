using System;

namespace Chapter._8_TemplateMethodPattern
{
    public class Tea : CaffeineBeverage
    {
        public override void Brew()
        {
            Console.WriteLine("Steeping the tea");
        }

        public override void AddCondiments()
        {
            Console.WriteLine("Add Lemon");
        }

        public override bool CustomerWantsCondiments()
        {
            var answer = GetUserInput();
            if (answer.ToLower().StartsWith("y")) return true;
            return false;
        }
    }
}
