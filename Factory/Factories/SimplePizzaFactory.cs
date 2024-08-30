using Factory.Pizzas;

namespace Factory.Factories
{
    internal class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("cheese"))
            {
                pizza = new CheesePizza();
            }
            else if (type.Equals("greek"))
            {
                pizza = new GreekPizza();
            }
            else if (type.Equals("pepperoni"))
            {
                pizza = new PepperoniPizza();
            }
            else
            {
                throw new ArgumentException("Invalid pizza type");
            }

            return pizza;
        }
    }
}
