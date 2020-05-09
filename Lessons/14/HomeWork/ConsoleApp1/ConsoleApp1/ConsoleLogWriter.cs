using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ConsoleLogWriter : ILogerWriter
    {
        public static readonly Lazy<ConsoleLogWriter> _intence = new Lazy<ConsoleLogWriter>(() => new ConsoleLogWriter(),
            System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);
        public string Massage { get; set; }
        public DateTimeOffset Date { get; set; } = DateTimeOffset.UtcNow;

        private ConsoleLogWriter() 
        {
            
        }

        public static ConsoleLogWriter Intence
        {
            get { return _intence.Value;}
        }

        public void LogInfo(string massage)
        {
            Massage = massage;
            Console.WriteLine($"{Date} \t LogInfo \t {massage}");
        }

        public void LogWarning(string massage)
        {
            Massage = massage;
            Console.WriteLine($"{Date} \t LogWarning \t {massage}");
        }

        public void LogError(string massage)
        {
            Massage = massage;
            Console.WriteLine( $"{Date} \t LogError \t {massage}");
        }

    }

    
}
