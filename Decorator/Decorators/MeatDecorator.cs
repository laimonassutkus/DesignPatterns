using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    class MeatDecorator : IPizza
    {
        private readonly IPizza pizza;

        public MeatDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public string GetIngredients()
        {
            return pizza.GetIngredients() + " salami";
        }

        public float GetPrice()
        {
            return pizza.GetPrice() + 0.75f;
        }
    }
}
