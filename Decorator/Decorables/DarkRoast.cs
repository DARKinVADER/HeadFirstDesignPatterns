namespace Decorator.Decorables
{
    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            description = "Dark Roast";
        }

        public override double Cost()
        {
            return 0.99;
        }
    }
}