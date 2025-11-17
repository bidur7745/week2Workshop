using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Task5
    {
        //i have make DayType as public to access from main method 
        public enum DayType
        {
            Weekday,
            Weekend
        }


        public record Book(string title, string author, double price);


    }
}
