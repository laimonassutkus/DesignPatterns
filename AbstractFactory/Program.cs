using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IAircraftFactory aircraftFactory = new CivilMilitaryAircraftFactory();

            var cheapOne = aircraftFactory.MakeSlowAndCheap();
            var expensiveOne = aircraftFactory.MakeFastAndExpensive();

            Console.WriteLine($"Expensive one costs: { expensiveOne.GetPrice() }");
        }
    }
}
