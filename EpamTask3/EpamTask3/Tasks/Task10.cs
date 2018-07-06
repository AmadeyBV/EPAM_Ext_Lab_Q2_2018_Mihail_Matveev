using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task10
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 10");
            Console.ResetColor();

            var array = GenerateArray();
            DisplayArray(array);

            var sum = SumEvenElements(array);
            Console.Write("Sum of even elements: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(sum);
            Console.ResetColor();

            Console.WriteLine("Exit from Task 10\n");
        }

        static int[,] GenerateArray(int lengthX = 3, int lengthY = 3)
        {
            var array = new int[lengthX, lengthY];

            for (var i = 0; i < array.GetLength(0); i++)
                for (var j = 0; j < array.GetLength(1); j++)
                    array[i, j] = GenerateNumber();

            return array;
        }

        static Random random = new Random();
        static int GenerateNumber(int min = -9, int max = 9)
        {
            var number = random.Next(min, max);

            return number;
        }

        static void DisplayArray(int[,] array)
        {
            Console.WriteLine("Array: ");
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                    Console.Write("{0} ", array[i, j]);
                Console.WriteLine();
            }
        }

        static int SumEvenElements(int[,] array)
        {
            var sum = 0;
            for (var i = 0; i < array.GetLength(0); i++)
            {
                for (var j = 0; j < array.GetLength(1); j++)
                {
                    if ((i + j) % 2 == 0)
                        sum += array[i, j];
                }
            }

            return sum;
        }
    }
}
