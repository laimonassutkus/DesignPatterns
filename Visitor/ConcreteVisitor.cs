using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    class ConcreteVisitor : IVisitor
    {
        public void Visit(Element1 element)
        {
            Console.WriteLine("Visited element 1");
            element.Display();
        }

        public void Visit(Element2 element)
        {
            Console.WriteLine("Visited element 2");
            element.Display();
        }
    }
}
