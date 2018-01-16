using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");


            IVisitor visitor = new ConcreteVisitor();


            Element1 element = new Element1();
            element.Display();

            visitor.Visit(element);
        }
    }
}
