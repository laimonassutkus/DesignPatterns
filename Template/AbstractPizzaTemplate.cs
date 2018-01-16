using System;

namespace Template
{
    abstract class AbstractPizzaTemplate : IPizzaCreator
    {
        Pizza pizza = new Pizza();

        public Pizza MakePizza()
        {
            AddBase();

            if (WantsMeat())
                pizza.AddIngredient(AddMeatHook());

            if (WantsCheese())
                pizza.AddIngredient(AddCheeseHook());

            if (WantsKetchup())
                pizza.AddIngredient(AddKetchupHook());

            Cook();

            Pizza donePizza = pizza;

            pizza = new Pizza();

            return donePizza;
        }

        public virtual bool WantsMeat()
        {
            return true;
        }

        public virtual bool WantsCheese()
        {
            return true;
        }

        public virtual bool WantsKetchup()
        {
            return true;
        }

        public void AddBase()
        {
            pizza.AddIngredient("Base");
        }

        public abstract string AddMeatHook();
        public abstract string AddCheeseHook();
        public abstract string AddKetchupHook();

        public void Cook()
        {
            Console.WriteLine("Cooking pizza...");
            Console.WriteLine("Done!");
        }
    }
}
