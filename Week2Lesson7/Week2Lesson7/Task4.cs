using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task4
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a year to check:");
            bool isValid = Int32.TryParse(Console.ReadLine(), out number);
            if (isValid)
            {
                if ((number % 100 != 0 && number % 4 == 0) || number % 400 == 0)
                {
                    Console.WriteLine($"{number} is a leap year");
                }
                else
                {
                    Console.WriteLine($"{number} is not a leap year");
                }
            }
            else
            {
                Console.WriteLine("Invalid year");
            }
        }
    }
}
