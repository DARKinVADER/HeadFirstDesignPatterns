namespace Factory.Pizzas
{
    internal class Pizza
    {
        public string Name { get; init; } = "Pizza";
        protected string Dough;
        protected string Sauce;
        protected List<string> Toppings = new();

        internal virtual void Bake() => Console.WriteLine("Bake for 25 minutes at 350");
        internal virtual void Box() => Console.WriteLine("Place pizza in official PizzaStore box");
        internal virtual void Cut() => Console.WriteLine("Cutting the pizza into diagonal slices");
        internal virtual void Prepare()
        {
            Console.WriteLine($"Preparing {Name}");
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings:");
            foreach (var item in Toppings)
            {
                Console.WriteLine($"   {item}");
            }
        }
    }
}
