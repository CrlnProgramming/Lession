using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogWriter.Intance.LogError("Error Massage");
            ConsoleLogWriter.Intance.LogInfo("Info Massage");
            ConsoleLogWriter.Intance.LogWarning("Warning Massage");

            FileLogWriter.Intance.LogError("Error Massage");
            FileLogWriter.Intance.LogInfo("Info Massage");
            FileLogWriter.Intance.LogWarning("Warning Massage");

            MultipleLogWriter.Intance.LogError("Error Massage");
            MultipleLogWriter.Intance.LogInfo("Info Massage");
            MultipleLogWriter.Intance.LogWarning("Warning Massage");

        }
    }
}
