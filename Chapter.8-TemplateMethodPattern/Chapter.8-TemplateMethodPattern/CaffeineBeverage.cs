using System;

namespace Chapter._8_TemplateMethodPattern
{
    public abstract class CaffeineBeverage
    {
        public void PrepareRecipe()
        {
            BoilWater();
            Brew();
            PourInCup();
            if (CustomerWantsCondiments())
            {
                AddCondiments();
            }
        }

        public virtual bool CustomerWantsCondiments()
        {
            return true;
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pouring into cup");
        }

        protected string GetUserInput()
        {
            Console.WriteLine("Would you like milk and sugar with you coffee(y/n)? ");
            string anser = Console.ReadLine();
            return anser ?? "no";
        }
    }
}
