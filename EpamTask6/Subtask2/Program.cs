using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask2
{
    class Program
    {
        static void Main(string[] args)
        {
            var office = new Office();

            office.Start();
            office.Stop();

            Console.ReadKey();
        }
    }
}
