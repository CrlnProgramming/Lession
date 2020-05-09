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

    
}
