using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class ConsoleLogWriter : AbstractClass
    {
        public ConsoleLogWriter(DateTimeOffset date,string massage) : base(date) {Massage = massage;}

        public override void LogInfo(string massage, DateTimeOffset date) => Console.WriteLine($"{date} \t LogInfo \t {massage}");

        public override void LogWarning(string massage, DateTimeOffset date) => Console.WriteLine($"{date} \t LogWarning \t {massage}");
        public override void LogError(string massage, DateTimeOffset date) => Console.WriteLine($"{date} \t LogError \t {massage}");

    }
}
