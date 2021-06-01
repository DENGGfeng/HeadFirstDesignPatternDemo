namespace FatoryPattern
{
    public interface PizzaIngredientFactory
    {
        public Dough CreateDough();

        public Sauce CreateSauce();

        public Cheese CreateCheese();

        public Veggies[] CreateVeggies();

        public Pepperoni CreatePepperoni();

        public Clam CreateClam();
    }
}
