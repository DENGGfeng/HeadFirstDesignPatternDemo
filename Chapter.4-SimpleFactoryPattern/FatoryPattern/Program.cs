using System;

namespace FatoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;

        public virtual void Prepare()
        {
            Console.WriteLine($"Preparing {name}");
            Console.WriteLine("tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
        }
        public virtual void Box()
        {
            Console.WriteLine("Place pizza in official PizzaStore box.");
        }

        public virtual void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350.");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting the pizza inteo digonal slices.");
        }

        public string GetName() => name;
    }

    public abstract class PizzaStore
    {
        public Pizza OrderPizza(string type)
        {
            Pizza pizza;
            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);
    }

    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new NYCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new NYPepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new NYClam();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new NYVeggie();
            }
            return pizza;
        }
    }

    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new ChicagoCheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new ChicagoPepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new ChicagoClam();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new ChicagoVeggie();
            }
            return pizza;
        }
    }

    internal class ChicagoVeggie : Pizza
    {
    }

    internal class ChicagoClam : Pizza
    {
    }

    internal class ChicagoPepperoniPizza : Pizza
    {
    }

    internal class ChicagoCheesePizza : Pizza
    {
    }

    internal class NYVeggie : Pizza
    {
    }

    internal class NYClam : Pizza
    {
    }

    internal class NYPepperoniPizza : Pizza
    {
    }

    internal class NYCheesePizza : Pizza
    {
    }
}
