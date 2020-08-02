using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Person
    {
        public Person()
        {

        }
        public int PersonId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Bio { get; set; }
    }
}
