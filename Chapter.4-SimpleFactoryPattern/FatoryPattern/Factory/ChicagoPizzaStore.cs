namespace FatoryPattern
{
    public class ChicagoPizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new
                ChicagoPizzaIngredientFactory();
            if (type.Equals("cheese"))
            {
                pizza = new ChicagoCheesePizza(ingredientFactory);
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
}
