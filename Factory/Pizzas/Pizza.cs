namespace Factory.Pizzas
{
    internal class Pizza
    {
        internal void Bake() => Console.WriteLine("Pizza baking");
        internal void Box() => Console.WriteLine("Pizza boxed");
        internal void Cut() => Console.WriteLine("Pizza cut");
        internal void Prepare() => Console.WriteLine("Pizza prepared");
    }
}
