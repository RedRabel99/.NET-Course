using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task7
    {
        static int Max(int a, int b)
        {
            return a > b ? a : b;
        }
        static void Main(string[] args)
        {
            int firstValue, secondValue, thirdValue;
            Console.WriteLine("Enter the first value:");
            bool firstIsValid = Int32.TryParse(Console.ReadLine(), out firstValue);
            Console.WriteLine("Enter the second value");
            bool secondIsValid = Int32.TryParse(Console.ReadLine(), out secondValue);
            Console.WriteLine("Enter the third value");
            bool thirdIsValid = Int32.TryParse(Console.ReadLine(), out thirdValue);
            if (firstIsValid && secondIsValid && thirdIsValid)
            {
                Console.WriteLine($"{Max(Max(firstValue, secondValue), thirdValue)} is the largest of the given");
            }
            else
            {
                Console.WriteLine("Invalid numbers");
            }
        }
    }
}
