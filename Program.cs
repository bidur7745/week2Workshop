using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //task1
            Console.WriteLine("===========Task2==============\n");
            Student s1 = new Student();
            s1.Name = "Bidur";
            s1.Age = 20;
            s1.StudentId = "S001";

            Student s2 = new Student();
            s2.Name = "David";
            s2.Age = 21;
            s2.StudentId = "S002";

            Console.WriteLine("---- Student 1 ----");
            Console.WriteLine("Name: " + s1.Name);
            Console.WriteLine("Age: " + s1.Age);
            Console.WriteLine("ID: " + s1.StudentId);

            Console.WriteLine("\n---- Student 2 ----");
            Console.WriteLine("Name: " + s2.Name);
            Console.WriteLine("Age: " + s2.Age);
            Console.WriteLine("ID: " + s2.StudentId);

            Console.WriteLine("Total Students: " + Student.TotalStudents);

   //task2
            Console.WriteLine("====Task2====");
            Calculator calculator = new Calculator();
            calculator.PrintWelcome();
            Console.WriteLine(calculator.multiply(3, 4));
            Console.WriteLine(calculator.multiply(3));

  //task3
            Console.WriteLine("============task3===============\n");
            ParameterDemo demo = new ParameterDemo();
            int value = 5;
            demo.Increase(ref value);
            Console.WriteLine("After Increase: " + value);
            string fullName;
            demo.GetFullName(out fullName);
            Console.WriteLine("Full Name: " + fullName);
            int total = demo.SumAll(2, 4, 6, 8);
            Console.WriteLine("Sum: " + total);


 //task4
            Console.WriteLine("======task4=========");
            // Object 1: Default constructor
            Player p1 = new Player();
            p1.playerName = "Default Player";
            p1.level = 1;
            p1.health = 100;

            // Object 2: Parameterized constructor
            Player p2 = new Player("EvilEverest", 10, 250);

            // printing values of object 1
            Console.WriteLine("\n--- Player 1 Details ---");
            Console.WriteLine("Name: " + p1.playerName);
            Console.WriteLine("Level: " + p1.level);
            Console.WriteLine("Health: " + p1.health);

            // Printing values of object 2
            Console.WriteLine("\n--- Player 2 Details ---");
            Console.WriteLine("Name: " + p2.playerName);
            Console.WriteLine("Level: " + p2.level);
            Console.WriteLine("Health: " + p2.health);

//Task5 
        Console.WriteLine("=========tsk5=======");
            Console.Write("Enter a day: ");
            string day = Console.ReadLine().Trim().ToLower();
            Task5.DayType type;
            if (day == "friday" || day == "saturday")
                type = Task5.DayType.Weekend;
            else
                type = Task5.DayType.Weekday;

            Console.WriteLine("It is: " + type);

            // 1st book object
            Task5.Book b1 = new Task5.Book("Bidur Siwakoti's Philosophy", "Bidur Siwakoti", 999);

            // 2nd object using 'with'
            Task5.Book b2 = b1 with { title = "Rich Bau Garib Son ", price = 799 };

            // Print first book
            Console.WriteLine("\n--- Book 1 ---");
            Console.WriteLine($"Title: {b1.title}");
            Console.WriteLine($"Author: {b1.author}");
            Console.WriteLine($"Price: {b1.price}");

            // Deconstruct second book
            var (title, author, price) = b2;

            Console.WriteLine("\n--- Book 2 Deconstructed ---");
            Console.WriteLine($"Title: {title}");
            Console.WriteLine($"Author: {author}");
            Console.WriteLine($"Price: {price}");





        }
    }
}
