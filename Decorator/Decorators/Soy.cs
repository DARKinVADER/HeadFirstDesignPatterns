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

        public override double Cost()
        {
            return 0.15 + _beverage.Cost();
        }
    }
}
