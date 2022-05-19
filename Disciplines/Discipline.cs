using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2
{
    public class Discipline : IDiscipline
    {
        public Teacher Teacher { get; set; }
        public string Name { get; set; }
        public Discipline(string name = "", Teacher teacher = null)
        {
            Name = name;
            Teacher = teacher;
        }
        public void ModuleWork()
        {
                Console.WriteLine("Doing module work for " + Name);
        }
        public void Exam()
        {
            Console.WriteLine("Doing exam for " + Name);
        }
    }
}
