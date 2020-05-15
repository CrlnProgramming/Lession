using System;
using System.IO;

namespace ConsoleApp1
{
    class FileLogWriter : AbstractClass
    {
        private static readonly Lazy<FileLogWriter> _intance = new Lazy<FileLogWriter>(() => new FileLogWriter());

        public DateTimeOffset Date;
        private FileLogWriter()
        {
            Date = DateTimeOffset.UtcNow;
        }

        public override void LogInfo(string massage)
        {
            File.AppendAllText("file.txt", $"{Date:yyyy:MM:ddThh:mm:ss} \t LogInfo \t {massage}");
        }

        public override void LogWarning(string massage)
        {
            File.AppendAllText("file.txt", $"{Date:yyyy:MM:ddThh:mm:ss} \t LogWarning \t {massage}");
        }

        public override void LogError(string massage)
        {
            File.AppendAllText("file.txt", $"{Date:yyyy:MM:ddThh:mm:ss} \t LogError \t {massage}");
        }
        public static FileLogWriter Intance
        {
            get { return _intance.Value; }
        }
    }
}
