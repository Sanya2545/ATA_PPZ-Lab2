using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2
{
    public class OOP : Discipline
    {
        public OOP(string name = "")
        {
            Name = name;
        }
        #region TypeOfWorks
        public void Lecture()
        {
            Console.WriteLine("Reading lecture for " + Name);
        }
        public void LabWork()
        {
            Console.WriteLine("Doing lab work for " + Name);
        }
        public void CourseWork()
        {
            Console.WriteLine("Doing course work for " + Name);
        }
        public void Test()
        {
            Console.WriteLine("Doing test for " + Name);
        }
        #endregion

    }
}
