using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task4
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 4");
            Console.ResetColor();

            var numberTriangles = EnterNumber();
            DrawShape(numberTriangles);
        }

        static int EnterNumber()
        {
            while (true)
            {
                Console.Write("Could you enter the number of triangles: ");
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

        static void DrawShape(int numbTriangles)
        {

            Console.ForegroundColor = ConsoleColor.Red;
            for (var i = 0; i < numbTriangles; i++)
            {
                var numbStar = 1;
                for (var j = 0; j < i; j++)
                {
                    var stars = new string(' ', numbTriangles - j - 2) + new string('*', numbStar);
                    Console.WriteLine(stars);

                    numbStar += 2;
                }
            }
            Console.ResetColor();

            Console.WriteLine("Exit from Task 4\n");
        }
    }
}
