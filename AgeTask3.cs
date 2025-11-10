using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop3
{
    internal class AgeTask3
    {
        public void  checkage()
        {
            Console.WriteLine("Enter your age: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 13) { Console.WriteLine("you are child"); }
            else if (age<13 &&  age > 19) { Console.WriteLine("Your are Teenager"); }
            else if (age >= 20) { Console.WriteLine("you are adult"); }
        }
    }
}
