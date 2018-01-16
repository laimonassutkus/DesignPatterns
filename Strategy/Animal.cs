using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    class Animal
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public IFlyStrategy FlyStrategy { get; set; }

        public Animal(IFlyStrategy strategy)
        {
            FlyStrategy = strategy;
        }
    }
}
