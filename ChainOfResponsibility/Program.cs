using ChainOfResponsibility.Chains;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            AbstractChain doubleChain = new DoubleParser();
            AbstractChain intChain = new IntParser();
            AbstractChain nullChain = new Null();

            doubleChain.SetNextChaing(intChain);
            intChain.SetNextChaing(nullChain);

            doubleChain.Parse("ABC");
            doubleChain.Parse("1");
            doubleChain.Parse("1.5");
        }
    }
}
