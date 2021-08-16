using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task6
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter your height(in centimeters)");
            bool isValid = Int32.TryParse(Console.ReadLine(), out number);
            if (!isValid || number < 1)
            {
                Console.WriteLine("Invalid height");
            }
            else
            {
                if (number < 160)
                {
                    Console.WriteLine("You are a dwarf :D");
                }
                else if (number < 185)
                {
                    Console.WriteLine("You have an average height");
                }
                else if (number < 200)
                {
                    Console.WriteLine("You are tall");
                }
                else
                {
                    Console.WriteLine("Have you ever thought of playing basketball?");
                }
            }
        }
    }
}
