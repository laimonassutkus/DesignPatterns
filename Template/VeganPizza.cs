using System;
using System.Collections.Generic;
using System.Text;

namespace Template
{
    class VeganPizza : AbstractPizzaTemplate
    {
        public override bool WantsCheese()
        {
            return false;
        }

        public override bool WantsMeat()
        {
            return false;
        }

        public override string AddCheeseHook()
        {
            return null;
        }

        public override string AddKetchupHook()
        {
            return "Hot ketchup";
        }

        public override string AddMeatHook()
        {
            return null;
        }
    }
}
