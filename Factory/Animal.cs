using System;
using System.Collections.Generic;
using System.Text;

namespace Factory
{
    abstract class Animal
    {
        public abstract string GetAnimalKingdom();

        public virtual bool HasLegs()
        {
            return true;
        }

        public void ShowLegs()
        {
            if (HasLegs())
                Console.WriteLine("I HAVE SOME FREAKIN NICE LEGS.");
            else
                Console.WriteLine("DAMN. I DONT HAVE ANY LEGS.");
        }
    }
}
