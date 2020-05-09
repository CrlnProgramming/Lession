using System;


namespace ConsoleApp1
{
    class ConsoleLogWriter : AbstractClass
    {
        public ConsoleLogWriter():base()
        {

        }

        public override void LogInfo(string massage)
        {
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogInfo \t {massage}\n";
            Console.WriteLine(MessageType);
        }

        public override void LogWarning(string massage)
        {
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogWarning \t {massage}\n";
            Console.WriteLine(MessageType);
        }

        public override void LogError(string massage)
        {
            var MessageType = $"{Date:yyyy:MM:ddThh:mm:ss} \t LogError \t {massage}\n";
            Console.WriteLine(MessageType);
        }
    }
}
