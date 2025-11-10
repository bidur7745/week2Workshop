using System;

namespace workshop3
{
    class Program
    {
        static void Main(string[] args)
        {
/* Task 1*/
            Console.WriteLine("============Task1============\n");
            Calculator calculator = new Calculator();
            Console.WriteLine($"Addition: {calculator.Addition()}");
            Console.WriteLine($"Subtraction: {calculator.Subtraction()}");
            Console.WriteLine($"Multiply: {calculator.Multiply()}");
            Console.WriteLine($"Divide: {calculator.Divide()}");

            Oddeven oddeven = new Oddeven();
            Console.WriteLine($"The entered number is {oddeven.checkOddEven()}");


/* Task2  */
            Console.WriteLine("============Task2=======\n");
            NullOpe nullope = new NullOpe();
            Console.WriteLine(nullope.checknull());
            Console.WriteLine(nullope.checknullUsingCoalescingOperator());
            nullope.assignDefaultUsername();

/*tas3*/
            Console.WriteLine("============Task3=======\n");
            AgeTask3 ageTask3 = new AgeTask3();
            ageTask3.checkage();

 /*task4*/
            Console.WriteLine("==========Task4=====\n");
            Task4 task4 = new Task4();
            task4.PrintDayOfWeek();


  /*task5*/
            Console.WriteLine("============Task5=======\n");
            Task5 task5 = new Task5();
            task5.LoopOperations();

 /*task6*/
            Console.WriteLine("============Task6=======\n");
            Task6 task6 = new Task6();
            task6.NumberConversion();
            task6.PasswordValidation();


        }
    }
}
