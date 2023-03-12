using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>();
        int option = 0;

        do
        {
            int points = 0;
            // Display the points
            foreach (Goal goal in goalList)
            {
                points += goal.GetPoints();
            }
            Console.WriteLine($"You have {points} points. ");

            // Display the menu and save the selected option, then continue depending of the selected option.
            Console.WriteLine("\nMenu Options: \n  1. Create New Goal \n  2. List Goals \n  3. Save Goals \n  4. Load Goals \n  5. Record Event \n  6. Quit");
            Console.Write("Select the choise from the menu: ");
            option = int.Parse(Console.ReadLine());

            // Menu
            switch (option)
            {
                case 1:
                    // Create Goals
                    SimpleGoal simpleGoal = new SimpleGoal("Give a Talk", "Speak in Sacrament meeting when asked", 100);
                    goalList.Add(simpleGoal);
    

                    EternalGoal eternalGoal = new EternalGoal("Study the Scriptures", "Study for at least 10 minutes", 50);
                    goalList.Add(eternalGoal);

                    ChecklistGoal checklistGoal = new ChecklistGoal("Attend the temple", "Attend and perform any ordenance", 50, 3, 500);
                    goalList.Add(checklistGoal);
                    break;
                case 2:
                // List all the Goals
                    for (int i = 0; i < goalList.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {goalList[i].GetGoal()}");
                    }
                    break;
                case 3:
                    // Save the goals into a file
                    SimpleGoal goalFileSaver = new SimpleGoal();
                    goalFileSaver.SaveGoals(goalList, "goals.txt", points);
                    break;
                case 4:
                    // Load the goals into the program
                    goalFileSaver = new SimpleGoal();
                    goalList = goalFileSaver.LoadGoals("goals.txt");
                    break;
                default:
                    Console.WriteLine("You selected an incorrect choice");
                    break;
        }
    } while(option != 6);


    }
}