using Decorator.Decorables;
using Decorator.Decorators;

namespace Decorator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Beverage espresso = new Espresso();
            Console.WriteLine($"{espresso.GetDescription()} ${espresso.Cost()}");

            Beverage darkRoast = new DarkRoast();
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Mocha(darkRoast);
            darkRoast = new Whip(darkRoast);
            Console.WriteLine($"{darkRoast.GetDescription()} ${darkRoast.Cost()}");

            Beverage houseBlend = new HouseBlend();
            houseBlend = new Soy(houseBlend);
            houseBlend = new Mocha(houseBlend);
            houseBlend = new Whip(houseBlend);
            Console.WriteLine($"{houseBlend.GetDescription()} ${houseBlend.Cost()}");
        }
    }
}
