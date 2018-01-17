using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IAnimal dog = new Dog("Big boy");
            IAnimal second_dog = dog.Clone();

            Console.WriteLine($"I am {dog.GetAnimalName()} !!!");
            Console.WriteLine($"I am {second_dog.GetAnimalName()} too !!!");
        }
    }
}
