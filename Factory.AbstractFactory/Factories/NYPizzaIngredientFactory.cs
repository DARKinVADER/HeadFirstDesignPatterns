using Factory.AbstractFactory.Ingredeints;

namespace Factory.AbstractFactory.Factories
{
    internal class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new ReggianoCheese();
        public Clams CreateClams() => new FreshClams();
        public Dough CreateDough() => new ThinCrustDough();
        public Pepperoni CreatePepperoni() => new SlicedPepperoni();
        public Sauce CreateSauce() => new MarinaSauce();
        public List<Veggies> CreateVeggies() => new List<Veggies> { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
    }
}
