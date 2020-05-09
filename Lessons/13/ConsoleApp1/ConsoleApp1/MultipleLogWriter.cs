using System;
using System.IO;

namespace ConsoleApp1
{
    class MultipleLogWriter : AbstractClass
    {
        public MultipleLogWriter() : base() 
        { 

        }

        public override void LogInfo(string massage)
        {
            File.AppendAllText("file.txt", $"{Date} \t LogInfo \t {massage}");
            Console.WriteLine($"{Date} \t LogInfo \t {massage}");
        }

        public override void LogWarning(string massage)
        {
            File.AppendAllText("file.txt", $"{Date} \t LogWarning \t {massage}");
            Console.WriteLine($"{Date} \t LogWarning \t {massage}");
        }

        public override void LogError(string massage)
        {
            File.AppendAllText("file.txt", $"{Date} \t LogError \t {massage}");
            Console.WriteLine($"{Date} \t LogError \t {massage}");
        }
    }
}
