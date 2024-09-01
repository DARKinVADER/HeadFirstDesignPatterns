using Factory.AbstractFactory.Factories;
using Factory.AbstractFactory.Ingredeints;

namespace Factory.AbstractFactory.Pizzas
{
    internal abstract class Pizza
    {
        protected readonly IPizzaIngredientFactory _ingredientFactory;

        public Pizza(IPizzaIngredientFactory ingredientFactory)
        {
            _ingredientFactory = ingredientFactory;
        }
        public string Name { get; init; } = "Pizza";
        protected Dough Dough;
        protected Sauce Sauce;
        protected Cheese Cheese;
        protected Clams Clam;
        protected List<string> Toppings = new();

        internal virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
        internal virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
        internal virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
        internal abstract void Prepare();
    }
}
