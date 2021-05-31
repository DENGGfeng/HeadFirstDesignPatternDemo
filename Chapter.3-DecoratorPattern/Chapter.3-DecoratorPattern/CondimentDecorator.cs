namespace Chapter._3_DecoratorPattern
{
    /// <summary>
    /// 抽象装饰
    /// </summary>
    public abstract class CondimentDecorator : Beverage
    {
        public override abstract string GetDescription();
    }
}
