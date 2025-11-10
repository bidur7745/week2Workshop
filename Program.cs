using System;

namespace workshop3
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();

            Console.WriteLine($"Addition: {calculator.Addition()}");
            Console.WriteLine($"Subtraction: {calculator.Subtraction()}");
            Console.WriteLine($"Multiply: {calculator.Multiply()}");
            Console.WriteLine($"Divide: {calculator.Divide()}");

            Oddeven oddeven = new Oddeven();
            Console.WriteLine($"The entered number is {oddeven.checkOddEven()}");

        }
    }
}
