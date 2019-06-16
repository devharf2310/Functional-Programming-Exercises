using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FunctionalProgramming
{
    public class Functions
    {
        public delegate int Comparison(Person employee, Person contractor);

        public Action<Person> Compare;
        public Func<Person, Person> Analize;

        //Lambda expressions

        //Dictionaries
        public Dictionary<bool, string> Languages = new Dictionary<bool, string>
        {
            [true] = "en",
            [false] = "es"
        };

        public void FilterPeople()
        {
            var people = new List<Person>
            {
                new Person
                {
                    Document = 1,
                    LastName = "X",
                    Name = "X"
                },
                new Person
                {
                    Document = 1,
                    LastName = "Y",
                    Name = "Y"
                },
            };

            //Inmutablidad
            var peopleFiltered = people.Where(x => x.Name == "X").OrderBy();

            var hugo = "hugo";

            

            //Mutabilidad
            people.Sort();
        }
        public class Person
        {
            public string Name { get; set; }
            public string LastName { get; set; }
            public int Document { get; set; }
        }
    }
