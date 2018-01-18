using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Products
{
    class Banana : IVisitable
    {
        public float Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }

        public float GetPrice()
        {
            return 1.0f;
        }
    }
}
