using System;

namespace FatoryPattern
{
    public class ChicagoCheesePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ChicagoCheesePizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Cut()
        {
            Console.WriteLine("Cutting the pizza into square slices.");
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
