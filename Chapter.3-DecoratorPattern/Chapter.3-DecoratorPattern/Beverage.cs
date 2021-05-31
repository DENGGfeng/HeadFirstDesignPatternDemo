namespace Chapter._3_DecoratorPattern
{
    /// <summary>
    /// 抽象构件
    /// </summary>
    public abstract class Beverage
    {
        protected string description = "Unknow Beverage.";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract decimal Cost();
    }
}
