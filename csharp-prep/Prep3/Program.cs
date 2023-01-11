using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");

        string input = "yes";

        while (input == "yes")
        {

            // Creates the random number from 1 to 100
            Random randomNumber = new Random();
            int magicNumber = randomNumber.Next(1, 100);

            // Declare the guest number variable
            int guestNumber;
            int attempts = 0;

            // Guest Number logic
            do
            { 
                Console.Write("What is your guest number? ");
                string number = Console.ReadLine();
                guestNumber = int.Parse(number);

                if (guestNumber > magicNumber) 
                {
                    Console.WriteLine("Lower");
                    attempts += 1;
                } 
                else if (guestNumber < magicNumber)
                {
                    Console.WriteLine("Higher");
                    attempts += 1;   
                } 
                else
                {
                    Console.WriteLine("You guessed it!");
                    Console.WriteLine($"Your attempts {attempts}");
                }
            } while (guestNumber != magicNumber);

            Console.Write("Would you like to try again? ");
            input = Console.ReadLine();
            input.ToLower();
        }
    }
}