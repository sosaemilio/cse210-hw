using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Event> events = new List<Event> ();
        
        LectureEvent lecture = new LectureEvent("Book of Mormon", "Lorem Ipsum Description about the Book of Mormon lecture", "03-11-2023", "11:40", "7807 Brickyard Street", "Easley", "SC", "United States", "Emilio Sosa", 21);
        events.Add(lecture);
        
        OutdoorEvent outdoorEvent = new OutdoorEvent("Kayla's Birthday", "Come to my 16 party at my parent's home", "07-10-2023", "19:00", "7748 N. Heritage Court", "Hilliard", "OH", "United States", "Cloudy");
        events.Add(outdoorEvent);

        ReceptionEvent reception = new ReceptionEvent("Matt and Jane's Wedding", "You are invited to our wedding, more details will be provided with the RSVP", "10-10-2023", "21:00", "177 Arnold Street", "Smyrna", "GA", "United States", "emilio-test@byui.ed");
        events.Add(reception);

        foreach (Event activity in events)
        {
            Console.WriteLine("<----- EVENT ----->\n");
            Console.WriteLine("\n/*** STANDARD DETAILS ***/");
            Console.WriteLine(activity.GetStandardDetails());
            Console.WriteLine("\n/*** FULL DETAILS ***/");
            Console.WriteLine(activity.GetFullDetails());
            Console.WriteLine("\n/*** SHORT DETAILS ***/");
            Console.WriteLine($"{activity.GetShortDescription()}\n");
        }
        
    }
}