using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task12
    {
        static void Main(string[] args)
        {
            int weekday;
            Console.WriteLine("Enter a number from 1 to 7:");
            bool isValid = Int32.TryParse(Console.ReadLine(), out weekday);
            if (isValid)
            {
                switch (weekday)
                {
                    case 1:
                        Console.WriteLine("Monday");
                        break;
                    case 2:
                        Console.WriteLine("Tuesday");
                        break;
                    case 3:
                        Console.WriteLine("Wednesday");
                        break;
                    case 4:
                        Console.WriteLine("Thursday");
                        break;
                    case 5:
                        Console.WriteLine("Friday");
                        break;
                    case 6:
                        Console.WriteLine("Saturday");
                        break;
                    case 7:
                        Console.WriteLine("Sunday");
                        break;
                    default:
                        Console.WriteLine("Number too large or too small");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
        }
    }
}
