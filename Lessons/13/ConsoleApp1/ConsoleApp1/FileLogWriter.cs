using System;
using System.IO;

namespace ConsoleApp1
{
    class FileLogWriter : AbstractClass
    {
        public DateTimeOffset Date;
        public FileLogWriter() 
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
    }
}
