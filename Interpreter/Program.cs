using System;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            try
            {
                IExpression interpreter = new Interpreter("5 SUM 5");
                int ans = interpreter.Interpret();

                Console.WriteLine(ans);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            try
            {
                IExpression interpreter = new Interpreter("BLA BLA BLA");
                int ans = interpreter.Interpret();
                Console.WriteLine(ans);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
