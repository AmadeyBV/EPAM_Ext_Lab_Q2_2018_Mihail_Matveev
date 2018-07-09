using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask3.Tasks
{
    class Task6
    {
        const string listCommands =
            "Text options: \n" +
            "\t '!bold' - bold \n" +
            "\t '!italics' - italics \n" +
            "\t '!underlined' - underlined \n" +
            "Commands: \n" +
            "\t '!styles' - show included styles \n" +
            "\t '!help' - shows available commands \n" +
            "\t '!back' - return to main menu";

        static Dictionary<string, bool> textStyles = new Dictionary<string, bool>()
        {
            { "Bold", false },
            { "Italics", false },
            { "Underlined", false }
        };

        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nTask 6");
            Console.ResetColor();

            Console.WriteLine(listCommands);

            InputCommand();
        }

        static void InputCommand()
        {
            Console.Write("Could you introduce the command: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            var command = Console.ReadLine();
            Console.ResetColor();

            CommandParser(command);
        }

        static void CommandParser(string command)
        {
            switch(command)
            {
                case "!bold"://todo pn хардкод
					AddStyle("Bold");
                    break;
                case "!italics":
                    AddStyle("Italics");
                    break;
                case "!underlined":
                    AddStyle("Underlined");
                    break;
                case "!styles":
                    DisplayStyles();
                    break;
                case "!back":
                    Console.WriteLine("Exit from Task 6\n");
                    return;
                case "!help":
                    Console.WriteLine(listCommands);
                    break;
                default:
                    Console.WriteLine("Unknown command entered");
                    break;
            }

            InputCommand();
        }

        static void AddStyle(string style)
        {
            textStyles[style] = !textStyles[style];

            DisplayStyles();
        }

        static void DisplayStyles()
        {
            Console.Write("Included styles: ");

            Console.ForegroundColor = ConsoleColor.Yellow;
            foreach(var style in textStyles)
            {
                if (style.Value)
                    Console.Write(style.Key + " ");
            }
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}
