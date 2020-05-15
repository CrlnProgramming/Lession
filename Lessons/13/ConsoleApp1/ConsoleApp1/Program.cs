using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleLogWriter = new ConsoleLogWriter();
            var fileLogWriter = new FileLogWriter();
            var multipleLogWriter = new MultipleLogWriter(new ILogerWriter[] { consoleLogWriter,fileLogWriter});

            consoleLogWriter.LogInfo("LogInfo");
            consoleLogWriter.LogWarning("LogWarning");
            consoleLogWriter.LogError("LogError");
            
            fileLogWriter.LogInfo("LogInfo");
            fileLogWriter.LogWarning("LogWarning");
            fileLogWriter.LogError("LogError");


        }
    }
}
