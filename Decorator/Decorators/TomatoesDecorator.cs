using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Decorators
{
    class TomatoesDecorator : IPizza
    {
        private readonly IPizza pizza;

        public TomatoesDecorator(IPizza pizza)
        {
            this.pizza = pizza;
        }

        public string GetIngredients()
        {
            return pizza.GetIngredients() + " sliced tomatoes";
        }

        public float GetPrice()
        {
            return pizza.GetPrice() + 0.5f;
        }
    }
}
