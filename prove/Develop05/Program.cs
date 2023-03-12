using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        List<Goal> goalList = new List<Goal>();
        int option = 0;
        int totalPoints = 0;

        do
        {
            Console.WriteLine($"\nYou have {totalPoints} points. ");

            // Display the menu and save the selected option, then continue depending of the selected option.
            Console.WriteLine("\nMenu Options: \n  1. Create New Goal \n  2. List Goals \n  3. Save Goals \n  4. Load Goals \n  5. Record Event \n  6. Quit");
            Console.Write("Select the choise from the menu: ");

            // Exception in case the user uses a value that is not an integer
            try
            {
                option = int.Parse(Console.ReadLine());
            }
            catch (System.FormatException e)
            {
                Console.WriteLine($"Incorrect Value Type -- ERROR DESCRIPTION: {e.Message} \n");
            }

            // MAIN MENU
            switch (option)
            {
                case 1:
                    // Create Goals
                    Console.WriteLine("The types of Goals are: \n  1. Simple Goal \n  2. Eternal Goal \n  3. Checlist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goalOption = int.Parse(Console.ReadLine());
                    
                    switch (goalOption)
                    {
                        case 1:
                            goalList.Add(CreateSimpleGoal());
                            break;
                        case 2:
                            goalList.Add(CreateEternalGoal());
                            break;
                        case 3:
                            
                            goalList.Add(createChecklistGoal());
                            break;
                        default:
                            Console.WriteLine("Try again");
                            break;
                    }
                    break;
                case 2:
                    // List all the Goals
                    Console.WriteLine("Your goals are: ");
                    for (int i = 0; i < goalList.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {goalList[i].GetGoal()}");
                    }
                    break;
                case 3:
                    // Save the goals into a file
                    Console.Write("What is the filename for the goal file? ");
                    string filename = Console.ReadLine();

                    SimpleGoal goalFileSaver = new SimpleGoal();
                    goalFileSaver.SaveGoals(goalList, filename, totalPoints);
                    break;
                case 4:
                    // Load the goals into the program
                    Console.Write("What is the filename for the goal file? ");
                    string loadedFilename = Console.ReadLine();

                    SimpleGoal fileLoader = new SimpleGoal();
                    goalList = fileLoader.LoadGoals(loadedFilename);
                    totalPoints = fileLoader.LoadPoints(loadedFilename);
                    break;
                case 5:
                    // Records the Goal Completion
                    Console.WriteLine("The goals are: ");
                    for (int i = 0; i < goalList.Count(); i++)
                    {
                        Console.WriteLine($"{i + 1}. {goalList[i].GetGoalName()}");
                    }

                    Console.Write("Which goal did you accomplish? ");
                    int accomplishedGoal = int.Parse(Console.ReadLine());
                    int earnedPoints = goalList[accomplishedGoal - 1].RecordGoal();
                    
                    // Determinates is the goal was completed or not, the purpose is to display a custom message
                    if (earnedPoints == 0)
                    {
                        Console.WriteLine("Goal already completed");
                    }
                    else
                    {
                        Console.WriteLine($"Congratulations! You have earned {earnedPoints}!");
                        totalPoints += earnedPoints;
                        Console.WriteLine($"You now have {totalPoints}");
                    }
                    
                    break;
                case 6:
                    Console.WriteLine("Have a great day!");
                    break;
                default:
                    Console.WriteLine("You selected an incorrect choice");
                    break;
            }
        } while(option != 6);


        /***
        *  
        *  Functions
        *  
        ***/

        SimpleGoal CreateSimpleGoal()
        {
            Console.Write("What is the name of your Goal: ");
            string goalName = Console.ReadLine();

            Console.Write("What is short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the number of point associated with this task? ");
            int points = int.Parse(Console.ReadLine());

            SimpleGoal simpleGoal = new SimpleGoal(goalName, description, points);
            return simpleGoal;
        }

        EternalGoal CreateEternalGoal()
        {
            Console.Write("What is the name of your Goal: ");
            string goalName = Console.ReadLine();

            Console.Write("What is short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the number of point associated with this task? ");
            int points = int.Parse(Console.ReadLine());

            EternalGoal eternalGoal = new EternalGoal("Study the Scriptures", "Study for at least 10 minutes", 50);
            return eternalGoal;
        }

        ChecklistGoal createChecklistGoal()
        {
            Console.Write("What is the name of your Goal: ");
            string goalName = Console.ReadLine();

            Console.Write("What is short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the number of point associated with this task? ");
            int points = int.Parse(Console.ReadLine());

            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int checksForBonus = int.Parse(Console.ReadLine());

            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonusPoints = int.Parse(Console.ReadLine());

            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, description, points, checksForBonus, bonusPoints);
            return checklistGoal;
        }
    }
}