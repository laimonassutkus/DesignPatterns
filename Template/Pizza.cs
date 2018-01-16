using System;
using System.Collections.Generic;

namespace Template
{
    class Pizza
    {
        List<string> ingredients = new List<string>();

        public void ServeAndDisplay()
        {
            Console.WriteLine(String.Join(",", ingredients));
        }
        public void AddIngredient(string ingredient)
        {
            ingredients.Add(ingredient);
        }
    }
}
