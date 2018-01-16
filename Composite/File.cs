using System;
using System.Collections.Generic;
using System.Text;

namespace Composite
{
    class File : FileSystemComponent
    {
        private readonly string name;

        public File(string name)
        {
            this.name = name;
        }

        public override string GetName()
        {
            return name; 
        }

        public override void Display()
        {
            Console.WriteLine(GetName());
        }
    }
}
