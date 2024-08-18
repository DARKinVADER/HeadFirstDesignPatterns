using Decorator.Decorables;

namespace Decorator.Decorators
{
    internal class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage) : base(beverage)
        {
        }

        public override string GetDescription()
        {
            return _beverage.GetDescription() + ", Mocha";
        }

        public override double Cost()
        {
            return 0.2 + _beverage.Cost();
        }
    }
}
