using System;
//using Linq;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //System.Collections.Generic 
           
            
        }
    }
}


/*
var integers = new List<int>();
integers.Add(10);
            integers.Add(20);
            integers.Add(30);
            integers.Add(40);
            Console.WriteLine(string.Join(", ", integers));

            var strings = new List<string>
            {
                "one","two","three"
            };
integers.AddRange(new[]{50,60,70,80}

Console.WriteLine(integers.Count);

Console.WriteLine(list.IndexOf("30"));

var result = list.Remove("20");
            if (result)
            {
                Console.WriteLine("Item remove");
            }
            else
                Console.WriteLine("dnt remove");
            list.RemoveAt(0);

            /*for (int i = 0; i < list.Count; i++)
            {

            }
            
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
    /*
     * 
     * 
     * using System;
using System.Collections.Generic;
namespace Independentwork8_3
{
    class Program
    {
        static void Main(string[] args)
        {
            var colletion = new Queue<int>();
            while (true)
            {
                Console.WriteLine("Введите числодля очереди");
               var  str= Console.ReadLine();
                if (str.ToUpper()=="RUN")
                {
                    while (colletion.Count>0)
                    {
                        Console.WriteLine($"Выполнилась задая № :{colletion.Dequeue()}");
                    }
                    break;
                }
                else if (str.ToUpper() == "EXIT")
                {
                    Console.WriteLine($"В очереди осталось : {colletion.Count} ");
                    break;
                }
                else
                {
                    colletion.Enqueue(int.Parse(str));
                }

            }
        }
*/