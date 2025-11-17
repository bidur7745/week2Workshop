using System;

namespace ConsoleApp1
{
    internal class Task6Corrected
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks: ");
            int.TryParse(Console.ReadLine(), out int marks);

            Console.Write("Enter total: ");
            int.TryParse(Console.ReadLine(), out int total);

            // breakpoint 1
            double percentage = (double)marks / total * 100;   

            // breakpoint 2 
            Console.WriteLine("Percentage: " + percentage);

            Console.ReadLine();
        }
    }
}

//Because marks and total are integers, the expression marks / total performs integer division, which removes the decimal part and gives an incorrect result.
//Converting  one value to double  so the division becomes floating value  instead of integer, giving the correct percentage.