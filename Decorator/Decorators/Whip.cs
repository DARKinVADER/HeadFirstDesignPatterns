using Decorator.Decorables;

namespace Decorator.Decorators
{
    internal class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Whip";
        }

        public override double Cost()
        {
            return 0.1 + _beverage.Cost();
        }
    }
}
