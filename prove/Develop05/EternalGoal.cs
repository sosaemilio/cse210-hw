public class EternalGoal : Goal
{
    public EternalGoal(string goalName, string shortDescription, int points) : base (goalName, shortDescription, points, "EternalGoal")
    {

    }

    public override string GetGoal()
    {
        string goal = "[ ] " + base._goalName + " " + $"({base._shortDescription})";
        return goal;
    }

    public override string GetGoalLine()
    {
        //"GoalType:GoalName, GoalDescription, points"
        string goal = $"{base._goalType}:{_goalName},{base._shortDescription},{base._points}";
        return goal;
    }
}