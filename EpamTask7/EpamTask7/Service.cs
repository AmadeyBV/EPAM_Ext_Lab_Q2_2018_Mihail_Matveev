using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask7
{
    class Service
    {
        const string helpMessage =
            "!task1 - run the first subtask \n" +
            "!task2 - run the second subtask \n" +
            "!task3 - run the third subtask \n" +
            "!help - show a hint";

        public void Start()
        {
            InputCommand();
        }

        void InputCommand()
        {
            Console.Write("Could you enter the command: ");
            var command = Console.ReadLine();

            CommandParser(command);
        }

        void CommandParser(string command)
        {
            switch (command)
            {
                case "!task1":
                    var subtask1 = new Subtask1();
                    subtask1.Run();
                    break;
                case "!task2":
                    var subtask2 = new Subtask2();
                    subtask2.Run();
                    break;
                case "!task3":
                    var subtask3 = new Subtask3();
                    subtask3.Run();
                    break;
                case "!help":
                    Console.WriteLine(helpMessage);
                    break;
                default:
                    Console.WriteLine("Unknown command");
                    break;
            }

            InputCommand();
        }
    }
}
