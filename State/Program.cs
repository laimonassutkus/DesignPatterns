using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            CarContext context = new CarContext();

            context.Drive();
            context.IgniteEngine();
            context.Drive();
        }
    }
}
