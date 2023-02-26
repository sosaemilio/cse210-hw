public class BreathingActivity : Activity 
{
    // Attributes

    //Constructor
    public BreathingActivity()
    {
        string description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.";
        string activityName = "Breathing Activity";
        base.SetActivity(activityName, description);
    }

    public void StartActivity()
    {
        Console.Clear();
        base.DisplayActivity();
        Console.Write("\nHow long would you like to wait in seconds ");
        int duration = int.Parse(Console.ReadLine());
        base.SetDuration(duration);
        int attempts = duration / 6;

        
        Console.Clear();
        Console.Write("Get Ready...\n");
        base.Wait();
        
        for (int i = 0; i < attempts; i++)
        {
            Breath();
        }

        Console.WriteLine("\n \nWell done!!");
        base.Wait();
        Console.WriteLine($"\n{base.GetCloseMessage()}");
        base.Wait();
    }

    private void Breath()
    {   
        Console.Write("\n\nBreathe in..."); 
        for (int i = 3; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
        
        Console.Write("\nNow breathe out...");
        for (int i = 3; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}