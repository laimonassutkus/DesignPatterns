using System;
using System.Collections.Generic;

namespace Composite
{
    class Folder : FileSystemComponent
    {
        List<FileSystemComponent> components = new List<FileSystemComponent>();

        private string name;

        public Folder(string folderName)
        {
            name = folderName;
        }

        public override void AddComponent(FileSystemComponent component)
        {
            components.Add(component);
        }

        public override string GetName()
        {
            return name;
        }

        public override FileSystemComponent GetComponent(int componentIndex)
        {
            return components[componentIndex];
        }

        public override void Display()
        {
            Console.WriteLine($"I am '{GetName()}' and my inner components are:");

            foreach (FileSystemComponent item in components)
            {
                Console.WriteLine(item.GetName());
            }
        }
    }
}
