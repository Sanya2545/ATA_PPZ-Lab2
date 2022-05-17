using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2
{
    public abstract class Person
    {
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public string LastName { get; set; }
        public  int Age { get; set; }
        public Person(string firstName = "", string surName  = "", string lastName = "", int age = 0)
        {
            FirstName = firstName;
            SurName = surName;
            LastName = lastName;
            Age = age;
        }
    }
}
