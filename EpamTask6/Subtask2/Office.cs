using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subtask2
{
    class Office
    {
        List<Person> persons;

        public Office()
        {
            persons = new List<Person>();
        }

        public void Start()
        {
            GeneratePersons();
        }

        public delegate void InputPerson(string name);
        public event InputPerson onPerson;

        void GeneratePersons(int numberPersons = 5)
        {
            for (var i = 0; i < numberPersons; i++)
            {
                var person = new Person();
                Console.WriteLine("{0} came to the office", person.Name);

                onPerson?.Invoke(person.Name);

                persons.Add(person);
                onPerson += person.SayHello;
                offPerson += person.SayGoodbye;

                Console.WriteLine();
            }
        }

        public delegate void OutputPerson(string name);
        public event OutputPerson offPerson;

        public void Stop()
        {
            DeletePerson();
        }

        void DeletePerson()
        {
            for (var i = 0; i < persons.Count; i++)
            {
                Console.WriteLine("{0} leaves the office", persons[i].Name);

                onPerson -= persons[i].SayHello;
                offPerson -= persons[i].SayGoodbye;

                offPerson?.Invoke(persons[i].Name);

                Console.WriteLine();
            }

            persons.Clear();
        }
    }
}
