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
            var multipleLogWriter = new MultipleLogWriter();

            consoleLogWriter.LogError("massage");
            consoleLogWriter.LogWarning("massage");
            consoleLogWriter.LogInfo("massage");

            fileLogWriter.LogError("massage");
            fileLogWriter.LogWarning("massage");
            fileLogWriter.LogInfo("massage");

            multipleLogWriter.LogError("massage");
            multipleLogWriter.LogWarning("massage");
            multipleLogWriter.LogInfo("massage");
        }
    }
}
