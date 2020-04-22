using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Person
    {
        static string name;

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value == null)
                {
                    Console.WriteLine("Error!");
                }
                else
                    value = name;
            }
        }
        

           
        

    }

}
