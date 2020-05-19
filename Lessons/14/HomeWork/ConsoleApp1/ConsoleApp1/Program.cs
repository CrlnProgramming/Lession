using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleLogWriter.Intance.WriteErrorType("Error Massage");
            ConsoleLogWriter.Intance.WriteErrorType("Info Massage");
            ConsoleLogWriter.Intance.WriteErrorType("Warning Massage");

            FileLogWriter.Intance.WriteErrorType("Error Massage");
            FileLogWriter.Intance.WriteErrorType("Info Massage");
            FileLogWriter.Intance.WriteErrorType("Warning Massage");

            MultipleLogWriter.Intance.WriteErrorType("Error Massage");
            MultipleLogWriter.Intance.WriteErrorType("Info Massage");
            MultipleLogWriter.Intance.WriteErrorType("Warning Massage");

        }
    }
}
