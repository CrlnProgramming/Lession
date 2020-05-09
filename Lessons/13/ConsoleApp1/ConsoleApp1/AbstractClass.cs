using System;


namespace ConsoleApp1
{
    interface ILogerWriter
    {
        public DateTimeOffset Date { get; set; }
        public string Massage { get; set; }
        void LogInfo(string massage, DateTimeOffset date);
        void LogWarning(string massage, DateTimeOffset date);
        void LogError(string massage, DateTimeOffset date);
        
    }

    abstract class AbstractClass : ILogerWriter
    {
        public DateTimeOffset Date { get; set; } = DateTimeOffset.UtcNow;
        public string Massage { get; set; }
        public AbstractClass(DateTimeOffset date)
        {
            Date = date;
        }


        public abstract void LogInfo(string massage, DateTimeOffset date);
        public abstract void LogWarning(string massage, DateTimeOffset date);
        public abstract void LogError(string massage, DateTimeOffset date);


    }
}
