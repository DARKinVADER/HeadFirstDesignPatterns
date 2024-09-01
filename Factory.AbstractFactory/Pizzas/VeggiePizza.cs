using Factory.AbstractFactory.Factories;

namespace Factory.AbstractFactory.Pizzas
{
    internal class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory ingredientFactory, string name) : base(ingredientFactory)
        {
            Name = name;
        }

        internal override void Prepare() => throw new NotImplementedException();
    }
}
