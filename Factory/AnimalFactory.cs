using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class AnimalFactory
    {
        public static Animal MakeAnimal(bool hasLegs)
        {
            if (hasLegs)
            {
                return new Dog();
            }

            return new Worm();
        }
    }
}
