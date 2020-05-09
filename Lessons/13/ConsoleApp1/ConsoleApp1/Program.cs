using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var thisDate = DateTimeOffset.Now;
            
            Console.WriteLine("Write ur massage: ");
            var mas = Console.ReadLine();
            var consoleLogWriter = new ConsoleLogWriter(thisDate,mas);
            var fileLogWriter = new FileLogWriter(thisDate, mas);
            var multipleLogWriter = new MultipleLogWriter(thisDate, mas);

            consoleLogWriter.LogError(mas, thisDate);
            consoleLogWriter.LogWarning(mas, thisDate);
            consoleLogWriter.LogInfo(mas, thisDate);

            fileLogWriter.LogError(mas, thisDate);
            fileLogWriter.LogWarning(mas, thisDate);
            fileLogWriter.LogInfo(mas, thisDate);

            multipleLogWriter.LogError(mas, thisDate);
            multipleLogWriter.LogWarning(mas, thisDate);
            multipleLogWriter.LogInfo(mas, thisDate);



        }
    }
}
