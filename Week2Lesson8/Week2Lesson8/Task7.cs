using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson8
{
    class Task7
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a string:");
            char[] text = Console.ReadLine().ToCharArray();

            for(int i = text.Length - 1; i >= 0; i--)
            {
                Console.Write(text[i]);
            }
        }
    }
}
