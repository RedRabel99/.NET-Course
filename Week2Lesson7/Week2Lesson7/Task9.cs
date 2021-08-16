using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task9
    {
        static void Main(string[] args)
        {
            int temperature;
            Console.WriteLine("Enter temperature(in celcius):");
            bool isValud = Int32.TryParse(Console.ReadLine(), out temperature);
            if (isValud)
            {
                if (temperature < 0)
                {
                    Console.WriteLine("It's damn freezing");
                }
                else if (temperature >= 0 && temperature < 10)
                {
                    Console.WriteLine("Cold");
                }
                else if (temperature >= 10 && temperature < 20)
                {
                    Console.WriteLine("Chilly");
                }
                else if (temperature >= 20 && temperature < 30)
                {
                    Console.WriteLine("It's fine");
                }
                else if (temperature >= 30 && temperature < 40)
                {
                    Console.WriteLine("It's gettin bad, becuase it's hot");
                }
                else
                {
                    Console.WriteLine("Come on, I'm moving to Alaska");
                }
            }
            else
            {
                Console.WriteLine("Invalid temperature");
            }
        }
    }
}
