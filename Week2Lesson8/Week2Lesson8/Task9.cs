using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    class Task9
    {
        static int GCD(int a, int b)
        {
            while(a != b)
            {
                if (a > b)
                {
                    a = a - b;
                }
                else
                {
                    b = b - a;
                }
            }
            return a;
        }
        static int LCM(int a, int b)
        {
            return (a * b) / GCD(a, b); 
        }
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Enter first number:");
            bool aIsValid = Int32.TryParse(Console.ReadLine(), out a);
            Console.WriteLine("Enter second number:");
            bool bIsValid = Int32.TryParse(Console.ReadLine(), out b);

            if(aIsValid && bIsValid)
            {
                Console.WriteLine($"Least common multiply of {a} and {b} is {LCM(a, b)}");
            }
            else
            {
                Console.WriteLine("Invalid numbers");
            }
        }
    }
}
