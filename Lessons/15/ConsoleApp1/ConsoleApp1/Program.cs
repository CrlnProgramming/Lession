using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //var Acc = new Account<int, string>(id: 1, name: "Georgiy");
            //Acc.WriteProporties();
            
            var circle = new Circle(1.5);
            circle.Calculate(radius => Math.PI * 2 * radius);

            foreach(var item in new int[] { 1, 2, 3, 4, 5 }.Where(i => i % 2 == 0))
                {
                Console.WriteLine(item);
            }


        }


    }


    public sealed class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        

        public double Calculate(Func<double,double> operaticon)
        {
            return operaticon(_radius);
        }
    }


   /* class Account<T ,B>
    {
        public int Id  { get; private set; }
        public string Name { get; private set; }

        public Account(int id,string name)
        {
            Id = id;
            Name = name;
        }

        public void WriteProporties() => Console.WriteLine($"id: {Id}, name: {Name}");
        }
*/
    
}
