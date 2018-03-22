using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_2.Rectangle_Area
{
    class Program
    {
        // confirmed from mariyast1
        static void Main(string[] args)
        {
            // We getting the width of the rectangle
            double widthOfTheRectangle = double.Parse(Console.ReadLine());
            // We getting the height of the rectangle
            double heightOfTheRectangle = double.Parse(Console.ReadLine());

            // We calculating the area of the rectangle
            // It's width multiplied by his height
            double areaOfTheRectangle = widthOfTheRectangle * heightOfTheRectangle;

            // We printing the area of the rectangle
            Console.WriteLine($"{areaOfTheRectangle:F2}");
        }
    }
}
