using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var heli = new Halicopter(3000,5000);
            heli.WriteToInfo();

            var plane = new Plane(4000, 5000);
            plane.WriteToInfo();

        }
    }
}
