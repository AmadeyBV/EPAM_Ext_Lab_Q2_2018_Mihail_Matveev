using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task11
    {
        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 11");
            Console.ResetColor();

            var text = InputText();
            text = TextFiltering(text);
            FindMeanWords(text);

            Console.WriteLine("Exit from Task 11\n");
        }

        static StringBuilder InputText()
        {
            Console.Write("Could you type the text:");
            Console.ForegroundColor = ConsoleColor.Yellow;
            var text = new StringBuilder(Console.ReadLine());
            Console.ResetColor();
            
            return text;
        }

        static StringBuilder TextFiltering(StringBuilder text)
        {
            for (var i = 0; i < text.Length; i++)
            {
                if ((!Char.IsLetter(text[i])) && (!Char.IsNumber(text[i])))
                {
                    text[i] = ' ';
                }
            }

            return text;
        }

        static void FindMeanWords(StringBuilder text)
        {
            var str = text.ToString();
            var arrayWords = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            var meanWords = 0.0;

            for (var i = 0; i < arrayWords.Length; i++)
            {
                meanWords += arrayWords[i].Length;
            }

            meanWords /= arrayWords.Length;
            
            Console.Write("Average length of words: ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(meanWords);
            Console.ResetColor();
        }
    }
}
