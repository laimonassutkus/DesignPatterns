using System;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IPizzaCreator veganPizzaCreator = new VeganPizza();
            Pizza veganPizza = veganPizzaCreator.MakePizza();

            veganPizza.ServeAndDisplay();
        }
    }
}
