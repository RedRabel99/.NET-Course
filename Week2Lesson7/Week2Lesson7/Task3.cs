using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task3
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number");
            bool isValid = Int32.TryParse(Console.ReadLine(), out number);
            if (isValid)
            {
                if (number < 0)
                {
                    Console.WriteLine($"{number} is a negative number");
                }
                else
                {
                    Console.WriteLine($"{number} is a positive number");
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
