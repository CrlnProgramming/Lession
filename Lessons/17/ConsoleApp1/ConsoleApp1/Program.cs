using System;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassGen classGen = new ClassGen();
            classGen.GetArray += 
            
        }
        public static void FileWrite(object sender, DataGanerateEventArgs dataGanerateEventArgs)
        {
            foreach (var item in dataGanerateEventArgs)
            {
                File.WriteAllText()
            }
        }
        
    }
}
