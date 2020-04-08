using System;

namespace ConsoleClasswork
{
    enum Colors
    {
        Black,Blue,Cyan,Greay,Green,Magenta,Red,White,Yellow
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите цвет");
            var line = Console.ReadLine();
            var value = Enum.Parse(typeof(Colors),line);
            Console.WriteLine(value);
            Console.WriteLine((int)value);
            Console.WriteLine(string.Join("," new ArrY[] { 1, 2, 3 }));

          
           
            Console.ReadLine();
        }
    }
}










/*
double S1, S2, a2, V, Hn, h2, q;
Console.Write("Введите a");
            double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите h");
            double h = Convert.ToDouble(Console.ReadLine());

S1 = 3 * a * h;
S2 = (3.0/2.0)* ((a* (a* Math.Sqrt(3) + 2 * h)));
            a2 = Math.Pow(a, 2);
            h2 = Math.Pow(h, 2);
            Hn = Math.Sqrt(h2 - a2)/12.0;
            q = Math.Sqrt(3);
            V = (a2 / 2) * Hn * q;
Console.WriteLine(S1);
            Console.WriteLine(S2);
            Console.WriteLine(V); 
            */
            