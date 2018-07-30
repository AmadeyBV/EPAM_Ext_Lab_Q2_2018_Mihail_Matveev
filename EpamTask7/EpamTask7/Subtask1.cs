using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask7
{
    class Subtask1
    {
        int[] array;

        public void Run()
        {
            GenerateArray();
            OutputArray();

            Console.WriteLine("Sum of array elements: {0}", array.Sum());
        }

        void GenerateArray(int length = 8)
        {
            var random = new Random();
            array = new int[length];

            for (var i = 0; i < length; i++)
            {
                array[i] = random.Next(10);
            }
        }

        void OutputArray()
        {
            Console.WriteLine("Array:");

            for (var i = 0; i < array.Length; i++)
                Console.Write(" {0} ",array[i]);

            Console.WriteLine();
        }
    }
}
