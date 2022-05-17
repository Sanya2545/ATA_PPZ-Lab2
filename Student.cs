using LabWork_2.Disciplines;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2
{
    public class Student : Person
    {
        Discipline[] Disciplines;
        public bool DoesHaveComputer = false;
        public bool DoesHaveSpeackers = false;
        public Student(string firstName = "", string surName = "", string lastName = "", int age = 0, bool doesHaveComputer = true, bool doesHaveSpeackers = true, Discipline[] disciplines = null)
        {
            FirstName = firstName;
            SurName = surName;
            LastName = lastName;
            Age = age;
            DoesHaveComputer = doesHaveComputer;
            DoesHaveSpeackers = doesHaveSpeackers;
            Disciplines = disciplines;
        }
        public bool DoLabs()
        {
            for (int i = 0; i < Disciplines.Length; ++i)
            {
                if(Disciplines[i] is ArchitectureOfSoftware)
                {
                    
                }
                
            }
        }


    }
}
