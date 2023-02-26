using System;

class Program
{
    static void Main(string[] args)
    {
        bool exit = false;
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
                    breathing.StartActivity();
                    break;
                case 2:
                    ReflectionActivity reflection = new ReflectionActivity();
                    reflection.StartActivity();
                    break;
                case 3:
                    ListingActivity listing = new ListingActivity();
                    listing.StartActivity();
                    break;
                case 4:
                    exit = true;
                    break;
            }
        } while (!exit);
    }


}