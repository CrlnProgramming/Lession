using System;
using System.IO;

namespace ConsoleApp1
{
    class MultipleLogWriter : AbstractClass
    {
        private static readonly Lazy<MultipleLogWriter> _intance = new Lazy<MultipleLogWriter>(() => new MultipleLogWriter(),
            System.Threading.LazyThreadSafetyMode.ExecutionAndPublication);

        public DateTimeOffset Date;
        private MultipleLogWriter()
        {
            Date = DateTimeOffset.UtcNow;
        }

        public override void LogInfo(string massage)
        {
            File.AppendAllText("file.txt", $"{Date} \t LogInfo \t {massage}");
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogInfo \t {massage}\n";
            Console.WriteLine(MessageType);
        }

        public override void LogWarning(string massage)
        {
            File.AppendAllText("file.txt", $"{Date} \t LogWarning \t {massage}");
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogWarning \t {massage}\n";
            Console.WriteLine(MessageType);
        }

        public override void LogError(string massage)
        {
            File.AppendAllText("file.txt", $"{Date} \t LogError \t {massage}");
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogError \t {massage}\n";
            Console.WriteLine(MessageType);
        }
        public static MultipleLogWriter Intance
        {
            get { return _intance.Value; }
        }
    }
}
