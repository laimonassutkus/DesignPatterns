using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    abstract class AbstractElement
    {
        public void Display()
        {
            Console.WriteLine("Hi. I am element.");
        }
    }
}
