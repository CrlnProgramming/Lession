using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var errorList = new ErrorList("Program Error",new string[] { "xth","fdsf","sdfsf"}))
            {
                //errorList.Add("new error");
                foreach (var i in errorList)
                {
                    Console.WriteLine(i);
                }
                //errorList.Dispose;
            } 
           
            
            


        }
    }
}
