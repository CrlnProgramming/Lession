using System;


namespace ConsoleApp1
{
    class ConsoleLogWriter : AbstractClass
    {
        private static readonly Lazy<ConsoleLogWriter> _intance = new Lazy<ConsoleLogWriter>(() => new ConsoleLogWriter(),
            System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);

        private ConsoleLogWriter()
        {
        }

        public override void WriteErrorType(string ErrorType)
        {
            Console.WriteLine(ErrorType);
        }

        public static ConsoleLogWriter Intance
        {
            get { return _intance.Value; }
        }

    }

    
}
