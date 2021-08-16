using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    class Task3
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Enter number of elements");
            bool isValid = Int32.TryParse(Console.ReadLine(), out n);
            if (isValid)
            {
                int a = 0, b = 1;
                for (int i = 0; i < n; i++)
                {
                    Console.Write(a + " ");

                    int sum = a + b;
                    a = b;
                    b = sum;
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
