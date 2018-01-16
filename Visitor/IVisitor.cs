using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IVisitor
    {
        void Visit(Element1 element);
        void Visit(Element2 element);
    }
}
