namespace Chapter._3_DecoratorPattern
{

    /// <summary>
    /// 具体构件
    /// </summary>
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "HouseBlend";
        }

        public override decimal Cost()
        {
            return 0.89M;
        }
    }
}
