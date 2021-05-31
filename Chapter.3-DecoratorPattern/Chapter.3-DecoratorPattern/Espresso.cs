namespace Chapter._3_DecoratorPattern
{   
    /// <summary>
    /// 具体构件
    /// </summary>
    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override decimal Cost()
        {
            return 1.99M;
        }
    }
}
