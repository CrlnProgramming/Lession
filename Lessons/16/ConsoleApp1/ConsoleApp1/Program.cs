using System;
using ClassLibrary1;

namespace ConsoleApp1
{
    
    delegate double Square(double radius);
    class Program
    {
        static void Main(string[] args)
        {
            /* var circle = new Circle(5.0);
             Func<double, double> operation = r => 2.0 * r;
             var diameter = circle.Calculate(operation);

             Console.WriteLine(diameter);

             Func<double, double> operation1 = r => Math.PI*r*r;
             Console.WriteLine(operation1);


             Console.WriteLine(circle.Calculate(r => 2.0 * r));
             */
            
            ClassLibrary1.ClassHelloWord.WriteHello();
            ClassLibrary1.Circle.
                


        }
    }

    //Переписать расчёт периметра и площади окружности на использование лямбда-выражений вместо методов класса.
    //Добавить функцию вычисление диаметра и также вывести результат расчёта диаметра на экран.
    // P = 2PIr
    //S = Pir^2
    
    
    public sealed class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }

        Square square = _radius =>2* _radius * _radius;
        public double Calculate (Func<double,double> operation)
        {
            return operation(_radius);
        }

    }
}
