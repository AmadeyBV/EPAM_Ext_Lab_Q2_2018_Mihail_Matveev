using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task8
    {
        static int[,,] array;
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 8");
            Console.ResetColor();

            array = GenerateArray();
            DisplayArray();

            ReplacePositiveNumbers();
            DisplayArray();

            Console.WriteLine("Exit from Task 8\n");
        }

        static int[,,] GenerateArray(int lengthX = 3, int lengthY = 3, int lengthZ = 3)
        {
            var array = new int[lengthX, lengthY, lengthZ];

            for (var x= 0; x < array.GetLength(0); x++)
            {
                for (var y = 0; y < array.GetLength(1); y++)
                {
                    for (var z = 0; z < array.GetLength(2); z++)
                    {
                        array[x, y, z] = GenerateNumber();
                    }
                }
            }

            return array;
        }

        static Random rand = new Random();
        static int GenerateNumber(int min = -9, int max = 9)
        {
            var number = rand.Next(min, max);

            return number;
        }

        static void DisplayArray()
        {
            Console.WriteLine("Array:");
            for (var x = 0; x < array.GetLength(0); x++)
            {
                for (var y = 0; y < array.GetLength(1); y++)
                {
                    for (var z = 0; z < array.GetLength(2); z++)
                        Console.Write("{0} ", array[x, y, z]);
                    Console.WriteLine();
                }
                Console.WriteLine("--------");
            }
        }

        static void ReplacePositiveNumbers()
        {
            for (var x = 0; x < array.GetLength(0); x++)
            {
                for (var y = 0; y < array.GetLength(1); y++)
                {
                    for (var z = 0; z < array.GetLength(2); z++)
                    {
                        if (array[x, y, z] > 0)
                            array[x, y, z] = 0;
                    }
                }
            }
        }
    }
}
