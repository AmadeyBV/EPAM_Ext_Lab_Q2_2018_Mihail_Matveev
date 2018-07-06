using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task7
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 7");
            Console.ResetColor();

            var array = GenerateArray(GenerateNumber());
            DisplayArray(array);

            array = BubbleSort(array);
            DisplayArray(array);

            Console.WriteLine("Exit from Task 7\n");
        }

        static int[] GenerateArray(int length)
        {
            var array = new int[length];

            for (var i = 0; i < array.Length; i++)
                array[i] = GenerateNumber();

            return array;
        }

        static Random random = new Random();
        static int GenerateNumber(int min = 5, int max = 30)
        {
            var number = random.Next(min, max);

            return number;
        }

        static void DisplayArray(int[] array)
        {
            Console.Write("Array: ");
            for (var i = 0; i < array.Length; i++)
                Console.Write("{0} ",array[i]);
            Console.WriteLine();
        }

        static int[] BubbleSort(int[] array)
        {
            Console.WriteLine("Sorting");
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }                   
                }            
            }

            return array;
        }
    }
}
