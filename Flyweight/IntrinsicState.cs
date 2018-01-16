using System;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
    class IntrinsicState
    {
        public IntrinsicState(int state)
        {
            State = state;
        }

        public int State { get; }
    }
}
