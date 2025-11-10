using System;

namespace workshop3
{
    internal class Calculator
    {
        private int a;
        private int b;

        public Calculator()
        {
            Console.Write("Enter the value of a: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Enter the value of b: ");
            b = int.Parse(Console.ReadLine());
        }

        public int Addition() => a + b;

        public int Subtraction() => a - b;

        public int Multiply() => a * b;

        public double Divide()
        {
            return b != 0 ? (double)a / b : double.NaN;
        }
    }
}
