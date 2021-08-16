using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson4
{
    class Task3
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            string input;

            Console.WriteLine("Enter the lenght of a");
            input = Console.ReadLine();
            bool aIsValid = Double.TryParse(input, out a);
            Console.WriteLine("Enter the lenght of b");
            input = Console.ReadLine();
            bool bIsValid = Double.TryParse(input, out b);

            if (aIsValid && bIsValid)
            {
                double d = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
                Console.WriteLine($"The length of diagonal is: {d}");
            }
            else
            {
                Console.WriteLine("Invalid values");
            }
            
        }
    }
}
