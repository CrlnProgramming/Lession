using System;
using System.Collections.Generic;
using System.Text;

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
        public AbstractClass()
        {
        }

        public abstract void LogInfo(string massage);
        public abstract void LogWarning(string massage);
        public abstract void LogError(string massage);


    }
}
