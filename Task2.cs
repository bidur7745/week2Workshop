using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Calculator
    {
        
        
            public void PrintWelcome()
            {
                Console.WriteLine("Welcome to the calculator");
            }

            public int add(int num1, int num2)
            {
                return num1 + num2;
            }


            public int multiply(int num1, int num2=1)
            {
                return num1 * num2;
            }

        
    }
}
