using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task5
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your age");
            bool isValid = Int32.TryParse(Console.ReadLine(), out number);
            if (!isValid || number < 0)
            {
                Console.WriteLine("Invalid age");
            }
            else
            {
                if (number < 21)
                {
                    Console.WriteLine("You can't be anyone");
                }
                else
                {
                    string result = "You can be: Member of Parliament";

                    if (number >= 30)
                    {
                        result += " or senator";
                    }

                    if (number >= 35)
                    {
                        result += " or president";
                    }

                    Console.WriteLine(result);
                }
            }
        }
    }
}
