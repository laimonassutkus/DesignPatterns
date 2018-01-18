using Interpreter.Expressions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interpreter
{
    class Interpreter : IExpression
    {
        private readonly string expression;

        public Interpreter(string expression)
        {
            this.expression = expression;
        }

        public int Interpret()
        {
            var expressions = expression.Split(' ');

            NumberExpression num1;
            NumberExpression num2;

            switch (expressions[1])
            {
                case "DIVIDE":
                    num1 = new NumberExpression(expressions[0]);
                    num2 = new NumberExpression(expressions[2]);

                    IExpression divideExpression = new DivideExpression(num1, num2);

                    return divideExpression.Interpret();
                case "SUM":
                    num1 = new NumberExpression(expressions[0]);
                    num2 = new NumberExpression(expressions[2]);

                    IExpression sumExpression = new AddExpression(num1, num2);

                    return sumExpression.Interpret();
                default:
                    throw new InvalidOperationException("Cant parse expression");
            }
        }
    }
}
