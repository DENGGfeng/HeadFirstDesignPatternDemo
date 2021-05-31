namespace Chapter._4_SimpleFactoryPattern
{
    public static class SimplePizzaFactory
    {
        public static Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else if (type.Equals("clam"))
            {
                pizza = new Clam();
            }
            else if (type.Equals("veggie"))
            {
                pizza = new Veggie();
            }
            return pizza;
        }
    }
}
