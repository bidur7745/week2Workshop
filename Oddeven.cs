using System;

namespace workshop3
{
    internal class Oddeven
    {
        private int checkNum; 
        public Oddeven()
        {
            Console.WriteLine("Enter the number: ");
            checkNum = int.Parse(Console.ReadLine());
        }

        public string checkOddEven()
        {
            return checkNum % 2 == 0 ? "Even" : "Odd";
        }
    }
}
