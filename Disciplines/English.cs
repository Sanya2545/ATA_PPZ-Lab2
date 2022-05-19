using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2.Disciplines
{
    internal class English : Discipline
    {
        public bool IsDone{ get; set; }
        public English(string name = "", Teacher teacher = null)
        {
            Name = name;
            Teacher = teacher;
        }
        #region Types Of Work
        public void Practice()
        {
            Console.WriteLine("Doing practice for " + Name + "\n" + Teacher.GetFullName());
        }
        public void Test()
        {
            Console.WriteLine("Doing test for " + Name + "\n" + Teacher.GetFullName());
        }
        public void Reading()
        {
            Console.WriteLine("Reading a text for " + Name + "\n" + Teacher.GetFullName());
        }
        public void WritingTests()
        {
            Console.WriteLine("Writing tests for " + Name + "\n" + Teacher.GetFullName());
        }
        public void NerrativesOnGivenTopics()
        {
            Console.WriteLine("Telling nerrative on given topic for " + Name + "\n" + Teacher.GetFullName());
        }
        #endregion
    }
}
