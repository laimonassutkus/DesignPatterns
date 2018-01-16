using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<IntrinsicState> extrinsicStates = new List<IntrinsicState>()
            {
                new IntrinsicState(1),
                new IntrinsicState(2),
                new IntrinsicState(3),
                new IntrinsicState(4)
            };


            for (int i = 0; i < 1000000; i++)
            {
                FlyWeightFactory.GetFlyweight(GetState());
            }
        }

        public static IntrinsicState GetState()
        {
            Random rnd = new Random();
            return new IntrinsicState(rnd.Next(1, 5));
        }
    }
}
