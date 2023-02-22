public class Activity 
{
    // Attributes
    private int _duration;
    private string _activityName;
    private string _description;
    private List<string> _randomPrompts = new List<string> {};

    //Constructor
    public Activity()
    {

    }

    //Methods
    public void DisplayActivity()
    {
        Console.WriteLine($"Welcome to the {_activityName}");
        Console.WriteLine(_description);
    }
    public void SetActivity(string activityName, string description)
    {
        this._activityName = activityName;
        this._description = description;
    }
    public void SetDuration(int seconds)
    {
        this._duration = seconds;
    }
    public int GetDuration()
    {
        return _duration;
    }
    public void SetPromptList(List<string> randomPrompts)
    {
        this._randomPrompts = randomPrompts;
    }
    public string GetCloseMessage()
    {
        string closeMessage = "You have completed another " + _duration + " seconds of the " + _activityName;
        return closeMessage;
    }

    public void Wait()
    {
        Thread.Sleep(1000);

    }
}   