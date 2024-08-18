namespace Decorator.Decorables
{
    public abstract class Beverage
    {
        protected string description = "Unknown";

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }

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

    public class Decaf : Beverage
    {
        public Decaf()
        {
            description = "Decaf";
        }

        public override double Cost()
        {
            return 1.05;
        }
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }
}