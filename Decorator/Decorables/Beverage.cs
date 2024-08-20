namespace Decorator.Decorables
{
    public abstract class Beverage
    {
        protected string description = "Unknown";
        public virtual Size Size { get; init; }

        public Beverage()
        {
            this.Size = Size.Grande;
        }
        public Beverage(Size size)
        {
            Size = size;
        }

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double Cost();
    }
}

public enum Size
{
    Tall = 0,
    Grande = 1,
    Venti = 2
}