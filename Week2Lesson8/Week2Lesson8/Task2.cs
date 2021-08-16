using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    class Task2
    {
        static void Main(string[] args)
        {
            int counter = 0;
            do
            {
                if (counter % 2 == 0)
                {
                    Console.WriteLine(counter);
                }
                counter++;
            } while (counter <= 1000);
        }
    }
}
