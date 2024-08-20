using Decorator.Decorables;

namespace Decorator.Decorators
{
    internal class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Soy";
        }

        public override double Cost() => Size switch
        {
            Size.Grande => 0.10 + _beverage.Cost(),
            Size.Venti => 0.15 + _beverage.Cost(),
            Size.Tall => 0.20 + _beverage.Cost(),
            _ => _beverage.Cost(),
        };
    }
}
