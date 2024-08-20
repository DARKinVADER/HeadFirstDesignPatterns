namespace Decorator.Decorables
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend";
        }

        public override double Cost()
        {
            return 0.89;
        }
    }
}