using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Products;

namespace Visitor
{
    class ReliefVisitor : IVisitor
    {
        public float Visit(Apple apple)
        {
            return apple.GetPrice() - 0.1f;
        }

        public float Visit(Banana banana)
        {
            return banana.GetPrice() - 0.2f;
        }
    }
}
