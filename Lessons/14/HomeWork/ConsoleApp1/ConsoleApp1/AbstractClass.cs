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
        private string ErrorType;
        public AbstractClass()
        {
        }

        public abstract void WriteErrorType(string ErrorType);

        public virtual void LogInfo(string massage)
        {
            ErrorType = $"{DateTimeOffset.Now:yyyy:MM:ddThh:mm:ss} \t LogInfo \t {massage}\n";
            WriteErrorType(ErrorType);
        }

        public virtual void LogWarning(string massage)
        {
            ErrorType = $"{DateTimeOffset.Now:yyyy:MM:ddThh:mm:ss} \t LogWarning \t {massage}\n";
            WriteErrorType(ErrorType);
        }
        public virtual void LogError(string massage)
        {
            ErrorType = $"{DateTimeOffset.Now:yyyy:MM:ddThh:mm:ss} \t LogError \t {massage}\n";
            WriteErrorType(ErrorType);
        }


    }
}
