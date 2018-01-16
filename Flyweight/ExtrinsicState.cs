using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class ExtrinsicState
    {
        public ExtrinsicState(int state)
        {
            State = state;
        }

        public int State { get; }
    }
}
