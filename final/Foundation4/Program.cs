using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Activity> activities = new List<Activity> ();
        Running running = new Running(30, "3 Nov 2022", 3);
        activities.Add(running);
        
        Swimming swimming = new Swimming(24, "01 April 2023", 10);
        activities.Add(swimming);

        Cycling cycling = new Cycling(45, "23 Feb 2023", 12.3);
        activities.Add(cycling);
        foreach (Activity activity in activities)
        {
           Console.WriteLine($"{activity.GetSummary()}\n"); 
        }
    }
}