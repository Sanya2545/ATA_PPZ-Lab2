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
        public int Course { get; set; }
        public bool DoesHaveComputer = false;
        public bool DoesHaveSpeackers = false;
        public Student(string firstName = "", string surName = "", string lastName = "", int age = 0, bool doesHaveComputer = true, bool doesHaveSpeackers = true, Discipline[] disciplines = null, int course = 0) : base(firstName, surName, lastName, age)
        {
            FirstName = firstName;
            SurName = surName;
            LastName = lastName;
            Age = age;
            DoesHaveComputer = doesHaveComputer;
            DoesHaveSpeackers = doesHaveSpeackers;
            Disciplines = disciplines;
            Course = course;
        }
        public bool CheckSameTeacher(int index)
        { 
            for(int i = 0; i < Disciplines.Length; ++i)
            {
                if(i == index)
                {
                    continue;
                }
                if(Disciplines[i].Teacher == Disciplines[index].Teacher)
                {
                    Console.WriteLine("This disciplines have the same teacher with discipline : " + Disciplines[i].Name);
                    return true;
                }
            }
            return false;
        }
        #region DoWorksMethods
        public void DoEnglish ()
        {
            for (int i = 0; i < Disciplines.Length; ++i)
            {
                if (Disciplines[i] is English english && DoesHaveSpeackers && DoesHaveComputer && (Course == 1 || Course == 2))
                {
                    english.Practice();
                    english.ModuleWork();
                    english.Test();
                    english.NerrativesOnGivenTopics();
                    english.Reading();
                    english.WritingTests();
                    english.Exam();
                }
            }
        }
        public void DoArchitectureOfSoftware()
        {
            for (int i = 0; i < Disciplines.Length; ++i)
            {
                if(CheckSameTeacher(i))
                {
                    if (Disciplines[i] is ArchitectureOfSoftware architecture && DoesHaveComputer && Course == 2)
                    {
                        architecture.Lecture();
                        architecture.LabWork();
                        architecture.ModuleWork();
                        architecture.CourseWork();
                        architecture.Exam();
                    }

                }
            }
        }
        public void DoOOP()
        {
            for (int i = 0; i < Disciplines.Length; ++i)
            {
                if (Disciplines[i] is OOP oop && DoesHaveComputer && Course == 1)
                {
                    oop.Lecture();
                    oop.Test();
                    oop.LabWork();
                    oop.ModuleWork();
                    oop.CourseWork();
                    oop.Exam();
                }
            }
        }
        #endregion
    }
}
