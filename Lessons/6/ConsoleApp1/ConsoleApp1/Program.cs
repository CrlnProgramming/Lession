using System;

namespace ConsoleApp1
{
    
        enum TypeFigure
        {
            Сircle = 1,
            EquilateralTriangle = 2,
            Rectangle = 3,
            Exit = 4,
        }

        
        public class Program
        {
            static void Main(string[] args)
            {
                bool flag = false;
                do
                {
                    Console.WriteLine("Enter type figure: \n1)Сircle\n2)Equilateral Triangle\n3)Rectangle");
                    Console.WriteLine("4)Exit");
                    try
                    {
                        switch ((TypeFigure)Enum.Parse(typeof(TypeFigure), Console.ReadLine()))
                        {
                            case TypeFigure.Сircle:
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter Diameter: ");
                                    double d = double.Parse(Console.ReadLine());
                                  var Sc = Math.PI * d;var Pc = 2.0 * Math.PI * (d / 2.0);
                                  var sc = string.Format("{0:#.##}", Sc);var pc = string.Format("{0:#.##}", Pc);
                                    Console.WriteLine($"The area of the figure = {sc} ");
                                    Console.WriteLine($"The perimeter of the figure = {pc}");
                                    Console.WriteLine();
                                    if (d < 0.0)
                                        throw new Exception("Entered value is less than 0");
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\tFormat Exception.\nString is entered instead of a number!\t\n");
                                    break;
                                }
                            case TypeFigure.EquilateralTriangle:
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the side: ");
                                    double x = double.Parse(Console.ReadLine());

                                    Console.WriteLine("The area of the figure = " + string.Format("{0:#.##}", (Math.Sqrt(3.0) / 4.0 * Math.Pow(x, 2.0))));
                                    Console.WriteLine(string.Format("The perimeter of the figure = {0}", (3.0 * x)));
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\tFormat Exception.\nString is entered instead of a number!\t\n");
                                    break;
                                }
                            case TypeFigure.Rectangle:
                                try
                                {
                                    Console.Clear();
                                    Console.WriteLine("Enter the side: ");
                                    double side = double.Parse(Console.ReadLine());
                                    Console.WriteLine("Enter the width: ");
                                    double width = double.Parse(Console.ReadLine());
                                var S = side * width; var s = string.Format("{0:#.##}", S);
                                    Console.WriteLine(string.Format($"The area of the figure = {s}"));
                                    Console.WriteLine(string.Format("The perimeter of the figure = {0}",((side + width) * 2.0)));
                                    break;
                                }
                                catch (FormatException)
                                {
                                    Console.Clear();
                                    Console.WriteLine("\n\tFormat Exception.\nString is entered instead of a number!\t\n");
                                    break;
                                }
                            case TypeFigure.Exit:
                                Console.WriteLine("Goodbye!!!\a");
                                flag = true;
                                break;
                            default:
                                Console.WriteLine("Input Erorr!");
                                Console.WriteLine();
                                break;
                        }
                    }
                    catch (ArgumentException)
                    {
                        Console.Clear();
                        Console.WriteLine("\n\tFormat Exception.\nString is entered instead of a number!\t\n");
                    }
                }
                while (!flag);
            }

           
        }
    }


