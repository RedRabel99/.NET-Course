using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task10
    {
        static void Main(string[] args)
        {
            int a = 40;
            int b = 55;
            int c = 65;
            if (a + b > c && a + c > b && b + c > a)
            {
                Console.WriteLine("A triangle can be built");
            }
            else
            {
                Console.WriteLine("A triangle can not be built");
            }
        }
    }
}
