namespace FatoryPattern
{
    public class NYPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();
            if (type.Equals("cheese"))
            {
                pizza = new NYCheesePizza(ingredientFactory);
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
}
