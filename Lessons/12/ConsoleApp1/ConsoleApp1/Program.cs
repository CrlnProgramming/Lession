using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var doc = new BaseDocument("UT-2045-BG", "OtheDocument");
            doc.WriteToConsel();

            var pas = new Passport("6554332322");

            pas.WriteToConsole();


            
        }
    }
}
