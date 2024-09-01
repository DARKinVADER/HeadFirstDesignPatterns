using Factory.AbstractFactory.Factories;
using Factory.AbstractFactory.Pizzas;

namespace Factory.FactoryMethod.Stores
{
    internal class ChicagoStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type) => type switch
        {
            "cheese" => new CheesePizza(new ChicagoPizzaIngredientFactory(), "Chicago Style Cheese Pizza"),
            "pepperoni" => new PepperoniPizza(new ChicagoPizzaIngredientFactory(), "Chicago Style Pepperoni Pizza"),
            "clam" => new ClamPizza(new ChicagoPizzaIngredientFactory(), "Chicago Style Clam Pizza"),
            "veggie" => new VeggiePizza(new ChicagoPizzaIngredientFactory(), "Chicago Style Veggie Pizza"),
            _ => null
        };
    }
}
