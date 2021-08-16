using System;

namespace Week2Lesson8
{
    class Task1
    {
        static void Main(string[] args)
        {
            int counter = 0;
            for (int i = 2; i <= 100; i++)
            {
                bool isDivisible = false;
                for (int j = i / 2; j > 1; j--)
                {
                    if (i % j == 0)
                    {
                        isDivisible = true;
                        break;
                    }
                }

                if (!isDivisible)
                {
                    counter++;
                }
            }
            Console.WriteLine($"Result: {counter}");
        }
    }
}
