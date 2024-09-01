using Factory.AbstractFactory.Ingredeints;

namespace Factory.AbstractFactory.Factories
{
    internal class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese() => new MozarellaCheese();
        public Clams CreateClams() => new FrozenClams();
        public Dough CreateDough() => new ThickCrustDough();
        public Pepperoni CreatePepperoni() => new SlicedPepperoni();
        public Sauce CreateSauce() => new PlumTomatoSauce();
        public List<Veggies> CreateVeggies() => new List<Veggies> { new BlackOlives(), new Spinach(), new EggPlant() };
    }
}
