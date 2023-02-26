using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
        Log activityLog = new Log();
        do
        {
            Console.Clear();
            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflection activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a Choose from the Menu: ");
            int option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    BreathingActivity breathing = new BreathingActivity();
                    activityLog.SaveLog("Breathing");
                    breathing.StartActivity();
                    break;
                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    activityLog.SaveLog("Reflection");
                    reflection.StartActivity();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    activityLog.SaveLog("Listing");
                    listing.StartActivity();
                    break;
                case 4:
                    Console.Write($"{activityLog.GetLogsInteger()} activities were completed.");
                    exit = true;
                    break;
            }
        } while (!exit);
    }


}