using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task13
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 13");
            Console.ResetColor();

            var stopWatch = new Stopwatch();

            stopWatch.Start();
            FirstVoid();
            stopWatch.Stop();
            DisplayResult("The execution time of the first void: ", stopWatch.Elapsed.Milliseconds);

            stopWatch.Restart();
            SecondVoid();
            stopWatch.Stop();
            DisplayResult("The execution time of the second void: ", stopWatch.Elapsed.Milliseconds);

            Console.WriteLine("Exit from Task 13\n");
        }

        static void DisplayResult(string text, int result)
        {
            Console.Write(text);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(result);
            Console.ResetColor();
        }

        static void FirstVoid()
        {
            var str = "";
            int N = 100000;

            for (int i = 0; i < N; i++)
            {
                str += "*";
            }
        }

        static void SecondVoid()
        {
            StringBuilder sb = new StringBuilder();
            int N = 100000;

            for (int i = 0; i < N; i++)
            {
                sb.Append("*");
            }
        }
    }
}
