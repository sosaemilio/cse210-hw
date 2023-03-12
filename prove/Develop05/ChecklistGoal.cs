public class ChecklistGoal : Goal
{
    private int _checklistNumbers;
    private int _completedGoals;
    private int _bonus;
    public ChecklistGoal(string goalName, string shortDescription, int points, int checklistNumbers, int bonusPoints) : base (goalName, shortDescription, points, "ChecklistGoal")
    {
        this._checklistNumbers = checklistNumbers;
        this._completedGoals = 0;
        //These are the points that are added after the goal is completed;
        this._bonus = bonusPoints;

    }

    public ChecklistGoal(string goalName, string shortDescription, int points, int checklistNumbers, int bonusPoints, int completedPoints) : base (goalName, shortDescription, points, "ChecklistGoal")
    {
        this._checklistNumbers = checklistNumbers;
        this._completedGoals = completedPoints;
        //These are the points that are added after the goal is completed;
        this._bonus = bonusPoints;
    }

    public override string GetGoal()
    {
        string goal;
        if (!base.IsCompleted())
        {
            goal = "[ ] " + base._goalName + " " + $"({base._shortDescription}) -- Currently Completed: {_completedGoals}/{_checklistNumbers}"; 
        } 
        else 
        {
            goal = "[X] " + base._goalName + " " + $"({base._shortDescription})"; 
        }
        return goal;
    }

    public override string GetGoalLine()
    {
        //"GoalType:GoalName, GoalDescription, points, bonusPoint, checklistNumber, CompletedChecklists "
        string goal = $"{base._goalType}:{_goalName},{base._shortDescription},{base._points},{_bonus},{_checklistNumbers},{_completedGoals}";
        return goal;
    }
}