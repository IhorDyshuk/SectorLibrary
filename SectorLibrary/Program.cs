using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SectorLibrary;

namespace TestProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sector c1 = Sector.InPut();
            Console.WriteLine("First " + c1);
            Sector c2 = Sector.InPut();
            Console.WriteLine("Second " + c2);

            Sector sum = c1 + c2; 
            Console.WriteLine("Sum: " + sum);

            Sector sub = c1 - c2;
            Console.WriteLine("Subtraction: " + sub);

            if (c1) Console.WriteLine(true);
            else Console.WriteLine(false);

            bool equal1 = c1 == c2;
            Console.WriteLine(equal1);

            bool equal2 = c1 != c2;
            Console.WriteLine(equal2);

            double radius = (double)c1.Radius;
            Console.WriteLine($"Radius value of first sector: {radius}");

            double angle = c1.Angle;
            Console.WriteLine($"Angle value of first sector: {angle}");

        }
    }
}
