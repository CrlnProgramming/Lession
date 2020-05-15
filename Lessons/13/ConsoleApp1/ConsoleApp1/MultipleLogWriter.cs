using Microsoft.VisualBasic;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ConsoleApp1
{
    class MultipleLogWriter : AbstractClass
    {
        private string _nameFile = "file.txt";

        public MultipleLogWriter(ILogerWriter[]collectrion) :base()
        {
        }

        public override void WriteErrorType(string ErrorType)
        {
            Console.WriteLine(ErrorType);
            File.AppendAllText(_nameFile, ErrorType);
        }

    }
}
