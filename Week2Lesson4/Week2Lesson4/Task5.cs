using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson4
{
    public enum Sex
    {
        Male = 1,
        Female,
        Other
    }
    class Task5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name:");
            string firstName = Console.ReadLine();

            Console.WriteLine("Enter last name:");
            string lastName = Console.ReadLine();

            Console.WriteLine("Enter an email address:");
            string emailAddress = Console.ReadLine();

            Console.WriteLine("Enter a phone number: ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Enter age:");
            byte age;
            Byte.TryParse(Console.ReadLine(), out age);

            Console.WriteLine("Enter height(in centimeters):");
            byte height;
            Byte.TryParse(Console.ReadLine(), out height);

            Console.WriteLine("Enter weight(in kilograms):");
            double weight;
            Double.TryParse(Console.ReadLine(), out weight);

            Console.WriteLine("Enter PESEL number");
            string pesel = Console.ReadLine();

            Console.WriteLine("Enter sex:\n1. Male\n2.Female\n3.Other");
            Sex sex;
            Enum.TryParse(Console.ReadLine(), out sex);
        }
    }
}
