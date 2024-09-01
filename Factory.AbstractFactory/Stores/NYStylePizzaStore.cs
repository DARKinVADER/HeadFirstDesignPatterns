using Factory.AbstractFactory.Factories;
using Factory.AbstractFactory.Pizzas;

namespace Factory.FactoryMethod.Stores
{
    internal class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type) => type switch
        {
            "cheese" => new CheesePizza(new NYPizzaIngredientFactory(), "NY Style Cheese Pizza"),
            "pepperoni" => new PepperoniPizza(new NYPizzaIngredientFactory(), "NY Style Pepperoni Pizza"),
            "clam" => new ClamPizza(new NYPizzaIngredientFactory(), "NY Style Clam Pizza"),
            "veggie" => new VeggiePizza(new NYPizzaIngredientFactory(), "NY Style Veggie Pizza"),
            _ => null
        };
    }
}
