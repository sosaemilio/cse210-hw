using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        int squaredNumber = SquareNumber(number);

        DisplayResult(name, squaredNumber);

    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberStr = Console.ReadLine();
        int number = int.Parse(numberStr);

        return number;
    }

    static int SquareNumber(int number)
    {
        int squaredNumber = number * number;

        return squaredNumber; 
    }

    static void DisplayResult(string usersName, int squaredNumber)
    {
        Console.Write($"{usersName}, the suqare of your number is {squaredNumber}");
    }
}