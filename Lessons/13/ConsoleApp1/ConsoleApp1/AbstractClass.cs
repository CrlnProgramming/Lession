using System;


namespace ConsoleApp1
{
    interface ILogerWriter
    {
        void LogInfo(string massage);
        void LogWarning(string massage);
        void LogError(string massage);
        
    }

    abstract class AbstractClass : ILogerWriter
    {
        public DateTimeOffset Date { get; set; } 
        public AbstractClass()
        {
            Date = DateTimeOffset.UtcNow;
        }

        public abstract void LogInfo(string massage);
        public abstract void LogWarning(string massage);
        public abstract void LogError(string massage);


    }
}
