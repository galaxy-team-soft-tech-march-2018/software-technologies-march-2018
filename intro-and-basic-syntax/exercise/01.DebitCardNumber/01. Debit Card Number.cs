using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.DebitCardNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            // Reading the input from the console

            var firstDigits = long.Parse(Console.ReadLine());
            var secondDigits = long.Parse(Console.ReadLine());
            var thirdDigits = long.Parse(Console.ReadLine());
            var fourthDigits = long.Parse(Console.ReadLine());

        // Printing the result on the Console in 4-digit debit card format

            Console.WriteLine($"{firstDigits:D4} {secondDigits:D4} {thirdDigits:D4} {fourthDigits:D4}");
        }
    }
}
