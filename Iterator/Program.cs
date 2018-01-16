using System;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            ListIterator<string> listIterator = new ListIterator<string>();
            listIterator.Add("Heyyy");
            listIterator.Add("Yoooo");
            listIterator.Add("Hiiii");

            IterateStrings(listIterator);
        }

        public static void IterateStrings(IIterator<string> iterable)
        {
            while (iterable.HasNext())
            {
                Console.WriteLine(iterable.Current() + "\n");
                iterable.Next();
            }
        }
    }
}
