using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class ConsoleLogWriter : AbstractClass
    {
        public ConsoleLogWriter()
        {
        }

        public override void WriteErrorType(string ErrorType)
        {
            Console.WriteLine(ErrorType);
        }

    }
}
