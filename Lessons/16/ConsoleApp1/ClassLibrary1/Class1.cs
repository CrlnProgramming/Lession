using System;
using ClassLibrary1;

namespace ClassLibrary1
{
    public class ClassHelloWord
    {
        public static void WriteHello()
        {
            Console.WriteLine("Hello Word");
        }
    }

    public sealed class Circle
    {
        private double _radius;

        public Circle(double radius)
        {
            _radius = radius;
        }

        public double Calculate(Func<double, double> operaticon)
        {
            return operaticon(_radius);
        }

        /*
        var circle = new Circle(1.5);
        circle.Calculate(radius => Math.PI* 2 * radius);

            foreach(var item in new int[] { 1, 2, 3, 4, 5 }.Where(i => i % 2 == 0))
                {
                Console.WriteLine(item);
            }
            */
    }
}
