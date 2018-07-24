using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask2
{
    class Person
    {
        public string Name;

        public Person()
        {
            Name = CreateName();
        }

        string CreateName(int lengthName = 5)
        {
            var random = new Random();
            var name = ((char)random.Next('A', 'Z' + 1)).ToString();

            for (var i = 1; i < lengthName; i++)
            {
                name += (char)random.Next('a', 'z' + 1);
            }

            return name;
        }

        int startAfternoon = 12,
            endAfternoon = 17;
        public void SayHello(string name)
        {
            var hourNow = DateTime.Now.Hour;
            if (hourNow < startAfternoon)
            {
                Console.WriteLine("Good morning, {0} - say {1}", name, Name);
                Console.WriteLine("Good morning, {0} - say {1}", Name, name);
            }
            if ((hourNow >= startAfternoon) && (hourNow < endAfternoon))
            {
                Console.WriteLine("Good afternoon, {0} - say {1}", name, Name);
                Console.WriteLine("Good afternoon, {0} - say {1}", Name, name);
            }
            if (hourNow >= endAfternoon)
            {
                Console.WriteLine("Good evening, {0} - say {1}", name, Name);
                Console.WriteLine("Good evening, {0} - say {1}", Name, name);
            }
        }

        public void SayGoodbye(string name)
        {
            Console.WriteLine("Goodbye, {0} - say {1}", name, Name);
        }
    }
}
