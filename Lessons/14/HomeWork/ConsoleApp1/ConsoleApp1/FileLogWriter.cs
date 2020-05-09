using System;
using System.IO;

namespace ConsoleApp1
{
    class FileLogWriter : ILogerWriter
    {
        public string Massage { get; set; }
        public DateTimeOffset Date { get; set; }
        private static readonly Lazy<FileLogWriter> _intence1 = new Lazy<FileLogWriter>(() => new FileLogWriter());
        private FileLogWriter()
        {

        }
        
        public void LogInfo(string massage)
        {
            Massage = massage;
            File.AppendAllText("file.txt", $"{Date} \t LogInfo \t {massage}");
        }

        public void LogWarning(string massage)
        {
            Massage = massage;
            File.AppendAllText("file.txt", $"{Date} \t LogWarning \t {massage}");
        }

        public void LogError(string massage)
        {
            Massage = massage;
            File.AppendAllText("file.txt", $"{Date} \t LogError \t {massage}");
        }
        public static FileLogWriter Intence1
        {
            get { return _intence1.Value; }
        }
    }
}
