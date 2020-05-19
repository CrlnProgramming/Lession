using System;
using System.IO;

namespace ConsoleApp1
{
    class MultipleLogWriter : AbstractClass
    {
        private static readonly Lazy<MultipleLogWriter> _intance = new Lazy<MultipleLogWriter>(() => new MultipleLogWriter(),
            System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
        private string _nameFile;
        private MultipleLogWriter()
        {
        }

        public override void WriteErrorType(string ErrorType)
        {
            Console.WriteLine(ErrorType);
            File.AppendAllText(_nameFile, ErrorType);
        }

        public static MultipleLogWriter Intance
        {
            get { return _intance.Value; }
        }
    }
}
