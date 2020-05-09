using System;
using System.IO;

namespace ConsoleApp1
{
    class FileLogWriter : AbstractClass
    {
        public FileLogWriter(DateTimeOffset date, string massage) : base(date) { Massage = massage; }

        public override void LogInfo(string massage, DateTimeOffset date) => File.AppendAllText("file.txt", $"{date} \t LogInfo \t {massage}");
        public override void LogWarning(string massage, DateTimeOffset date) => File.AppendAllText("file.txt", $"{date} \t LogWarning \t {massage}");

        public override void LogError(string massage, DateTimeOffset date) => File.AppendAllText("file.txt", $"{date} \t LogError \t {massage}");

    }
}
