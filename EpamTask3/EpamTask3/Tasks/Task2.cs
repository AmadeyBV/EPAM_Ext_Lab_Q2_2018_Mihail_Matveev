using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task2
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 2");
            Console.ResetColor();

            var numberLines = EnterNumber();

            DrawShape(numberLines);
        }

        static int EnterNumber()
        {
            while (true)
            {
                Console.Write("Could you enter the number of lines: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                var str = Console.ReadLine();
                Console.ResetColor();

                try
                {
                    var number = int.Parse(str);
                    if (number > 0)
                        return number;
                    else
                        Console.WriteLine("Enter a positive number");
                }
                catch
                {
                    Console.WriteLine("Wrong number");
                }
            }
        }

        static void DrawShape(int numbLines)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            for (var i = 0; i < numbLines; i++)
            {
                var stars = new string('*', i + 1);
                Console.WriteLine(stars);
            }
            Console.ResetColor();

            Console.WriteLine("Exit from Task 2\n");
        }
    }
}
