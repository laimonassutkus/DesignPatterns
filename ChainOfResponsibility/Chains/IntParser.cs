using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibility.Chains
{
    class IntParser : AbstractChain
    {
        public override void Parse(string number)
        {
            try
            {
                double doubleNumber = int.Parse(number);
                Console.WriteLine(doubleNumber);
            }
            catch (Exception)
            {
                nextChain.Parse(number);
            }
        }
    }
}
