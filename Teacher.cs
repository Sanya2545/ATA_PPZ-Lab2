using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2
{
    public class Teacher : Person
    {
        Group[] Groups;
        public Teacher(string firstName = "", string surName = "", string lastName = "", int age = 0, Group[] groups = null)
        {
            FirstName = firstName;
            SurName = surName;
            LastName = lastName;
            Age = age;
            Groups = groups;
        }
        
    }
}
