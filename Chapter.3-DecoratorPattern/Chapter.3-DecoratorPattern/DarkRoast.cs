namespace Chapter._3_DecoratorPattern
{
    /// <summary>
    /// 具体构件
    /// </summary>
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "DarkRoast";
        }

        public override decimal Cost()
        {
            return 3.00M;
        }
    }
}
