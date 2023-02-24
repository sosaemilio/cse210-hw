public class ReflectionActivity : Activity
{   
    // Attributes
    private List<string> questions = new List<string>
    {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"
    };

    // Constructor
    public ReflectionActivity()
    {
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        string activityName = "Reflection Activity";
        List<string> prompt = new List<string> 
        {
            "Think of a time when you stood up for someone else.",
            "Think of a time when you did something really difficult.",
            "Think of a time when you helped someone in need.",
            "Think of a time when you did something truly selfless."
        };
        base.SetActivity(activityName, description);
        base.SetPromptList(prompt);
    }

    //Methods
    private string GetQuestions()
    {
        return questions[0];
    }

    public void StartActivity()
    {
        base.DisplayActivity();
        Console.Write("How long would you like to wait in seconds ");
        int duration = int.Parse(Console.ReadLine());
        base.SetDuration(duration);

        Console.Clear();
        Console.WriteLine("Get Ready...");

        Console.WriteLine("\nConsider the following prompt: ");
    }
}