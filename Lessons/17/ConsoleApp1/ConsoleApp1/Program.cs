using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        private static void Main(string[] args)
        {
            Gentrator gentrator = new Gentrator();

            gentrator.DataGeneratedEvArgsArray += FileWriter;
            gentrator.RandomDateGenerator(10);
            
        }
        private static void FileWriter(object sender,DateGeneratorEventArgs dateGeneratorEventArgs)
        {
            foreach (var item in dateGeneratorEventArgs.array)
            {
                File.AppendAllText("file.txt", item.ToString());
            }
        }


    }
}
