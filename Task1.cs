using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Student  
    {
        public string Name;
        public int Age;
        public string StudentId;

        public static int TotalStudents = 0;

        public Student()
        {
            TotalStudents++;
        }
    }   
}