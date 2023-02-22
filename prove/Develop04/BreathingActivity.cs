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
        base.DisplayActivity();
        Console.Write("How long would you like to wait in seconds ");

        int duration = int.Parse(Console.ReadLine()) * 1000;
        base.SetDuration(duration);

        Console.Clear();
        Console.WriteLine("Get Ready...");

        Breath();
        Console.WriteLine("\nWell done... ");
    }

    private void Breath()
    {   
        Console.Write("Breathe in..."); 
        for (int i = 6; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b"); 
        }
        
        Console.Write("\nNow breathe out...");
        for (int i = 6; i > 0; i --)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        
    }
}