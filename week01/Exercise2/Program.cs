using System;

class Program
{
    static void Main(string[] args)
    {
        //Grading System
        Console.WriteLine("Welcome to Grading System!!!!!");

        //Ask for student grade;
        Console.Write("What is your Grade?: ");
        string grade = Console.ReadLine();
        int number = int.Parse(grade);

        //Conditional statement
        string letter;

        //90%
        if ((number >= 90) && (number <= 100)) 
        {
            letter = "A";
        }
        //80%
        else if ((number >= 80) && (number < 90))
        {
            letter = "B";
        }
        //70%
        else if ((number >= 70) && (number < 80))
        {
            letter = "C";
        }
        //60%
        else if ((number >= 60) && (number < 70))
        {
            letter = "D";
        }
        //Below 60% fail
        else
        {
            letter = "F";
        }
        Console.WriteLine($"Your Grade is {letter}");

        //Pass with Congratulation message
        if (number >= 70)
        {
            Console.WriteLine($"Congratulation you Passed and your Grade is {letter}.");
        }
        
        //Fail
        else
        {
            Console.WriteLine($"Sorry your Grade {letter} did not meet the Pass mark, Try again next time");
        }
        //Console.WriteLine("Hello World! This is the Exercise2 Project.")
    }
}