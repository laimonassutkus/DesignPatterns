using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            List<IntrinsicState> intrinsicStates = new List<IntrinsicState>()
            {
                new IntrinsicState(1),
                new IntrinsicState(2),
                new IntrinsicState(3),
                new IntrinsicState(4)
            };

            Stopwatch stopWatch = new Stopwatch();

            for (int i = 0; i < 1000; i++)
            {
                stopWatch.Start();
                FlyWeightFactory.GetFlyweight(GetState(intrinsicStates));
                stopWatch.Stop();
            }

            TimeSpan flyweightTime = stopWatch.Elapsed;

            for (int i = 0; i < 1000; i++)
            {
                stopWatch.Start();
                new Flyweight() { EState = new ExtrinsicState(1), IState = new IntrinsicState(1) };
                stopWatch.Stop();
            }

            TimeSpan noFlyweightTime = stopWatch.Elapsed;

            Console.WriteLine($"Not using flyweight: {noFlyweightTime};\nWith flyweight: {flyweightTime}.");
        }

        public static IntrinsicState GetState(List<IntrinsicState> intrinsicStates)
        {
            Random rnd = new Random();
            return intrinsicStates[rnd.Next(0, intrinsicStates.Count)];
        }
    }
}
