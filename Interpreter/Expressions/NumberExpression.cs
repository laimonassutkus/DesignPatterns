using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Expressions
{
    class NumberExpression : IExpression
    {
        private readonly string number;

        public NumberExpression(string number)
        {
            this.number = number;
        }

        public int Interpret()
        {
            return int.Parse(number);
        }
    }
}
