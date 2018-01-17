using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator
{
    class PlainPizza : IPizza
    {
        public string GetIngredients()
        {
            return "pizza padding";
        }

        public float GetPrice()
        {
            return 1.0f;
        }
    }
}
