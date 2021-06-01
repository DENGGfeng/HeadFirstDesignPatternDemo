using System;

namespace FatoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyStore = new NYPizzaStore();
            PizzaStore chicagoStore = new ChicagoPizzaStore();

            Pizza pizza = nyStore.OrderPizza("cheese");

            Console.WriteLine($"Ethan orderde a {pizza.GetName()}");

            pizza = chicagoStore.OrderPizza("cheese");

            Console.WriteLine($"Joel orderde a {pizza.GetName()}");
        }
    }

    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Cheese CreateCheese() => new ReggianoCheese();
        public Clam CreateClam() => new FreshClam();
        public Dough CreateDough() => new ThinCrustDough();
        public Pepperoni CreatePepperoni() => new SlicedPepperoni();
        public Sauce CreateSauce() => new MarinaraSauce();

        public Veggies[] CreateVeggies()
        {
            return new Veggies[]
            {
                new Gralic(),
                new Onion() ,
                new Mushroom(),
                new RedPepper()
            };
        }
    }

    public class ClamPizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public ClamPizza(PizzaIngredientFactory ingredientFactory)
        {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Preparing {name}...");
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();
            clam = ingredientFactory.CreateClam();
        }
    }
}
