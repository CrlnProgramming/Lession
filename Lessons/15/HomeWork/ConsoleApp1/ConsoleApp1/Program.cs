using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            var consoleLoger = LogWriterFactory.Instance.GetLogerWriter<ConsoleLogWriter>(" ");
            var textLoger = LogWriterFactory.Instance.GetLogerWriter<ConsoleLogWriter>("FileLoger.txt");
            var multilog = LogWriterFactory.Instance.GetLogerWriter<MultipleLogWriter>(new[] { textLoger, consoleLoger });

            consoleLoger.LogError("Some Error massage");
            textLoger.LogWarning("Some Warnig massage");
            multilog.LogInfo("Some Info massage");
        }
    }
}
