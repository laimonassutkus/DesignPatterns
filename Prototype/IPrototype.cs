using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    interface IPrototype<T>
    {
        T Clone();
    }
}
