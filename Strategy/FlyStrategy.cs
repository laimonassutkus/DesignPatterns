using System;

namespace Strategy
{
    interface IFlyStrategy
    {
        void Flys();
    }

    class CanNotFly : IFlyStrategy
    {
        public void Flys()
        {
            Console.WriteLine("I just can't fly.");
        }
    }

    class CanFly : IFlyStrategy
    {
        public void Flys()
        {
            Console.WriteLine("I fly so up high.");
        }
    }

    class UndefinedFly : IFlyStrategy
    {
        public void Flys()
        {
            Console.WriteLine("This is an undefined behaviour");
        }
    }
}
