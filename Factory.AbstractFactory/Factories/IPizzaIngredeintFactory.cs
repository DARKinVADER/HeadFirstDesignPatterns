using Factory.AbstractFactory.Ingredeints;

namespace Factory.AbstractFactory.Factories
{
    internal interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        List<Veggies> CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}
