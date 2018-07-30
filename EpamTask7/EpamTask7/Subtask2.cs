using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpamTask7
{
    class Subtask2
    {
        public void Run()
        {
            Console.Write("Could you input a string: ");
            var str = Console.ReadLine();

            Console.WriteLine("The entered string is a positive integer: {0}", str.IsPositiveInt());
        }
    }
}
