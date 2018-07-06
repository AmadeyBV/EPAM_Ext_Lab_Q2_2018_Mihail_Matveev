using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task12
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 12");
            Console.ResetColor();

            Console.Write("Could you type the text: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            var text = Console.ReadLine();
            Console.ResetColor();

            Console.Write("Could enter an additional line: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            var str = Console.ReadLine();
            Console.ResetColor();

            text = DoubleLetters(text, str);

            Console.Write("The resulting text: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(text);
            Console.ResetColor();

            Console.WriteLine("Exit from Task 12\n");
        }

        static string DoubleLetters(string text, string str)
        {
            for (var i = text.Length - 1; i >= 0; i--)
            {
                if (str.Contains(text[i]))
                {
                    text = text.Insert(i, text[i].ToString());
                }
            }

            return text;
        }
    }
}
