using System.IO;
public abstract class Goal
{
    // Attributes
    protected string _goalName;
    protected string _shortDescription;
    protected int _points;
    protected string _goalType;
    protected bool _complete;

    // Consctructor
    protected Goal()
    {
        
    }
    protected Goal(string goalName, string shortDescription, int points, string goalType)
    {
        this._goalName = goalName;
        this._shortDescription = shortDescription;
        this._points = points;
        this._goalType = goalType;
        this._complete = false;
    }

    // Methods 
    public int GetPoints()
    {   
        int points = 0;
        if (!IsCompleted())
        {
            points = 0;
        } else 
        {
            points = _points;
        }
            
        return points;
    }

    public void SaveGoals(List<Goal> goals, string filename, int totalPoints)
    {
        
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.GetGoalLine());
            }
        }
    }

    public List<Goal> LoadGoals(string filename) 
    {
        List<Goal> goalList = new List<Goal>();
        try
        {
            string[] lines = System.IO.File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] goal = line.Split(":");
            
            //INDEXERS
            int goalType = 0;
            int goalData = 1;

            if (goal[goalType] == "SimpleGoal")
            {
                string[] goalInformation = goal[goalData].Split(",");
                SimpleGoal simpleGoal = new SimpleGoal(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]), bool.Parse(goalInformation[3]));
                goalList.Add(simpleGoal);
            } 
            if (goal[goalType] == "EternalGoal")
            {
                string[] goalInformation = goal[goalData].Split(",");
                EternalGoal eternalGoal = new EternalGoal(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]));
                goalList.Add(eternalGoal);
            }
            if (goal[goalType] == "ChecklistGoal")
            {
                string[] goalInformation = goal[goalData].Split(",");
                ChecklistGoal checklistGoal = new ChecklistGoal(goalInformation[0], goalInformation[1], int.Parse(goalInformation[2]), int.Parse(goalInformation[4]), int.Parse(goalInformation[3]), int.Parse(goalInformation[5]));
                goalList.Add(checklistGoal);
            }
        }
        }
        catch(System.IO.FileNotFoundException e)
        {
            Console.WriteLine($"File not found -- ERROR DESCRIPTION: {e.Message}");
        }
        return goalList;
    }

    public int LoadPoints(string filename)
    {
        return 1;
    }

    protected bool IsCompleted()
    {
        return _complete;
    }

    protected void CompleteGoal()
    {
        this._complete = true;
    }

    public abstract string GetGoal();
    public abstract string GetGoalLine();
    //public abstract void RecordGoal();

}