using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter.Expressions
{
    class DivideExpression : IExpression
    {
        private readonly IExpression lhs;
        private readonly IExpression rhs;

        public DivideExpression(IExpression lhs, IExpression rhs)
        {
            this.lhs = lhs;
            this.rhs = rhs;
        }

        public int Interpret()
        {
            return lhs.Interpret() / rhs.Interpret();
        }
    }
}
