using Decorator.Decorators;
using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPizza cheapPizza = new CheeseDecorator(new PlainPizza());
            IPizza richPizza = new CheeseDecorator(new MeatDecorator(new TomatoesDecorator(new PlainPizza())));

            Console.WriteLine($"Expensive pizza looks like this: {richPizza.GetIngredients()}.");
        }
    }
}
