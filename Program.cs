using System;
using System.Collections.Generic;

namespace WorkshopWeek2
{
    // Task 2: Constants + helper methods
    static class Circle
    {
        public const double PI = 3.14;

        public static double Area(double radius) => PI * radius * radius;
        public static double Perimeter(double radius) => 2 * PI * radius;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            // ===== Task 1: Variables + String Interpolation =====
            string userName = "Bidur Siwakoti";
            int luckyNumber = 7;
            Console.WriteLine($"[Task 1] Hello, {userName}! Your lucky number is {luckyNumber}.");
            Console.WriteLine();

            // ===== Task 2: Constants (PI) + Explanation =====
            Console.WriteLine("[Task 2] Circle constant and helpers");
            Console.WriteLine($"PI (from Circle) = {Circle.PI}");
            
            double r = 5;
            Console.WriteLine($"Radius = {r}, Area = {Circle.Area(r)}, Perimeter = {Circle.Perimeter(r)}");
            Console.WriteLine();

            // ===== Task 3: Data Types & Type Conversion =====
            Console.WriteLine("[Task 3] Data types and conversions");
            byte b = 200;
            short s = -12345;
            int i = 42;
            long l = 9876543210;
            float f = 3.14f;
            double d = 2.718281828;
            decimal m = 199.99m;
            char c = 'B';
            bool flag = true;

            string fortyTwoAsString = i.ToString();
            double threePointFourteen = double.Parse("3.14");

            Console.WriteLine($"byte   b = {b}");
            Console.WriteLine($"short  s = {s}");
            Console.WriteLine($"int    i = {i}");
            Console.WriteLine($"long   l = {l}");
            Console.WriteLine($"float  f = {f}");
            Console.WriteLine($"double d = {d}");
            Console.WriteLine($"decimal m = {m}");
            Console.WriteLine($"char   c = {c}");
            Console.WriteLine($"bool   flag = {flag}");
            Console.WriteLine($"Converted int->string: \"{fortyTwoAsString}\"");
            Console.WriteLine($"Parsed string->double: {threePointFourteen}");
            Console.WriteLine();

            // ===== Task 4: Array + Array Methods =====
            Console.WriteLine("[Task 4] Arrays and array methods");
            int[] favNums = { 7, 23, 5, 11, 3 };
            Console.WriteLine("Original: " + string.Join(", ", favNums));

            Array.Sort(favNums);
            Console.WriteLine("Sorted  : " + string.Join(", ", favNums));

            Array.Reverse(favNums);
            Console.WriteLine("Reversed: " + string.Join(", ", favNums));

            Console.Write("For loop : ");
            for (int idx = 0; idx < favNums.Length; idx++)
            {
                Console.Write(favNums[idx] + (idx < favNums.Length - 1 ? ", " : ""));
            }
            Console.WriteLine();

            int target = 11;
            int pos = Array.IndexOf(favNums, target);
            Console.WriteLine(pos >= 0
                ? $"IndexOf({target}) = {pos}"
                : $"{target} not found");
            Console.WriteLine();

            // ===== Task 5: DateTime + TimeSpan =====
            Console.WriteLine("[Task 5] DateTime and TimeSpan");
            DateTime birthDate = new DateTime(2003, 7, 15); 
            DateTime now = DateTime.Now;
            TimeSpan ageSpan = now - birthDate;

            int ageYears = (int)(ageSpan.TotalDays / 365.2425);

            Console.WriteLine($"Birthdate : {birthDate:yyyy-MM-dd HH:mm}");
            Console.WriteLine($"Now       : {now:yyyy-MM-dd HH:mm}");
            Console.WriteLine($"Age       : ~{ageYears} years");

            DateTime plus10Days = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 days: {plus10Days:yyyy-MM-dd}");
            Console.WriteLine();

            // ===== Task 6: Generic Collections (List & Dictionary) =====
            Console.WriteLine("[Task 6] Generic collections (List & Dictionary)");

            var fruits = new List<string> { "Mango", "Banana", "Apple" };
            fruits.Add("Orange");        // add
            fruits.Remove("Banana");     // remove

            Console.Write("Fruits (foreach): ");
            foreach (var fruit in fruits)
            {
                Console.Write(fruit + " ");
            }
            Console.WriteLine();

            var fruitMap = new Dictionary<int, string>
            {
                {1, "Mango"},
                {2, "Apple"},
                {3, "Orange"}
            };
            fruitMap[4] = "Grapes"; 

            Console.WriteLine("Dictionary (key -> value):");
            foreach (var kv in fruitMap)
            {
                Console.WriteLine($"  {kv.Key} -> {kv.Value}");
            }

            Console.WriteLine();
            Console.WriteLine("All tasks completed ");
        }
    }
}
