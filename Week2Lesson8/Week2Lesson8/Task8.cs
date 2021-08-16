using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    class Task8
    {
        static void Main(string[] args)
        {
            int number;
            StringBuilder result = new StringBuilder();
            Console.WriteLine("Enter a number");
            bool isValid = Int32.TryParse(Console.ReadLine(), out number);
            if (isValid)
            {
                int temp = number;
                while(temp != 0)
                {
                    if(temp % 2 == 0)
                    {
                        result.Insert(0, "0");
                    }
                    else
                    {
                        result.Insert(0, "1");
                    }
                    temp /= 2;
                }
                if (number < 0)
                {
                    result.Insert(0, "-");
                }
                Console.WriteLine($"decimal: {number} binary: {result}");
            }
            else
            {
                Console.WriteLine("Invalid number:\nCan not convert from non decimal value");
            }
        }
    }
}
