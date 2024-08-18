using Decorator.Decorables;

namespace Decorator.Decorators
{
    internal class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", SteamedMilk";
        }

        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }
    }
}
