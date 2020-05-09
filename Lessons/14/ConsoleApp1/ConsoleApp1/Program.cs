using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var errorList = new ErrorList("Warning", new List<string> { "asd", "sadsa", "fdsf" }))
            {
                errorList.Add("New Erorr: '404'");

                foreach (var i in errorList)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
