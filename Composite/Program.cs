using System;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            FileSystemComponent folder = new Folder("Some folder.");
            folder.AddComponent(new File("Some file"));
            folder.AddComponent(new File("Some file"));
            folder.AddComponent(new File("Some file"));
            folder.AddComponent(new Folder("Some other folder"));

            folder.Display(); 
        }
    }
}
