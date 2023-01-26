using System;

class Program
{
    static void Main(string[] args)
    {   
        // Create a Prompt object and generates a prompt
        Prompt randomPrompts = new Prompt();
        string prompt = randomPrompts.generatePrompt();

        // Display the generated prompt and stores the response on a string variable
        Console.WriteLine(prompt);
        string response = Console.ReadLine();

        // Create a date object and generate today's date.
        DateTime date = DateTime.Today;

        // Generate an "Entry" object to store all the entries (prompt, date and response)
        Entry entry = new Entry();
        entry._prompt = prompt;
        entry._date = date.ToString("D");
        entry._response = response;


        // Generates an journal and store the entries into the journal
        Journal journal = new Journal();
        journal.addEntry(entry);
        journal.displayJournal();
    }
}