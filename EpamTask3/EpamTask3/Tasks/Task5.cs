using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task5
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 5");
            Console.ResetColor();

            var sum = FindSumMultiple(3) + FindSumMultiple(5);

            Console.Write("Sum of numbers up to 1000 multiple 3 and 5: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sum);
            Console.ResetColor();

            Console.WriteLine("Exit from Task 5\n");
        }

        static int FindSumMultiple(int number)
        {
            var maxNumber = 1000;
            var numb = 0;
            var sum = 0;
            while (numb < maxNumber)
            {
                sum += numb;
                numb += number;
            }

            return sum;
        }
    }
}
