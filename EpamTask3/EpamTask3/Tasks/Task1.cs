using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task1
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 1");
            Console.ResetColor();

            var sideA = EnterNumber();
            var sideB = EnterNumber();

            CalculateArea(sideA, sideB);
        }

        static int EnterNumber()
        {
            while (true)
            {
                Console.Write("Could you enter the side: ");//todo pn хардкод
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

        static void CalculateArea(int a, int b)
        {
            var area = a * b;
            if (area > 0)
            {
                Console.Write("Area of a rectangle: ");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine(area);
                Console.ResetColor();

                Console.WriteLine("Exit from Task 1\n");
            }
            else
                Console.WriteLine("Decision error. Exit from Task 1\n");
        }
    }
}
