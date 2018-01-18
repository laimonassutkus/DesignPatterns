using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor
{
    interface IVisitable : IProduct
    {
        float Accept(IVisitor visitor);
    }
}
