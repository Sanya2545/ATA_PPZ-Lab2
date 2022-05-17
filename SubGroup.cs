using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2
{
    class SubGroup
    {
        public string Name { get; set; }
        public Student[] Students;
        public SubGroup(string name = "", Student[] students = null)
        {
            if(students.Length < 10)
            {
                throw new ArgumentException();
            }
            Name = name;
            Students = students;
        }
    }
}
