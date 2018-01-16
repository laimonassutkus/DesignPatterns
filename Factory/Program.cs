using System;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animalWithLegs = AnimalFactory.MakeAnimal(true);
            Animal animalWithoutLegs = AnimalFactory.MakeAnimal(false);

            animalWithLegs.ShowLegs();
            animalWithoutLegs.ShowLegs();
        }
    }
}
