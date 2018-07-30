using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace EpamTask7
{
    class Subtask3
    {
        public void Run()
        {
            NotifyTime();
        }

        public int[] FindPositiveElements(int[] array)
        {
            var listNumber = new List<int>();

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                    listNumber.Add(array[i]);
            }

            return listNumber.ToArray();
        }

        delegate int[] FindPositElem(int[] array);

        void NotifyTime(int repetition = 9999999)
        {
            var stopwatch = new Stopwatch();
            var array = GenerateArray();
            
            Console.Write("1: ");
            stopwatch.Start();
            for (var i = 0; i < repetition; i++)
            {
                FindPositiveElements(array);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.Milliseconds);

            Console.Write("2: ");
            FindPositElem findElem = FindPositiveElements;
            stopwatch.Restart();
            for (var i = 0; i < repetition; i++)
            {
                findElem(array);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.Milliseconds);

            Console.Write("3: ");
            FindPositElem findPositElem = delegate (int[] arr)
            {
                var listNumber = new List<int>();

                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        listNumber.Add(array[i]);
                }

                return listNumber.ToArray();
            };
            stopwatch.Restart();
            for (var i = 0; i < repetition; i++)
            {
                findPositElem(array);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.Milliseconds);

            Console.Write("4: ");
            FindPositElem posElem = arrayPosElem =>
            {
                var listNumber = new List<int>();

                for (var i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        listNumber.Add(array[i]);
                }

                return listNumber.ToArray();
            };
            stopwatch.Restart();
            for (var i = 0; i < repetition; i++)
            {
                var arr = posElem(array);
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.Milliseconds);

            Console.Write("5: ");
            stopwatch.Restart();
            for (var i = 0; i < repetition; i++)
            {
                var arr = 
                    from element in array
                    where element > 0
                    select element;
            }
            stopwatch.Stop();
            Console.WriteLine(stopwatch.Elapsed.Milliseconds);
        }

        int[] GenerateArray(int minValue = -9, int maxValue = 9, int length = 10)
        {
            var random = new Random();
            var array = new int[length];

            for (var i = 0; i < length; i++)
            {
                array[i] = random.Next(minValue, maxValue);
            }

            return array;
        }
    }
}
