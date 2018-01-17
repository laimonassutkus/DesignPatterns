using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    class CheeseDecorator : IPizza
    {
        private readonly IPizza pizza;

        public CheeseDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public string GetIngredients()
        {
            return pizza.GetIngredients() + " some cheese";
        }

        public float GetPrice()
        {
            return pizza.GetPrice() + 1.25f;
        }
    }
}
