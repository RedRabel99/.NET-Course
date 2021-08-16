using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    class Task4
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter the number");
            bool isValid = Int32.TryParse(Console.ReadLine(), out number);
            if (isValid)
            {
                int counter = 0, edge = 1;
                for (int i = 1; i <= number; i++)
                {
                    if (counter == edge)
                    {
                        Console.WriteLine();
                        counter = 0;
                        edge++;
                    }
                    Console.Write($"{i} ");
                    counter++;
                }
            }
            else
            {
                Console.WriteLine("Invalid Number");
            }
        }
    }
}
