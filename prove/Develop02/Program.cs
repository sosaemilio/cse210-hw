using System;

class Program
{
    static void Main(string[] args)
    {   
        Journal journal = new Journal();
        bool exit = false;

        while (!exit)
        {
            Console.WriteLine("Please select one of the following:");
            Console.WriteLine("1. Write \n2. Display\n3. Load \n4. Save \n5. Exit");
            int option = int.Parse(Console.ReadLine());

            if (option == 1) 
            {
                // Create a Prompt object and generates a prompt
                Prompt randomPrompts = new Prompt();
                string prompt = randomPrompts.GeneratePrompt();

                // Display the generated prompt and stores the response on a string variable
                Console.WriteLine(prompt);
                string response = Console.ReadLine();

                // Create a date object and generate today's date.
                DateTime date = DateTime.Today;

                // Generate an "Entry" object
                Entry entry = new Entry(date.ToString("d"), prompt, response);
                
                // Generates an journal and store the entries into the journal
                journal.AddEntry(entry);
            } 
            else if (option == 2) 
            {
                journal.DisplayJournal();
            } 
            else if (option == 3)
            {
                Console.WriteLine("\nWhat is the filename?");
                string filename = Console.ReadLine();
                journal.LoadFile(filename);
            }
            else if (option == 4)
            {
                Console.WriteLine("\nWhat is the filename?");
                string filename = Console.ReadLine();
                journal.SaveFile(filename);
            } 
            else if (option == 5)
            {
                exit = true;
            }
            else
            {
                Console.WriteLine("You chose an incorrect option, please try again");
            }
        }
    }
}