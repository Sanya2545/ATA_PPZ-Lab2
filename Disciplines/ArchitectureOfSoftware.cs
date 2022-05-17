using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2.Disciplines
{
    class ArchitectureOfSoftware : Discipline
    {
        public ArchitectureOfSoftware(string name = "")
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
        #endregion

    }
}
