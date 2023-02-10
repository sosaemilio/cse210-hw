using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("John", "3", "16");
        Console.WriteLine(reference.GetReference());

        string example = "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.";

        List<string> scriptureList = example.Split(' ').ToList();
        

        Scripture scripture = new Scripture(reference, scriptureList);
        for (int i = 0; i < 3; i++) 
        {
            scripture.HideRandomWord();
        }
        scripture.getScripture();


    }
}