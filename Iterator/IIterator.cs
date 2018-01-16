using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    interface IIterator<T>
    {
        bool HasNext();
        void Next();
        T Current();
    }
}
