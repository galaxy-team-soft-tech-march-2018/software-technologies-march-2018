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
            // We read first digit of Debit Card
            var firstDigits = long.Parse(Console.ReadLine());
            // We read second digit of Debit Card
            var secondDigits = long.Parse(Console.ReadLine());
            // We read third digit of Debit Card
            var thirdDigits = long.Parse(Console.ReadLine());
            // We read fourth digit of Debit Card
            var fourthDigits = long.Parse(Console.ReadLine());

        // Printing the result on the Console in 4-digit debit card format

            //We print de result
            Console.WriteLine($"{firstDigits:D4} {secondDigits:D4} {thirdDigits:D4} {fourthDigits:D4}");
        }
    }
}
