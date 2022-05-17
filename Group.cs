using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2
{
    public class Group
    {
        public string Name{ get; set; }
        public Student[] Students;
        public Group(string name = "", Student[] students = null)
        {
            Name = name;
            Students = students;
        }
    }
}
