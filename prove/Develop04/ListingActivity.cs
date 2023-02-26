public class ListingActivity : Activity
{
    int completedActivities = 0;
    public ListingActivity()
    {
        string description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        string activityName = "Reflection Activity";
        List<string> prompt = new List<string> 
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
        base.SetActivity(activityName, description);
        base.SetPromptList(prompt);
    }

    public void StartActivity()
    {
        Console.Clear();
        base.DisplayActivity();
        Console.Write("\nHow long would you like to wait in seconds ");
        int duration = int.Parse(Console.ReadLine());
        base.SetDuration(duration);

        Console.Clear();
        Console.WriteLine("Get Ready...");
        base.Wait();

        Console.WriteLine("\nList as many responses you can to the following prompt");
        Console.WriteLine($"--- {base.GetPrompt(4)} ---");
        Console.Write("You may begin in: ");
        for (int i = 4; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(base.GetDuration());
        Console.WriteLine();

        while (currentTime < endTime)
        {
            Console.Write("> ");
            Console.ReadLine();
            completedActivities += 1;
            currentTime = DateTime.Now;
        }

        Console.WriteLine($"\nYou listed {completedActivities} items!");
        Console.WriteLine("\nWell done!!");
        base.Wait();
        Console.WriteLine($"\n{base.GetCloseMessage()}");
        base.Wait();
    }
}