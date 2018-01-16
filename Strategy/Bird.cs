using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Bird : Animal
    {
        public Bird(IFlyStrategy strategy) : base(strategy)
        {
        }
    }
}
