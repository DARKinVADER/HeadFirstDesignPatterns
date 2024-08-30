using Factory.FactoryMethod.Pizzas;
using Factory.Pizzas;

namespace Factory.FactoryMethod.Stores
{
    internal class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type) => type switch
        {
            "cheese" => new ChicagoStyleCheesePizza(),
            "pepperoni" => new ChicagoStylePepperoniPizza(),
            "clam" => new ChicagoStyleClamPizza(),
            "veggie" => new ChicagoStyleVeggiePizza(),
            _ => null
        };
    }
}
