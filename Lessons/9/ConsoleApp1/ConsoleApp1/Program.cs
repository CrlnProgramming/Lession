using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            //ValBrackets->ValidBrackets
            var program = new ProgramWork();
            Console.WriteLine(ValBrackets("[]()"));
            Console.WriteLine(ValBrackets("[)[]"));
            Console.WriteLine(ValBrackets("[)[]"));
            Console.WriteLine(ValBrackets("[[] ()]"));
            Console.WriteLine(ValBrackets("([([])])"));
            Console.WriteLine();
            Console.WriteLine(ValBrackets("("));
             Console.WriteLine(ValBrackets("([][)"));
            Console.WriteLine(ValBrackets("[(])"));
             Console.WriteLine(ValBrackets("(()[]]"));
            Console.WriteLine(ValBrackets("([{}])"));
            Console.WriteLine(ValBrackets(")[{{])"));
            //classWork
            /*var a = double.Parse(Console.ReadLine());
            Console.WriteLine(ClassworkTheWordStop(a));
            */

            
        }

        static string ValBrackets(string str)
        {
            string OpenBrackets = "([{";
            string CloseBrackets = ")]}";

            Dictionary<char, char> di = new Dictionary<char, char>();
            di.Add('(', ')');
            di.Add('[', ']');
            di.Add('{', '}');

            Stack<char> st = new Stack<char>();

            for (int i = 0; i < str.Length; i++)
            {
                if (OpenBrackets.Contains(str[i]))
                    st.Push(str[i]);
                else
                {
                    if(CloseBrackets.Contains(str[i]))
                        if(st.Count == 0)
                        {
                            return "NO";
                        }
                        else
                        {
                            var size = st.Pop();
                            if (di[size] == str[i])
                            {
                                continue;
                            }
                            return "NO";
                        }
                }
            }
            return st.Count > 0 ? "NO" : "YES";
        }

        


        /*static double ClassworkTheWordStop(double a)
        {
            double summ = 0.0;
            var list = new List<double>();
            while (true)
            {
                var numbers = Console.ReadLine();
                if (numbers == "stop")
                {
                    break;
                }
                try
                {
                    list.Add(double.Parse(numbers));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Erorr!FormatExaptuon");
                    throw;
                }
                if (numbers == null)
                {
                    Console.WriteLine("Erorr!String is null!\n" +
                        "Lets try again!");
                }
            }
            foreach (var v in list)
                summ += v;
            a = summ / list.Count;
            return a;
        }
       */

    }
}

namespace ConsoleApp1
{
    class ProgramWork
    {

        public bool ValidBrackets(string input)
        { 
            var builder = new StringBuilder(input);

            while (builder.Length>0)
            {
                var old = builder.Length;

                builder.Replace("()", "")
                    .Replace("[]", "");
                
                if(old == builder.Length)
                {
                    return false;
                }
            }
            return true;
        }
        

    }



}