using System;

namespace ConsoleApp1
{
    internal class Task6WithError
    {
        static void Main(string[] args)
        {
            Console.Write("Enter marks: ");
            int.TryParse(Console.ReadLine(), out int marks);

            Console.Write("Enter total: ");
            int.TryParse(Console.ReadLine(), out int total);

            // first break point 
            double percentage = marks / total * 100;  

            // second break point 
            Console.WriteLine("Percentage: " + percentage);

            Console.ReadLine();
        }
    }
}
