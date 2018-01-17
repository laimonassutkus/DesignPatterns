using System;
using System.Collections.Generic;
using System.Text;

namespace Prototype
{
    interface IAnimal : IPrototype<IAnimal>
    {
        string GetAnimalName();
    }
}
