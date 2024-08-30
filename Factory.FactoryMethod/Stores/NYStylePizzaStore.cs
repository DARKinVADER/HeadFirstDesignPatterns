using Factory.FactoryMethod.Pizzas;
using Factory.Pizzas;

namespace Factory.FactoryMethod.Stores
{
    internal class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type) => type switch
        {
            "cheese" => new NYStyleCheesePizza(),
            "pepperoni" => new NYStylePepperoniPizza(),
            "clam" => new NYStyleClamPizza(),
            "veggie" => new NYStyleVeggiePizza(),
            _ => null
        };
    }
}
