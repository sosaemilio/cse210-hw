using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");

        Console.Write("What is your percentage grade? ");
        string string_grade = Console.ReadLine();
        int grade = int.Parse(string_grade);


        string letter;
   
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80 || grade <= 70)
        {
            letter = "B";
        }
        else if (grade >= 70 || grade <= 60)
        {
            letter = "C";
        }
        else if (grade >= 60 || grade <= 50)
        {
            letter = "D";
        }      
        else 
        {
            letter = "F";
        }

        Console.WriteLine($"Your grade is {letter}");

        if (grade >= 70) 
        {
            Console.WriteLine("Congratulations! You passed the course.");
        } else 
        {
            Console.WriteLine("You didn't pass the course.");
        }
    }
}