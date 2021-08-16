using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    class Task6
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number");
            int n;
            bool isValid = Int32.TryParse(Console.ReadLine(), out n);
            if (isValid)
            {
                n = n / 2 + 1;
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 0; j < n - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < i * 2 - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                for (int i = n - 1; i >= 1; i--)
                {
                    for (int j = 0; j < n - i; j++)
                    {
                        Console.Write(" ");
                    }

                    for (int j = 0; j < i * 2 - 1; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
