//CONFIRMED from georgihn
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
            var getFirstDigit = long.Parse(Console.ReadLine());
            // We read second digit of Debit Card
            var getSecondDigit = long.Parse(Console.ReadLine());
            // We read third digit of Debit Card
            var getThirdDigit = long.Parse(Console.ReadLine());
            // We read fourth digit of Debit Card
            var getFourthDigit = long.Parse(Console.ReadLine());

        // Printing the result on the Console in 4-digit debit card format

            //We print de result
            Console.WriteLine($"{getFirstDigit:D4} {getSecondDigit:D4} {getThirdDigit:D4} {getFourthDigit:D4}");
        }
    }
}
