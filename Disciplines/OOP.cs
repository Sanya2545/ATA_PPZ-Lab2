using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2
{
    public class OOP : Discipline
    {
        public OOP(string name = "", Teacher teacher = null)
        {
            Name = name;
            Teacher = teacher;
        }
        #region Types Of Works
        public void Lecture()
        {
            Console.WriteLine("Reading lecture for " + Name + "\n" + Teacher.GetFullName());
        }
        public void LabWork()
        {
            Console.WriteLine("Doing lab work for " + Name + "\n" + Teacher.GetFullName());
        }
        public void CourseWork()
        {
            Console.WriteLine("Doing course work for " + Name + "\n" + Teacher.GetFullName());
        }
        public void Test()
        {
            Console.WriteLine("Doing test for " + Name + "\n" + Teacher.GetFullName());
        }
        #endregion

    }
}
