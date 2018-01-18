using System;
using Visitor.Products;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            IVisitor taxVisitor = new TaxVisitor();
            IVisitor reliefVisitor = new ReliefVisitor();

            IVisitable apple = new Apple();

            Console.WriteLine($"Apple price before tax: {apple.GetPrice()}, " +
                $"apple price after the tax: {apple.Accept(taxVisitor)}.");

            Console.WriteLine($"Apple price before relief: {apple.GetPrice()}, " +
                $"apple price after the relief: {apple.Accept(reliefVisitor)}.");
        }
    }
}
