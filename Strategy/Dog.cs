using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Dog : Animal
    {
        public Dog(IFlyStrategy strategy) : base(strategy)
        {
        }
    }
}
