using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task9
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 9");
            Console.ResetColor();

            var array = GenerateArray();
            DisplayArray(array);

            var sum = SumPositiveNumber(array);
            Console.Write("Sum of positive numbers in the array: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sum);
            Console.ResetColor();

            Console.WriteLine("Exit from Task 9\n");
        }

        static int[] GenerateArray(int length = 10)
        {
            var array = new int[length];

            for (var i = 0; i < array.Length; i++)
                array[i] = GenerateNumber();

            return array;
        }

        static Random random = new Random();
        static int GenerateNumber(int min = -9, int max = 9)
        {
            var number = random.Next(min, max);

            return number;
        }

        static void DisplayArray(int[] array)
        {
            Console.Write("Array: ");
            for (var i = 0; i < array.Length; i++)
                Console.Write("{0} ", array[i]);
            Console.WriteLine();
        }

        static int SumPositiveNumber(int[] array)
        {
            var sum = 0;
            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                    sum += array[i];
            }

            return sum;
        }
    }
}
