public class SimpleGoal : Goal
{
    public SimpleGoal(string goalName, string shortDescription, int points) : base (goalName, shortDescription, points, "SimpleGoal")
    {

    }
    public SimpleGoal(string goalName, string shortDescription, int points, bool completed) : base (goalName, shortDescription, points, "SimpleGoal")
    {
        this._complete = completed;
    }

    public SimpleGoal()
    {

    }

    public override string GetGoal()
    {
        string goal;
        if (!base.IsCompleted())
        {
            goal = "[ ] " + base._goalName + " " + $"({base._shortDescription})"; 
        } 
        else 
        {
            goal = "[X] " + base._goalName + " " + $"({base._shortDescription})"; 
        }
        return goal;
    }

    public override string GetGoalLine()
    {
        //"GoalType:GoalName, GoalDescription, points, isCompleted"
        string goal = $"{base._goalType}:{_goalName},{base._shortDescription},{base._points},{base.IsCompleted()}";
        return goal;
    }
}