using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            // We getting the width of the rectangle
            double width = double.Parse(Console.ReadLine());
            // We getting the height of the rectangle
            double height = double.Parse(Console.ReadLine());

            // We calculating the area of the rectangle
            // It's width multiplied by his height
            double area = width * height;

            // We printing the area of the rectangle
            Console.WriteLine($"{area:F2}");
        }
    }
}
