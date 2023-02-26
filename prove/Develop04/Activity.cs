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
        Console.WriteLine($"Welcome to the {_activityName}\n");
        Console.WriteLine(_description);
    }
    public void SetActivity(string activityName, string description)
    {
        this._activityName = activityName;
        this._description = description;
    }
    public void SetPromptList(List<string> randomPrompts)
    {
        this._randomPrompts = randomPrompts;
    }

    public void SetDuration(int seconds)
    {
        this._duration = seconds;
    }
    public int GetDuration()
    {
        return _duration;
    }

    public string GetCloseMessage()
    {
        string closeMessage = "You have completed another " + _duration + " seconds of the " + _activityName;
        return closeMessage;
    }

    public string GetPrompt(int max)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(max);
        return _randomPrompts[randomNumber];
    }

    public void Wait()
    {
        List<string> animation = new List<string> {"|", "/", "-", @"\", "|" , "/", "-", @"\", "|"};
        foreach(string icon in animation)
        {
            Console.Write(icon);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

}   