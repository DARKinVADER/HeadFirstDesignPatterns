using Factory.FactoryMethod.Stores;
using Factory.Pizzas;

namespace Factory.FactoryMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();

            Pizza nyCheese = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {nyCheese.Name}");

            Pizza chicagoVeggie = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Joel ordered a {chicagoVeggie.Name}");
        }
    }
}
