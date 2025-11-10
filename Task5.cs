using System;

namespace workshop3
{
    internal class Task5
    {
        public void LoopOperations()
        {
            // 1. For Loop: Sum from 1 to N
            Console.Write("Enter a number (N): ");
            int N = int.Parse(Console.ReadLine());

            int sum = 0;
            for (int i = 1; i <= N; i++)
            {
                sum += i;
            }
            Console.WriteLine($"Sum from 1 to {N} = {sum}");


            // 2. While Loop: Skip multiples of 4, stop when number is 15
            Console.WriteLine("\nNumbers from 1 to 20 (skipping multiples of 4, stop at 15):");
            int num = 1;

            while (num <= 20)
            {
                if (num == 15)
                    break;

                if (num % 4 == 0)
                {
                    num++;
                    continue;
                }

                Console.Write($"{num} ");
                num++;
            }

            // 3. Foreach Loop: Sum elements of an array
            Console.WriteLine("\n\nFinding sum of array elements using foreach...");

            int[] numbers = { 2, 5, 8, 10, 3 };
            int arraySum = 0;

            foreach (int item in numbers)
            {
                arraySum += item;
            }

            Console.WriteLine($"Sum of array elements = {arraySum}");
        }
    }
}
