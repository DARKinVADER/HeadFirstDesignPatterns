using Decorator.Decorables;

namespace Decorator.Decorators
{
    public abstract class CondimentDecorator : Beverage
    {
        protected readonly Beverage _beverage;

        public CondimentDecorator(Beverage beverage)
        {
            _beverage = beverage;
        }
    }
}