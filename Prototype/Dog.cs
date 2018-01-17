using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    class Dog : IAnimal
    {
        
        public Dog(string name)
        {
            Name = name;
        }

        private string Name { get; }

        public IAnimal Clone()
        {
            return new Dog(Name);
        }

        public string GetAnimalName()
        {
            return Name;
        }
    }
}
