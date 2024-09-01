using Factory.AbstractFactory.Factories;

namespace Factory.AbstractFactory.Pizzas
{
    internal class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory ingredientFactory, string name) : base(ingredientFactory)
        {
            Name = name;
        }

        internal override void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Dough = _ingredientFactory.CreateDough();
            Sauce = _ingredientFactory.CreateSauce();
            Cheese = _ingredientFactory.CreateCheese();
        }
    }
}
