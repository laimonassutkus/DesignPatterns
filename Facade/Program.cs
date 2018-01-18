using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Facade facade = new Facade();

            Console.WriteLine("Using the facade to do stuff...");
            facade.DoSomeOtherStuff();
        }
    }
}
