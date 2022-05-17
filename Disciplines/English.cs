using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabWork_2.Disciplines
{
    internal class English : Discipline
    {
        
        public Teacher Teacher { get; set; }
        public English(string name = "")
        {
            Name = name;
        }
        public void Practice()
        {
            Console.WriteLine("Doing practice for " + Name);
        }
        public void Test()
        {
            Console.WriteLine("Doing test for " + Name);
        }
        public void Reading()
        {
            Console.WriteLine("Reading a text !!! ");
        }
        public void WritingTests()
        {
            Console.WriteLine("Writing tests !!!");
        }
        public void NerrativesOnGivenTopics()
        {
            Console.WriteLine("Telling nerrative on given topic !");
        }
    }
}
