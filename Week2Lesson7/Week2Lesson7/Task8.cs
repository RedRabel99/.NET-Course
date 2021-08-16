using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lesson7
{
    class Task8
    {
        static void Main(string[] args)
        {
            int mathScore = 80;
            int physicsScore = 71;
            int chemistryScore = 0;
            int sumScore = mathScore + physicsScore + chemistryScore;
            if ((mathScore > 70 && physicsScore > 55 && chemistryScore > 45 && sumScore > 180)
                || (mathScore + physicsScore > 150 || mathScore + chemistryScore > 150))
            {
                Console.WriteLine("Candidate admitted to recruitment");
            }
            else
            {
                Console.WriteLine("Candidate not admitted to recruitment");
            }
        }
    }
}
