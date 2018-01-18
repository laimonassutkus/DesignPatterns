using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Products;

namespace Visitor
{
    interface IVisitor
    {
        float Visit(Apple apple);
        float Visit(Banana banana);
    }
}
