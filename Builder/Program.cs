using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            PhoneFactory phoneFactory = new PhoneFactory();

            var cheapAndGood = phoneFactory.GetGoodAndRelaiblePhone();
            var expensiveAndMeh = phoneFactory.GetExpensiveAndShittyPhone();

            Console.WriteLine(
                $"Cheap and Good phone specs: " +
                $"{cheapAndGood.GetCpu().Type}, " +
                $"{cheapAndGood.GetGpu().Type}, " +
                $"{cheapAndGood.GetRam().Type}, " +
                $"{cheapAndGood.GetScreen().Type}"
            );
        }
    }
}
