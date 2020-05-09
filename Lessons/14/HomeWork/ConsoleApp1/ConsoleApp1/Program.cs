using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogWriter._intence.Value.LogError("Error Massage");
            ConsoleLogWriter._intence.Value.LogInfo("Info Massage");
            ConsoleLogWriter._intence.Value.LogWarning("Warning Massage");

            FileLogWriter.Intence1.LogError("Error Massage");
            FileLogWriter.Intence1.LogInfo("Info Massage");
            FileLogWriter.Intence1.LogWarning("Warning Massage");

        }
    }
}
