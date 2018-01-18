using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Chains
{
    class DoubleParser : AbstractChain
    {
        public DoubleParser()
        {
        }

        public override void Parse(string number)
        {
            try
            {
                double doubleNumber = double.Parse(number);
                Console.WriteLine(doubleNumber);
            }
            catch (Exception)
            {
                nextChain.Parse(number);
            }
        }
    }
}
