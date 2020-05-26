using System;
using Library;
using LibraryCalculateStandart;
using LibraryCore;

namespace ConsoleApp1
{
    /*Переписать расчёт периметра и площади окружности на использование лямбда-выражений вместо методов класса.
    //Добавить функцию вычисление диаметра и также вывести результат расчёта диаметра на экран.
    // P = 2PIr
    //S = Pir^2
    */
    public sealed class Circle
    {
        private double _radius;
        public Circle(double radius)
        {
            _radius = radius;
        }
        public double Calculate(Func<double, double> operation)
        {
            return operation(_radius);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //var circule = new Circle(1.5);
            //Console.WriteLine($"Diametr = {circule.Calculate(r => 2.0 * r)}, " +
            //    $"Perimtr = {circule.Calculate(r => 2 * Math.PI * r)}, " +
            //    $"Sq = {circule.Calculate(r => Math.PI * Math.Pow(r, 2))}");
            Class1.WriteHelloWord();
            Calculate.FigureMetod();
            Operatin.OperationMethod();
        }
    }

}
