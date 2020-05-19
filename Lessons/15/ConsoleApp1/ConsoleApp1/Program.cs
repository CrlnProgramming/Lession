using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var Acc = new Acaount<int>(1,"Georgiy");
            Acc.WriteProporties();
            Calculator();
        }

        private static void Calculator()
        {
            var circle = new Circle(1.5);
            circle.Calculate(radius => Math.PI * 2 * radius);

            foreach (var item in new int[] { 1, 2, 3, 4, 5 }.Where(i => i % 2 == 0))
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
}
