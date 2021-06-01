using System;

namespace FatoryPattern
{
    public class NYCheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;
        public NYCheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {name}...");
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
        }
    }
}
