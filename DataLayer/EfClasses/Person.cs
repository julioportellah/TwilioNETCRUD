using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.EfClasses
{
    public class Person
    {
        public int PersonId { get; private set; }
        
        public string Name { get; private set; }

        public string FirstLastName { get; private set; }

        public string SecondLastName { get; private set; }

        public DateTime BirthDate { get; private set; }

        private Person() { }

        public Person(string name, string firstLastName, string secondLastName, DateTime birthDate)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentNullException(nameof(name));
            if (string.IsNullOrWhiteSpace(firstLastName))
                throw new ArgumentNullException(nameof(name));
            Name = name;
            FirstLastName = firstLastName;
            SecondLastName = secondLastName;
            BirthDate = birthDate;
        }

    }
}
