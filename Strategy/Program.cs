using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Dog dog = new Dog(new CanNotFly());
            Bird bird = new Bird(new CanFly());

            dog.FlyStrategy.Flys();
            bird.FlyStrategy.Flys();
        }
    }
}
