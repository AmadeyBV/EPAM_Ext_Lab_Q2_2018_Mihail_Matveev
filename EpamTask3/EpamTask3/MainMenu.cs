using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EpamTask3.Tasks;

namespace EpamTask3
{
    class MainMenu
    {
        const string help =
            "\t'task 1'-'task 13' to select a task; \n" +
            "\t'help' to shows available commands;";

        public static void Start()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Main menu");
            Console.ResetColor();

            Console.WriteLine("Could you enter the job number (help - shows available commands)");
            InputCommand();
        }

        static void InputCommand()
        {
            var command = Console.ReadLine();
            CommandParser(command);
        }

        static void CommandParser(string command)
        {
            switch (command)
            {
                case "task 1"://todo pn хардкод
                    Task1.Start();
                    break;
                case "task 2":
                    Task2.Start();
                    break;
                case "task 3":
                    Task3.Start();
                    break;
                case "task 4":
                    Task4.Start();
                    break;
                case "task 5":
                    Task5.Start();
                    break;
                case "task 6":
                    Task6.Start();
                    break;
                case "task 7":
                    Task7.Start();
                    break;
                case "task 8":
                    Task8.Start();
                    break;
                case "task 9":
                    Task9.Start();
                    break;
                case "task 10":
                    Task10.Start();
                    break;
                case "task 11":
                    Task11.Start();
                    break;
                case "task 12":
                    Task12.Start();
                    break;
                case "task 13":
                    Task13.Start();
                    break;
                case "help":
                    Console.WriteLine(help);
                    break;
                default:
                    Console.WriteLine("Unknown command entered");
                    break;
            }

            InputCommand();
        }
    }
}
