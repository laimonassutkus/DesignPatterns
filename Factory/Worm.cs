using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    class Worm : Animal
    {
        public override string GetAnimalKingdom()
        {
            return "Animalia";
        }

        public override bool HasLegs()
        {
            return false;
        }
    }
}
