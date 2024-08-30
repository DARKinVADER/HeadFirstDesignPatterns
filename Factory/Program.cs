

using Factory.Factories;
using Factory.Pizzas;

namespace Factory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SimplePizzaFactory factory = new SimplePizzaFactory();
            PizzaStore pizzaStore = new PizzaStore(factory);

            Pizza pizza = pizzaStore.OrderPizza("cheese");
        }
    }
}
