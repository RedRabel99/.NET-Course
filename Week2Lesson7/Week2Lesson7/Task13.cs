using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task13
    {
        static void Main(string[] args)
        {
            double x, y;
            Console.WriteLine("Enter the first number:");
            bool xIsValid = Double.TryParse(Console.ReadLine(), out x);
            Console.WriteLine("Enter the second number:");
            bool yIsValid = Double.TryParse(Console.ReadLine(), out y);
            int operation;
            Console.WriteLine("Enter the number of the operation to be performed:\n" +
                              "1.Addition\n2.Subtraction\n3.Multiplication\n4.Division");
            bool operationIsValid = Int32.TryParse(Console.ReadLine(), out operation);
            if (xIsValid && yIsValid && operationIsValid)
            {
                Console.Write("Your result is: ");
                switch (operation)
                {
                    case 1:
                        Console.WriteLine(x + y);
                        break;
                    case 2:
                        Console.WriteLine(x - y);
                        break;
                    case 3:
                        Console.WriteLine(x * y);
                        break;
                    case 4:
                        if (y != 0)
                        {
                            Console.WriteLine(x / y);
                        }
                        else
                        {
                            Console.WriteLine("Error -  you can't divide by zero");
                        }
                        break;
                    default:
                        Console.WriteLine("Error -  wrong operation number");
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
