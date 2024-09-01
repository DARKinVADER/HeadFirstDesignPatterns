
using Factory.AbstractFactory.Factories;

namespace Factory.AbstractFactory.Pizzas
{
    internal class ClamPizza : Pizza
    {
        public ClamPizza(IPizzaIngredientFactory ingredientFactory, string name) : base(ingredientFactory)
        {
            Name = name;
        }

        internal override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
            Clam = _ingredientFactory.CreateClams();
        }
    }
}
